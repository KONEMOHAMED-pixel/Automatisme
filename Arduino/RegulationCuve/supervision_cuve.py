#!/usr/bin/env python3
"""Supervision Tkinter pour RegulationCuveMega.ino, Raspberry Pi 5 / USB.

L'Arduino execute la regulation ; Python affiche les mesures et envoie les
commandes. Aucune commande de marche n'est envoyee lors de la connexion.
Installation Raspberry Pi OS : sudo apt install python3-tk python3-serial
"""
import json
import math
import os
import queue
import threading
import time
import tkinter as tk
from tkinter import messagebox, scrolledtext, ttk

try:
    import serial
    from serial.tools import list_ports
except ImportError as exc:
    raise SystemExit(
        "pySerial manque. Sur Raspberry Pi OS : "
        "sudo apt install python3-tk python3-serial"
    ) from exc

BAUDRATE = 115200
HEARTBEAT_SECONDS = 1.0
TELEMETRY_TIMEOUT = 2.5
ALARMS = {
    "NONE": "Aucune alarme",
    "NOT_READY": "Attente de 3 mesures valides",
    "SENSOR": "Défaut capteur : contrôler puis réarmer",
    "HIGH_FLOAT": "Flotteur haut ouvert ou fil coupé",
    "FILL_TIMEOUT": "Temps maximal de remplissage dépassé",
    "LINK_LOST": "Liaison perdue : réarmement nécessaire",
    "CONFIG": "Calibration Arduino incorrecte",
}


def validate_thresholds(low_text, high_text):
    """Consignes entieres identiques a celles acceptees par la Mega."""
    try:
        low, high = int(low_text), int(high_text)
    except (TypeError, ValueError) as exc:
        raise ValueError("Saisir deux pourcentages entiers.") from exc
    if not 1 <= low < high <= 95 or high - low < 3:
        raise ValueError("Seuils entre 1 et 95 %, avec au moins 3 points d'écart.")
    return low, high


def parse_status(line):
    """Refuser une trame incomplete/incoherente : elle ne rafraichit pas l'IHM."""
    data = json.loads(line)
    if not isinstance(data, dict) or data.get("type") != "status":
        raise ValueError("Type de trame inconnu")
    if data.get("mode") not in {"STOP", "AUTO", "MANUAL"}:
        raise ValueError("Mode inconnu")
    if type(data.get("pump")) is not int or data["pump"] not in (0, 1):
        raise ValueError("Commande relais invalide")
    if type(data.get("valid")) is not int or data["valid"] not in (0, 1):
        raise ValueError("Validité capteur invalide")
    if data.get("alarm") not in ALARMS:
        raise ValueError("Alarme inconnue")
    if type(data.get("ms")) is not int or not 0 <= data["ms"] <= 0xFFFFFFFF:
        raise ValueError("Horodatage invalide")
    if type(data.get("low")) is not int or type(data.get("high")) is not int:
        raise ValueError("Seuils invalides")
    validate_thresholds(data["low"], data["high"])
    for key, maximum in (("level", 100), ("distance_cm", 400)):
        value = data.get(key)
        if data["valid"]:
            if type(value) not in (int, float) or not math.isfinite(value):
                raise ValueError("Mesure invalide")
            if not 0 <= value <= maximum:
                raise ValueError("Mesure hors plage")
        elif value is not None:
            raise ValueError("Mesure non disponible attendue")
    if data["pump"] and (data["mode"] == "STOP" or not data["valid"]
                         or data["alarm"] != "NONE"):
        raise ValueError("État relais incohérent")
    return data


class SerialWorker(threading.Thread):
    """Un seul thread possede le port ; tous les widgets restent dans Tk."""

    def __init__(self, port):
        super().__init__(daemon=True)
        self.port_name = port
        self.commands = queue.Queue(maxsize=100)
        self.events = queue.Queue(maxsize=400)
        self.stop_event = threading.Event()

    def publish(self, kind, value=""):
        try:
            self.events.put_nowait((kind, value))
        except queue.Full:
            # Garder des informations recentes si l'affichage a ete bloque.
            try:
                self.events.get_nowait()
            except queue.Empty:
                pass
            self.events.put_nowait((kind, value))

    def send(self, command):
        try:
            self.commands.put_nowait(command)
            return True
        except queue.Full:
            return False

    def request_stop(self):
        self.stop_event.set()

    def run(self):
        port = None
        try:
            options = dict(port=self.port_name, baudrate=BAUDRATE,
                           timeout=0.05, write_timeout=0.5)
            if os.name == "posix":
                options["exclusive"] = True
            port = serial.Serial(**options)
            # L'ouverture USB peut reinitialiser la Mega ; laisser finir le boot.
            if self.stop_event.wait(2.0):
                return
            port.reset_input_buffer()
            port.write(b"STOP\nPING\nSTATUS\n")
            self.publish("connected", self.port_name)
            received = bytearray()
            discarding = False
            while not self.stop_event.is_set():
                for _ in range(20):
                    try:
                        command = self.commands.get_nowait()
                    except queue.Empty:
                        break
                    port.write((command + "\n").encode("ascii"))
                chunk = port.read(min(max(port.in_waiting, 1), 512))
                for byte in chunk:
                    if byte == 10:
                        if not discarding and received:
                            line = received.decode("ascii", errors="replace").strip()
                            self.publish("line", (time.monotonic(), line))
                        elif discarding:
                            self.publish("notice", "Trame trop longue ignorée")
                        received.clear()
                        discarding = False
                    elif not discarding:
                        if len(received) < 512:
                            received.append(byte)
                        else:
                            received.clear()
                            discarding = True
        except (serial.SerialException, OSError, ValueError) as exc:
            self.publish("error", str(exc))
        finally:
            if port is not None:
                try:
                    port.write(b"STOP\n")
                except (serial.SerialException, OSError):
                    pass  # La Mega arretera aussi sur absence de PING.
                try:
                    port.close()
                except (serial.SerialException, OSError):
                    pass
            self.publish("disconnected")


class Supervision(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("Supervision de cuve — Arduino Mega / Raspberry Pi 5")
        self.geometry("950x700")
        self.minsize(790, 640)
        self.worker = None
        self.connected = False
        self.connected_at = 0.0
        self.last_status_time = 0.0
        self.last_ping = 0.0
        self.status = None
        self.stale_announced = False
        self.closing = False
        self.close_deadline = 0.0
        self.first_status = True
        self.port_var = tk.StringVar()
        self.low_var = tk.StringVar(value="20")
        self.high_var = tk.StringVar(value="90")
        self.connection_var = tk.StringVar(value="Déconnecté")
        self.level_var = tk.StringVar(value="— %")
        self.distance_var = tk.StringVar(value="Distance : — cm")
        self.mode_var = tk.StringVar(value="Mode : —")
        self.pump_var = tk.StringVar(value="Relais pompe : état inconnu")
        self.thresholds_var = tk.StringVar(value="Seuils Arduino : —")
        self.alarm_var = tk.StringVar(value="Connecter l'Arduino par USB")
        self._build()
        self.refresh_ports()
        self.protocol("WM_DELETE_WINDOW", self.close)
        self.after(100, self.tick)

    def _build(self):
        self.columnconfigure(0, weight=1)
        self.rowconfigure(1, weight=1)
        bar = ttk.Frame(self, padding=12)
        bar.grid(row=0, column=0, sticky="ew")
        ttk.Label(bar, text="Port USB").pack(side="left")
        self.port_box = ttk.Combobox(bar, textvariable=self.port_var, width=24)
        self.port_box.pack(side="left", padx=8)
        ttk.Button(bar, text="Actualiser", command=self.refresh_ports).pack(side="left")
        self.connect_button = ttk.Button(bar, text="Connecter", command=self.toggle_connection)
        self.connect_button.pack(side="left", padx=8)
        ttk.Label(bar, textvariable=self.connection_var).pack(side="left", padx=6)

        main = ttk.Frame(self, padding=(12, 0, 12, 10))
        main.grid(row=1, column=0, sticky="nsew")
        main.columnconfigure(0, weight=1)
        main.columnconfigure(1, weight=1)
        main.rowconfigure(0, weight=1)
        view = ttk.LabelFrame(main, text="Niveau mesuré", padding=10)
        view.grid(row=0, column=0, sticky="nsew", padx=(0, 10))
        self.canvas = tk.Canvas(view, width=320, height=300, bg="#f5f8fc", highlightthickness=0)
        self.canvas.pack(expand=True, fill="both")
        self.canvas.bind("<Configure>", lambda event: self.draw_tank())
        ttk.Label(view, textvariable=self.level_var, font=("Arial", 25, "bold")).pack()
        ttk.Label(view, textvariable=self.distance_var).pack(pady=4)
        ttk.Label(view, textvariable=self.thresholds_var).pack(pady=4)

        controls = ttk.LabelFrame(main, text="Commande", padding=14)
        controls.grid(row=0, column=1, sticky="nsew")
        controls.columnconfigure(0, weight=1)
        controls.columnconfigure(1, weight=1)
        ttk.Label(controls, textvariable=self.mode_var, font=("Arial", 14, "bold")).grid(
            row=0, column=0, columnspan=2, sticky="w", pady=6)
        ttk.Label(controls, textvariable=self.pump_var).grid(
            row=1, column=0, columnspan=2, sticky="w", pady=6)
        self.buttons = {}
        commands = [("AUTO", "Mode automatique"), ("MANUAL", "Mode manuel"),
                    ("ON", "Marche pompe"), ("OFF", "Arrêt pompe")]
        for index, (command, label) in enumerate(commands):
            button = ttk.Button(controls, text=label,
                                command=lambda cmd=command: self.send(cmd))
            button.grid(row=2 + index // 2, column=index % 2, sticky="ew", padx=3, pady=5)
            self.buttons[command] = button
        self.stop_button = tk.Button(controls, text="ARRÊT DU SYSTÈME", bg="#b4232c",
                                     fg="white", font=("Arial", 12, "bold"),
                                     command=lambda: self.send("STOP"))
        self.stop_button.grid(row=4, column=0, columnspan=2, sticky="ew", pady=10)
        ttk.Label(controls, text="Démarrage (%)").grid(row=5, column=0, sticky="w", pady=3)
        ttk.Label(controls, text="Arrêt (%)").grid(row=5, column=1, sticky="w", pady=3)
        self.low_entry = ttk.Entry(controls, textvariable=self.low_var, width=10)
        self.high_entry = ttk.Entry(controls, textvariable=self.high_var, width=10)
        self.low_entry.grid(row=6, column=0, sticky="ew", padx=3)
        self.high_entry.grid(row=6, column=1, sticky="ew", padx=3)
        self.set_button = ttk.Button(controls, text="Appliquer les seuils (mode STOP)",
                                     command=self.apply_thresholds)
        self.set_button.grid(row=7, column=0, columnspan=2, sticky="ew", pady=8)
        self.reset_button = ttk.Button(controls, text="Réarmer après correction du défaut",
                                       command=lambda: self.send("RESET"))
        self.reset_button.grid(row=8, column=0, columnspan=2, sticky="ew", pady=5)
        self.alarm_label = tk.Label(controls, textvariable=self.alarm_var, anchor="w",
                                    justify="left", wraplength=350, fg="#9c2626")
        self.alarm_label.grid(row=9, column=0, columnspan=2, sticky="ew", pady=10)
        ttk.Label(controls, text="Le relais indique une commande électrique.\n"
                  "Le débit réel de la pompe n'est pas mesuré.",
                  wraplength=350).grid(row=10, column=0, columnspan=2, sticky="w")

        self.journal = scrolledtext.ScrolledText(self, height=7, state="disabled",
                                                font=("Monospace", 9))
        self.journal.grid(row=2, column=0, sticky="ew", padx=12, pady=(0, 12))
        self.update_controls()

    def log(self, text):
        self.journal.configure(state="normal")
        self.journal.insert("end", f"{time.strftime('%H:%M:%S')}  {text}\n")
        if int(self.journal.index("end-1c").split(".")[0]) > 250:
            self.journal.delete("1.0", "2.0")
        self.journal.see("end")
        self.journal.configure(state="disabled")

    def refresh_ports(self):
        ports = [item.device for item in list_ports.comports()]
        self.port_box["values"] = ports
        if not self.port_var.get() and ports:
            self.port_var.set(ports[0])

    def toggle_connection(self):
        if self.worker and self.worker.is_alive():
            self.worker.request_stop()
            self.connected = False
            self.status = None
            self.connection_var.set("Déconnexion…")
            self.connect_button.configure(state="disabled")
        else:
            port = self.port_var.get().strip()
            if not port:
                messagebox.showerror("Port manquant", "Choisir le port USB de l'Arduino.")
                return
            self.status = None
            self.connected = False
            self.last_status_time = 0.0
            self.first_status = True
            self.stale_announced = False
            self.connection_var.set("Initialisation…")
            self.connect_button.configure(text="Déconnecter")
            self.port_box.configure(state="disabled")
            self.worker = SerialWorker(port)
            self.worker.start()
            self.log(f"Ouverture de {port} ; attendre le redémarrage de la Mega.")
        self.render()

    def fresh(self):
        return (self.connected and self.status is not None
                and time.monotonic() - self.last_status_time <= TELEMETRY_TIMEOUT)

    def send(self, command):
        if not self.worker or not self.connected:
            return
        if command != "STOP" and not self.fresh():
            self.log("Commande refusée : aucune télémétrie récente.")
            return
        if self.worker.send(command):
            self.log("Commande demandée : " + command)
        else:
            self.log("File de commandes pleine : déconnexion et arrêt demandé.")
            self.worker.request_stop()

    def apply_thresholds(self):
        try:
            low, high = validate_thresholds(self.low_var.get(), self.high_var.get())
        except ValueError as exc:
            messagebox.showerror("Seuils incorrects", str(exc))
            return
        self.send(f"SET {low} {high}")

    def update_controls(self):
        fresh = self.fresh()
        data = self.status or {}
        ready = fresh and data.get("valid") == 1 and data.get("alarm") == "NONE"
        manual = ready and data.get("mode") == "MANUAL"
        states = {"AUTO": ready, "MANUAL": ready,
                  "ON": manual and not data.get("pump")
                        and data.get("level", 100) < data.get("high", 0),
                  "OFF": manual}
        for command, enabled in states.items():
            self.buttons[command].configure(state="normal" if enabled else "disabled")
        self.stop_button.configure(state="normal" if self.connected else "disabled")
        editable = fresh and data.get("mode") == "STOP"
        for widget in (self.low_entry, self.high_entry, self.set_button):
            widget.configure(state="normal" if editable else "disabled")
        resettable = fresh and data.get("valid") == 1 and data.get("alarm") != "NONE"
        self.reset_button.configure(state="normal" if resettable else "disabled")

    def draw_tank(self):
        if not hasattr(self, "canvas"):
            return
        canvas = self.canvas
        canvas.delete("all")
        width, height = max(canvas.winfo_width(), 240), max(canvas.winfo_height(), 240)
        left, top, right, bottom = 65, 25, width - 55, height - 30
        canvas.create_rectangle(left, top, right, bottom, fill="white", outline="#3c546d", width=3)
        if self.fresh() and self.status["valid"]:
            level = self.status["level"]
            water_y = bottom - (bottom - top) * level / 100
            canvas.create_rectangle(left + 2, water_y, right - 2, bottom - 2,
                                    fill="#389dde", outline="")
            for key, color in (("low", "#c37b10"), ("high", "#c93636")):
                value = self.status[key]
                y = bottom - (bottom - top) * value / 100
                canvas.create_line(left, y, right, y, fill=color, dash=(5, 3), width=2)
                canvas.create_text(left - 5, y, text=f"{value} %", anchor="e", fill=color)
        else:
            canvas.create_text((left + right) / 2, (top + bottom) / 2,
                               text="Aucune mesure\nvalide et récente", fill="#64748b", justify="center")

    def render(self):
        fresh = self.fresh()
        data = self.status
        if fresh:
            self.connection_var.set("Liaison active")
            self.level_var.set(f"{data['level']:.1f} %" if data["valid"] else "— %")
            self.distance_var.set(f"Distance : {data['distance_cm']:.1f} cm"
                                  if data["valid"] else "Distance : — cm")
            modes = {"STOP": "ARRÊT", "AUTO": "AUTOMATIQUE", "MANUAL": "MANUEL"}
            self.mode_var.set("Mode : " + modes[data["mode"]])
            self.pump_var.set("Relais pompe : " + ("MARCHE" if data["pump"] else "ARRÊT"))
            self.thresholds_var.set(f"Seuils Arduino : {data['low']} % / {data['high']} %")
            self.alarm_var.set(ALARMS[data["alarm"]])
            self.alarm_label.configure(fg="#197044" if data["alarm"] == "NONE" else "#9c2626")
        else:
            self.level_var.set("— %")
            self.distance_var.set("Distance : — cm")
            self.mode_var.set("Mode : état inconnu")
            self.pump_var.set("Relais pompe : état inconnu")
            self.thresholds_var.set("Seuils Arduino : —")
            self.alarm_var.set("Télémétrie absente : arrêt demandé" if self.connected
                                else "Connecter l'Arduino par USB")
            if self.connected:
                self.connection_var.set("Attente de télémétrie")
        self.update_controls()
        self.draw_tank()

    def tick(self):
        if self.closing:
            return
        now = time.monotonic()
        if self.worker:
            for _ in range(100):
                try:
                    kind, value = self.worker.events.get_nowait()
                except queue.Empty:
                    break
                if kind == "connected":
                    self.connected = True
                    self.connected_at = now
                    self.last_ping = now
                    self.log("Port ouvert. Démarrage du système en mode STOP.")
                elif kind == "line":
                    received_at, line = value
                    if not self.connected:
                        continue
                    if line.startswith("{"):
                        try:
                            data = parse_status(line)
                        except (ValueError, TypeError, KeyError):
                            self.log("Trame invalide ignorée.")
                            continue
                        # Utiliser l'heure de reception USB, pas celle du traitement Tk.
                        if now - received_at > TELEMETRY_TIMEOUT:
                            continue
                        previous_alarm = self.status["alarm"] if self.status else None
                        self.status = data
                        self.last_status_time = received_at
                        if self.first_status:
                            self.low_var.set(str(data["low"]))
                            self.high_var.set(str(data["high"]))
                            self.first_status = False
                        if data["alarm"] != previous_alarm:
                            self.log(ALARMS[data["alarm"]])
                    elif line.startswith(("ACK ", "ERR ")):
                        self.log(line)
                elif kind in ("error", "notice"):
                    self.log(value)
                elif kind == "disconnected":
                    self.connected = False
                    self.status = None
                    self.connection_var.set("Déconnecté")
                    self.port_box.configure(state="normal")
                    self.log("Port fermé ; commande STOP envoyée si la liaison le permet.")
            if not self.worker.is_alive():
                self.connect_button.configure(text="Connecter", state="normal")
        if self.connected:
            reference = self.last_status_time or self.connected_at
            stale = now - reference > TELEMETRY_TIMEOUT
            if stale:
                if not self.stale_announced:
                    self.worker.send("STOP")
                    self.log("Télémétrie perdue : STOP demandé ; interruption des PING.")
                    self.stale_announced = True
            elif now - self.last_ping >= HEARTBEAT_SECONDS:
                # Le heartbeat depend du traitement Tk : une IHM bloquee cesse les PING.
                if not self.worker.send("PING"):
                    self.worker.request_stop()
                self.last_ping = now
                self.stale_announced = False
        self.render()
        self.after(100, self.tick)

    def close(self):
        self.closing = True
        self.close_deadline = time.monotonic() + 2.0
        if self.worker:
            self.worker.request_stop()
        self.connection_var.set("Arrêt et fermeture…")
        self.after(50, self.finish_close)

    def finish_close(self):
        if not self.worker or not self.worker.is_alive() or time.monotonic() >= self.close_deadline:
            self.destroy()
        else:
            self.after(50, self.finish_close)


if __name__ == "__main__":
    try:
        Supervision().mainloop()
    except tk.TclError as exc:
        raise SystemExit("Tkinter ne peut pas ouvrir la fenêtre. Lancer le programme "
                         "depuis le bureau graphique du Raspberry Pi. Détail : " + str(exc)) from exc

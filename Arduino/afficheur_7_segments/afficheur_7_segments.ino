int a = 2, b = 3, c = 4, d = 5, e = 6, f = 7, g = 8;

void setup() {
  int segments[] = {a, b, c, d, e, f, g};
  for (int i = 0; i < 7; i++) {
    pinMode(segments[i], OUTPUT);
  }
}

void loop() {
  // Afficher le chiffre 2 : a, b, g, e, d
  digitalWrite(a, HIGH);
  digitalWrite(b, HIGH);
  digitalWrite(c, LOW);
  digitalWrite(d, HIGH);
  digitalWrite(e, HIGH);
  digitalWrite(f, LOW);
  digitalWrite(g, HIGH);
}

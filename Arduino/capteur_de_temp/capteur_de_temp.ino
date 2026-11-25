#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <dht11.h>  // Bibliothèque que tu as mentionnée

#define DHT11_PIN 2  // Broche DATA du capteur connectée à D2

dht11 DHT11;
LiquidCrystal_I2C lcd(0x27, 16, 2); // Vérifie si ton adresse I2C est 0x27 ou 0x3F

void setup() {
  lcd.begin();
  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print("Demarrage...");
  delay(2000);
  lcd.clear();
}

void loop() {
  int chk = DHT11.read(DHT11_PIN);

  lcd.setCursor(0, 0);
  if (chk == DHTLIB_OK) {
    lcd.print("Temp: ");
    lcd.print((float)DHT11.temperature);
    lcd.print(" C");

    lcd.setCursor(0, 1);
    lcd.print("Hum:  ");
    lcd.print((float)DHT11.humidity);
    lcd.print(" %");
  } else {
    lcd.print("Erreur lecture !");
  }

  delay(2000);
}

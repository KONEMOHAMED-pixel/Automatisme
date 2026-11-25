#include <Wire.h>
#include <LiquidCrystal_I2C.h>
// Include the DHT11 library for interfacing with the sensor.
#include <DHT11.h>

// Create an instance of the DHT11 class.
// - For Arduino: Connect the sensor to Digital I/O Pin 2.
// - For ESP32: Connect the sensor to pin GPIO2 or P2.
// - For ESP8266: Connect the sensor to GPIO2 or D4.
DHT11 dht11(7); 

LiquidCrystal_I2C lcd(0x27, 16, 2); // Adresse I2C 0x27, LCD 16x2

void setup() {
  lcd.init();         // Initialisation
  lcd.backlight();    // Activer rétroéclairage
}

void loop() {
    int temperature = 0;
    int humidity = 0;

    // Attempt to read the temperature and humidity values from the DHT11 sensor.
    int result = dht11.readTemperatureHumidity(temperature, humidity);

    // Check the results of the readings.
    // If the reading is successful, print the temperature and humidity values.
    // If there are errors, print the appropriate error messages.
    if (result == 0) {
        lcd.setCursor (0,0) ;  //on place le curseur de l’écran LCD au début de la 1er ligne
        lcd.print("Temp : ") ;   //on écrit le mot “Temp : ’’ à l’emplacement du curseur
        lcd.print(temperature) ; //on écrit la température lue par le capteur, avec 1 chiffre derrière la virgule
        lcd.print((char)223) ;   //on ajoute le symbole après la valeur de la température
        lcd.print("C") ; // on ajoute la lettre C pour degré Celsius
        lcd.setCursor(0,1) ;  //on déplace le curseur de l’écran LCD au début de la 2e ligne
        lcd.print("Humidity : ") ;  //on écrit l’humidité relative lue par le capteur, avec 1 chiffre derrière la virgule
        lcd.print(humidity);
        lcd.print("%") ; //on ajoute le symbole “%’’ après la valeur de l’humidité
        delay (1000) ;  // on attend une seconde avant de procéder à la lecture suivante
    } else {
        // Print error message based on the error code.
        Serial.println(DHT11::getErrorString(result));
    }

}
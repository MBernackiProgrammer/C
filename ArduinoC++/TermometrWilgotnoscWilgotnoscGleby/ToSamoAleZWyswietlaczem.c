#define AcceptButton 4
#define X_pin A0
#define Y_pin A1

#define GrDry A5

#define TempPin 2
#define DHTTYPE DHT11

#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
#include "DHT.h"

LiquidCrystal_I2C lcd(0x27,20,4);
DHT dht(TempPin, DHTTYPE);

bool CanMenu = true;
bool WasDown = true;
int MenuOptionSelected = 0;
bool CanDo = true;

void ShowTemp()
{
  float t = dht.readTemperature();

  if (isnan(t)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Temperatura = ");
  lcd.setCursor(0,1);
  lcd.print(t);
  lcd.print(" ");
  lcd.print(char(223));
  lcd.print("C");
  
}

void ShowGround()
{
  float h = dht.readHumidity();

  // Check if any reads failed and exit early (to try again).
  if (isnan(h)){
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Wilggotnosc = ");
  lcd.setCursor(0,1);
  lcd.print(h);
  lcd.print(" %");
}

void Loading(int ToLoad)
{
  lcd.clear();
  CanMenu = false;
  lcd.setCursor(0,0);
  lcd.print("Przeprowadzanie");
  lcd.setCursor(0,1);
  lcd.print("badania.");

  delay(500);

  lcd.setCursor(0,0);
  lcd.print("Przeprowadzanie");
  lcd.setCursor(0,1);
  lcd.print("badania..");

  delay(500);

  lcd.setCursor(0,0);
  lcd.print("Przeprowadzanie");
  lcd.setCursor(0,1);
  lcd.print("badania...");

  delay(500);

  
  switch(ToLoad)
  {
    case 0:
      ShowTemp();
    break;

    case 1:
      ShowGround();
    break;
  }
}

void PrintMenu(int selectedInput)
{
  switch(selectedInput)
  {
    case 0:
      lcd.setCursor(0,0);
      lcd.print("> Temperatura");
      lcd.setCursor(0,1);
      lcd.print("  Wilgotnosc");
    break;

    case 1:
      lcd.setCursor(0,0);
      lcd.print("  Temperatura");
      lcd.setCursor(0,1);
      lcd.print("> Wilgotnosc");
    break;
  }
}

void setup()
{
  dht.begin();
  pinMode(AcceptButton, INPUT);
 // digitalWrite(AcceptButton, HIGH);
  Serial.begin(9600);
  lcd.init();
  lcd.backlight();
  pinMode(AcceptButton, INPUT_PULLUP);
  PrintMenu(MenuOptionSelected);
}

void loop() 
{
  if(digitalRead(AcceptButton) == LOW && CanMenu == true && CanDo == true)
  {
    Loading(MenuOptionSelected);
  }
  
  if(CanMenu == true)
 {
   if(analogRead(X_pin) < 100 || analogRead(X_pin) > 900)
   {
      if(WasDown)
        {
          WasDown = false;
          if(analogRead(X_pin) < 100)
          {
            MenuOptionSelected = MenuOptionSelected + 1;
          }
          if(analogRead(X_pin) > 900)
          {
            MenuOptionSelected = MenuOptionSelected - 1;
            
          }
          if(MenuOptionSelected > 1)
          {
            MenuOptionSelected = 0;
          }

          if(MenuOptionSelected < 0)
          {
            MenuOptionSelected = 1;
          }
          PrintMenu(MenuOptionSelected);
        }
   }
   else
   {
     WasDown = true;
   }


 }
  else
 {
    if(analogRead(X_pin) < 100 || analogRead(X_pin) > 900)
    {
      CanMenu = true;
     lcd.clear();
     PrintMenu(MenuOptionSelected);
    }
 }
}
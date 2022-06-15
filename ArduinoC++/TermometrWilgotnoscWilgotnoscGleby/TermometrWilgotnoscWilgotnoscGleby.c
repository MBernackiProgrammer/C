#include "DHT.h"

/*
Diody led 
RedD = Dioda czerwona = port 11
YellowD = Dioda zółta = port 12
GreenD = Dioda zielona = port 13
*/

#define RedD 11
#define YellowD 12
#define GreenD 13 

/*
Czujniki 
Temp = Termometr = port 2
GrDry = Miernik wilgotności gleby = port A5
*/

#define Temp 2
#define GrDry A5

/*
Przyciski 
Bt1 = przycisk 1, do wilgotności gleby = port 6
Bt2 = przycisk 2, do mierzenia temperatury = port 7 
*/

#define Bt1 6
#define Bt2 7

#define DHTTYPE DHT11
DHT dht(Temp, DHTTYPE);

void Termometr()
{
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t)) {
    Serial.println((""));
    Serial.print(("Nie udalo sie wczytac temperatury i wilgotnosci"));
    return;
  }
  Serial.println();
  Serial.print(F("Wilgotnosc powietrza : "));
  Serial.print(h);
  Serial.println(F(" %"));
  Serial.print(F("Temperatura powietrza : "));
  Serial.print(t);
  Serial.println(F("°C "));
}

void WilgotnoscGleby(){
  float val;
  val = analogRead(GrDry);
  val = val -35;
  val = val / 270;
  val = val * 100;
  val = 100 - val;

  if(val < 5.f)
  {
    Serial.println();
    Serial.print("Sprawdz czy czujnik jest odpowiednio wsadzony do gleby");
  }
  else
  {
    Serial.println();
    Serial.print("Wilgotnosc gleby wynosi : ");
    Serial.print(val);
    Serial.println(F(" %"));
  }
  
}

void Ladowanie(int out)
{
  digitalWrite(RedD, HIGH);

  delay(500);

  digitalWrite(RedD, LOW);
  digitalWrite(YellowD, HIGH);

  delay(500);
  
  digitalWrite(YellowD, LOW);
  digitalWrite(GreenD, HIGH);

  delay(500);
  digitalWrite(GreenD, LOW);

  if(out == 1)
  {
    Termometr();
  }
  else
  {
    WilgotnoscGleby();
  }
}
void setup() 
{
  Serial.begin(9600);
  pinMode(Bt1, INPUT);
  pinMode(Bt2, INPUT);
  dht.begin();
}

void loop() 
{
  int buttonState = 0;  
   int buttonState2 = 0;  
  buttonState = !digitalRead(Bt2);
  buttonState2 = !digitalRead(Bt1);
  // check if the pushbutton is pressed. If it is, the buttonState is HIGH:
  if (buttonState == HIGH) {
    Ladowanie(1);
  } 

  if (buttonState2 == HIGH) {
    Ladowanie(2);
  }
}
#include <LiquidCrystal.h>

const int button1 = 2, button2 = 3;
const int pot1 = A1;
const int potTreshold = 4;

const int rs = 12, en = 13, d4 = 8, d5 = 9, d6 = 10, d7 = 11;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);

int value = 0; //temp value for anything
int buttonState1 = 0;
int buttonState2 = 0;
int potValue = 0;

void setup() {
  pinMode(button1, INPUT_PULLUP);
  pinMode(button2, INPUT_PULLUP);
  
  lcd.begin(16, 2);

  refreshDisplay();
}

void loop() {
  if (readInputs()) refreshDisplay();
}

//reads inputs into global variables and returns true if something was changed
bool readInputs()
{
  bool ret = false;
  
  value = getButtonState(button1);
  if (buttonState1 != value)
  {
    buttonState1 = value;
    ret = true;
  }

  value = getButtonState(button2);
  if (buttonState2 != value)
  {
    buttonState2 = value;
    ret = true;
  }

  value = getPotValue(pot1, potValue);
  if (potValue != value)
  {
    potValue = value;
    ret = true;
  }
  
  return ret;
}

void refreshDisplay()
{
  lcd.setCursor(0,0);
  lcd.print("B1:");
  lcd.setCursor(4,0);
  lcd.print(buttonState1);

  lcd.setCursor(0,1);
  lcd.print("B2:");
  lcd.setCursor(4,1);
  lcd.print(buttonState2);

  lcd.setCursor(8,1);
  lcd.print("    ");
  lcd.setCursor(8,1);
  lcd.print(potValue);
}

int getButtonState(int button)
{
  int value = digitalRead(button);
  if (value == 0) return 1;
  else return 0;
}

//gets new analog value and saves it to variable if new value changed enough
int getPotValue(int pin, int oldValue)
{
  value = analogRead(pin);
  if (abs(value - oldValue) <= potTreshold) value = oldValue;

  if (value <= potTreshold) value = 0;
  if (value >= 1023 - potTreshold) value = 1023;
  
  return value;
}

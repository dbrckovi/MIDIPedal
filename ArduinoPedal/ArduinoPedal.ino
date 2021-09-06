#include <SoftwareSerial.h>

const int led[] = {4, 3, 2};
const int button[] = {5, 6, 7};
const int pot1 = A2;
const int rx = 0, tx = 1;

SoftwareSerial serial(rx, tx);

unsigned long buttonChangedTime[3];
unsigned long potChangeTime = 0;
int buttonState[3];
int buttonTogglable[3];
int buttonValue[3];
int potValue = 0;
char readBuffer[16];

void setup() 
{
  pinMode(led[0], OUTPUT);
  pinMode(led[1], OUTPUT);
  pinMode(led[2], OUTPUT);
  pinMode(button[0], INPUT_PULLUP);
  pinMode(button[1], INPUT_PULLUP);
  pinMode(button[2], INPUT_PULLUP);
  
  serial.begin(38400);
  serial.setTimeout(1);
  while (!serial) { ; }

  buttonTogglable[0] = 1;
}

void loop() 
{
  handleSerialInput();
  handleButton(0);
  handleButton(1);
  handleButton(2);
  handlePot();
}

//reads command from a serial port (if available) and handles it
void handleSerialInput()
{
  int bytesToRead = serial.available();
  if (bytesToRead > 0)
  {
    serial.readBytes(readBuffer, 1);

    if ((readBuffer[0] & 128) == 128)
    {
      buttonTogglable[0] = (readBuffer[0] & 1) == 1;
      buttonTogglable[1] = (readBuffer[0] & 2) == 2;
      buttonTogglable[2] = (readBuffer[0] & 4) == 4;
    }

    sendButtonValues();
    sendPotValue();
  }
}

//reads input of specified button, if button value was changed, toggles led and sends new button state to serial
void handleButton(int index)
{
  unsigned long elapsed = millis() - buttonChangedTime[index];
  
  if (elapsed > 10)
  {
    int x = isButtonPressed(index);
    if (x != buttonState[index])
    {
      buttonState[index] = x;
      
      if (buttonTogglable[index])
      {
        if (x == 1)
        {
          if (buttonValue[index] == 1) buttonValue[index] = 0;
          else buttonValue[index] = 1;
          setLeds();
          sendButtonValues();
        }
      }
      else
      {
        buttonValue[index] = x;
        setLeds();
        sendButtonValues();
      }

      buttonChangedTime[index] = millis();
    }
  }
}

//reads pot value and if changed, sends the value to serial
void handlePot()
{
  unsigned long elapsed = millis() - potChangeTime;

  if (elapsed > 1)
  {
    int x = getPotValue();
    if (x != potValue)
    {
      potValue = x;
      sendPotValue();
      potChangeTime = elapsed;
    }
  }
}

//checks whether a hardware button is currently pressed (1) or depressed (0)
int isButtonPressed(int index)
{
  int value = digitalRead(button[index]);
  if (value == 0) return 1;
  else return 0;
}

int getPotValue()
{
  int value = analogRead(pot1);
  return map(value, 0, 1023, 0, 127);
}

void setLeds()
{
  digitalWrite(led[0], buttonValue[0]);
  digitalWrite(led[1], buttonValue[1]);
  digitalWrite(led[2], buttonValue[2]);
}

void sendButtonValues()
{
  //Bit breakdown: 0VVVVVVV
  //Most significant bit: 0 - denotes that this is a button state message
  //Other bits (V): 1 - button is on, 0 - button is off. Bit significance denotes a button index (LSB is first button)
  //Obviously, only last 3 bits are used since there are only 3 buttons

  byte data = 0;

  if (buttonValue[0] == 1) data = data | 1;
  if (buttonValue[1] == 1) data = data | 2;
  if (buttonValue[2] == 1) data = data | 4;

  if (serial) serial.write(data);
}

void sendPotValue()
{
  //Bit breakdown: 1VVVVVVV
  //Most significant bit: 1 - denotes that this is a pot value message
  //Other bits (V): is a 127 bit value of the pot
  byte data = 128;
  data = data | potValue;
  if (serial) serial.write(data);
}

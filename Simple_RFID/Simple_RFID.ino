#include <SPI.h>
#include <RFID.h>

#define SS_PIN 10
#define RST_PIN 9

int led1 = 3;
int led2 = 2;

RFID rfid(SS_PIN, RST_PIN); 
int serNum0;
int serNum1;
int serNum2;
int serNum3;
int serNum4;
String TagCard;

void setup()
{ 
  Serial.begin(9600);
  SPI.begin(); 
  rfid.init();
  pinMode(led1, OUTPUT);
  digitalWrite(led1,LOW);
  pinMode(led2, OUTPUT);
  digitalWrite(led2,LOW);
}

void loop()
{
    
    if (rfid.isCard()) {
      if (rfid.readCardSerial()) {
        serNum0 = rfid.serNum[0];
        serNum1 = rfid.serNum[1];
        serNum2 = rfid.serNum[2];
        serNum3 = rfid.serNum[3];
        serNum4 = rfid.serNum[4];
                  
        TagCard =  String(serNum0, HEX);
        TagCard +=  String(serNum1, HEX);
        TagCard +=  String(serNum2, HEX);
        TagCard +=  String(serNum3, HEX);
        TagCard +=  String(serNum4, HEX);
        Serial.println(TagCard);
        delay(1000);
        TagCard = "";
      }
    }
    rfid.halt();
}

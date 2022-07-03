#include <SPI.h>
#include <RFID.h>

#define SS_PIN 10
#define RST_PIN 9

RFID rfid(SS_PIN, RST_PIN); 

// Setup variables:
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
  
}

void loop()
{
    
    if (rfid.isCard()) {
        if (rfid.readCardSerial()) {
            if (rfid.serNum[0] != serNum0 && rfid.serNum[1] != serNum1 && rfid.serNum[2] != serNum2 && rfid.serNum[3] != serNum3 && rfid.serNum[4] != serNum4) {
                /* With a new cardnumber, show it. */
                Serial.println(" ");
                Serial.println("Card found");
                TagCard = serNum0 = rfid.serNum[0];
                TagCard += serNum1 = rfid.serNum[1];
                TagCard += serNum2 = rfid.serNum[2];
                TagCard += serNum3 = rfid.serNum[3];
                TagCard += serNum4 = rfid.serNum[4];
               
                //Serial.println(" ");
                Serial.println(TagCard);
                Serial.print("HEX: ");
    Serial.print(rfid.serNum[0],HEX);
                Serial.print(", ");
    Serial.print(rfid.serNum[1],HEX);
                Serial.print(", ");
    Serial.print(rfid.serNum[2],HEX);
                Serial.print(", ");
    Serial.print(rfid.serNum[3],HEX);
                Serial.print(", ");
    Serial.print(rfid.serNum[4],HEX);
                Serial.println(" ");
             } else {
               /* If we have the same ID, just write a dot. */
               Serial.print(".");
             }
          }
    }
    
    rfid.halt();
}

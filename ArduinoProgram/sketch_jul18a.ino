#include <SoftwareSerial.h>
SoftwareSerial seriport(10, 11);
int kirmizi=9,mavi=5,yesil=6;
String y;
char x;
void setup() {
  // put your setup code here, to run once:
pinMode(kirmizi, OUTPUT);
pinMode(mavi, OUTPUT);
pinMode(yesil, OUTPUT);
Serial.begin(9600);
seriport.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
if(seriport.available()>0){
  x=seriport.read();
  y+=x;
  String part01 = getValue(y,',',0);
  String part02 = getValue(y,',',1);
  String part03 = getValue(y,',',2);
  changeColour(part01.toInt(),part02.toInt(),part03.toInt());
 }
else{y="";}
  
}
void changeColour(int kir, int mav, int yes)
{
 kir = 255 - kir;
 yes = 255 - yes;
 mav = 255 - mav;
 analogWrite(kirmizi, kir);
 analogWrite(yesil, yes);
 analogWrite(mavi, mav);
}
String getValue(String data, char separator, int index)
{
  int found = 0;
  int strIndex[] = {0, -1};
  int maxIndex = data.length()-1;

  for(int i=0; i<=maxIndex && found<=index; i++){
    if(data.charAt(i)==separator || i==maxIndex){
        found++;
        strIndex[0] = strIndex[1]+1;
        strIndex[1] = (i == maxIndex) ? i+1 : i;
    }
  }

  return found>index ? data.substring(strIndex[0], strIndex[1]) : "";
}

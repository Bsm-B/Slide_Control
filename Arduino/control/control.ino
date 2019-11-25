
int etat,etat2;
int memoire,memoire2 = LOW; 

void setup()
{
  Serial.begin(9600);
  pinMode(2,INPUT_PULLUP);
  pinMode(3,INPUT_PULLUP);

}

void loop()
{

 etat =digitalRead(2) ;
 if((etat != memoire) && (etat == HIGH))Serial.println("a");
 memoire = etat;

 etat2 =digitalRead(3) ;
 if((etat2 != memoire2) && (etat2 == HIGH))Serial.println("b");
 memoire2 = etat2;

}

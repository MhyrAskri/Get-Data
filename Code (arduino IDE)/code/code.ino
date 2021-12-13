int led = 3;
char data;
int pot = A0;
int reading;

void setup() {

  pinMode(led , OUTPUT);
  Serial.begin(9600);

}

void loop() {

  while(Serial.available()) {

    data = Serial.read();

    if(data == '1') {

      digitalWrite(led , 1);
      
    } else if(data == '2') {

      digitalWrite(led , 0);
      
    } else if(data == '3') {

      reading = analogRead(pot);  // Domain: 0 - 1023
      Serial.println(reading);
      
    }
    
  }

}

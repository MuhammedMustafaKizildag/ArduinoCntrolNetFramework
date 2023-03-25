int ledPin1 = 7;
int ledPin2 = 8;// LED'in bağlı olduğu pin numarası

void setup() {
  pinMode(ledPin1, OUTPUT);
  pinMode(ledPin2, OUTPUT);// LED'i çıkış olarak ayarla
  Serial.begin(9600); // Seri haberleşmeyi başlat
}

void loop() {
  if (Serial.available()) { 
    char receivedChar = Serial.read();
    if (receivedChar == '1') { 
      digitalWrite(ledPin1, HIGH); 
      }else if(receivedChar == '0') {
      digitalWrite(ledPin1, LOW); 
    }
    if (receivedChar == '2'){
      digitalWrite(ledPin2, HIGH);
      }else if (receivedChar == '3'){
        digitalWrite(ledPin2, LOW);
        }
  }
}

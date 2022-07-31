#include <LiquidCrystal.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

LiquidCrystal lcd(35, 39, 27, 29, 31, 33);

#define max_count_ReceiveData 4
char ReceiveData;
char start_sign = '@';
char end_sign = '&';
char start_Data, end_Data;

int receive_complete = 0;
int count_ReceiveData = 0;
char buf_string_receive[max_count_ReceiveData];

int datachar1;
int dataint1;

int datachar2;
int dataint2;
int n = 0;
int A = 7;
int B = 6;
int C = 4;
int D = 3;
int E = 2;
int F = 8;
int G = 9;

int Aa = 23;
int Ba = 25;
int Ca = 16;
int Da = 17;
int Ea = 18;
int Fa = 19;
int Ga = 20;

byte num0 = 0xC0;
byte num1 = 0xF9;
byte num2 = 0xA4;
byte num3 = 0xB0;
byte num4 = 0x99;
byte num5 = 0x92;
byte num6 = 0x82;
byte num7 = 0xF8;
byte num8 = 0x80;
byte num9 = 0x90;
int num[] = {num0, num1, num2, num3, num4, num5, num6, num7, num8, num9};

void on(byte num)
{
  int result = bitRead(num, 0);
  if (result == 1)
  {
    digitalWrite(A, HIGH);
  }
  else
  {
    digitalWrite(A, LOW);
  }
  result = bitRead(num, 1);
  if (result == 1)
  {
    digitalWrite(B, HIGH);
  }
  else
  {
    digitalWrite(B, LOW);
  }
  result = bitRead(num, 2);
  if (result == 1)
  {
    digitalWrite(C, HIGH);
  }
  else
  {
    digitalWrite(C, LOW);
  }
  result = bitRead(num, 3);
  if (result == 1)
  {
    digitalWrite(D, HIGH);
  }
  else
  {
    digitalWrite(D, LOW);
  }
  result = bitRead(num, 4);
  if (result == 1)
  {
    digitalWrite(E, HIGH);
  }
  else
  {
    digitalWrite(E, LOW);
  }

  result = bitRead(num, 5);
  if (result == 1)
  {
    digitalWrite(F, HIGH);
  }
  else
  {
    digitalWrite(F, LOW);
  }

  result = bitRead(num, 6);
  if (result == 1)
  {
    digitalWrite(G, HIGH);
  }
  else
  {
    digitalWrite(G, LOW);
  }
}

void on2(byte num)
{
  int result = bitRead(num, 0);
  if (result == 1)
  {
    digitalWrite(Aa, HIGH);
  }
  else
  {
    digitalWrite(Aa, LOW);
  }
  result = bitRead(num, 1);
  if (result == 1)
  {
    digitalWrite(Ba, HIGH);
  }
  else
  {
    digitalWrite(Ba, LOW);
  }
  result = bitRead(num, 2);
  if (result == 1)
  {
    digitalWrite(Ca, HIGH);
  }
  else
  {
    digitalWrite(Ca, LOW);
  }
  result = bitRead(num, 3);
  if (result == 1)
  {
    digitalWrite(Da, HIGH);
  }
  else
  {
    digitalWrite(Da, LOW);
  }
  result = bitRead(num, 4);
  if (result == 1)
  {
    digitalWrite(Ea, HIGH);
  }
  else
  {
    digitalWrite(Ea, LOW);
  }

  result = bitRead(num, 5);
  if (result == 1)
  {
    digitalWrite(Fa, HIGH);
  }
  else
  {
    digitalWrite(Fa, LOW);
  }

  result = bitRead(num, 6);
  if (result == 1)
  {
    digitalWrite(Ga, HIGH);
  }
  else
  {
    digitalWrite(Ga, LOW);
  }
}

void setup()
{
  pinMode(A, OUTPUT);
  pinMode(B, OUTPUT);
  pinMode(C, OUTPUT);
  pinMode(D, OUTPUT);
  pinMode(E, OUTPUT);
  pinMode(F, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(Aa, OUTPUT);
  pinMode(Ba, OUTPUT);
  pinMode(Ca, OUTPUT);
  pinMode(Da, OUTPUT);
  pinMode(Ea, OUTPUT);
  pinMode(Fa, OUTPUT);
  pinMode(Ga, OUTPUT);
  Serial3.begin(9600, SERIAL_8N1);
  Serial.begin(9600);
  lcd.begin(16, 2);
  lcd.setCursor(1, 0);
  lcd.print("Count: ");
}
void displays(int n, int x)
{
  int countfrom = n * 10 + x;
  for (int i = countfrom; i >= 0; i--)
  {
    Serial3.println(i);
    lcd.setCursor(7, 0);
    lcd.print(i);
    lcd.print(" ");
    int hc = i / 10;
    int dv = i % 10;
    on(num[hc]);
    on2(num[dv]);
    if (i == 0)
    {
      digitalWrite(11, HIGH);
      delay(2000);
    }
    delay(1000);
    digitalWrite(11, LOW);
  }
  n = 0;
}
void _send()
{
  if (digitalRead(11) == 0)
  {
    n = Serial3.read();
    Serial3.print("n = ");
    Serial3.println(int(n));
  }
}

void serialEvent3()
{
  // Doc du lieu moi lan nhan
  ReceiveData = Serial3.read(); // Du kieu duoc truyen vao theo tung byte moi lan uart_interrupt xay ra
                                // Kiem tra ki tu bat dau
  if (ReceiveData == start_sign)
  {
    count_ReceiveData = 0;
    start_Data = ReceiveData;
    buf_string_receive[count_ReceiveData] = ReceiveData;
  }
  // Kiem tra ki tu ket thuc
  if (ReceiveData == end_sign)
  {
    end_Data = ReceiveData;
    buf_string_receive[count_ReceiveData] = ReceiveData;
  }
  // Kiem tra done giu lieu da day du dinh dang ket thuc va bat dau
  if ((start_Data == start_sign) && (end_Data == end_sign))
  {
    receive_complete = 1;
    count_ReceiveData = 0;
    start_Data = NULL;
    end_Data = NULL;
  }
  else
  {
    // Neu du lieu khong dung ki tu bat dau
    if (buf_string_receive[0] != start_sign)
    {
      Clear_buf_string_receive();
      count_ReceiveData = 0;
    }
    buf_string_receive[count_ReceiveData] = ReceiveData;
    count_ReceiveData++;
    if (count_ReceiveData == max_count_ReceiveData)
    {
      count_ReceiveData = 0;
      receive_complete = 0;
      Clear_buf_string_receive();
    }
  }

  if (receive_complete == 1)
  {
    // chuyen doi kieu char thanh int
    datachar1 = buf_string_receive[1];
    dataint1 = datachar1 - 48;
    datachar2 = buf_string_receive[2];
    dataint2 = datachar2 - 48;

    if (dataint1 >= 9)
    {
      if (dataint2 > 9 || dataint2 < 0)
      {
        displays(0, dataint1);
      }
    }
    if (dataint1 >= 0 && dataint1 <= 9 && dataint2 >= 0 && dataint2 <= 9)
    {

      displays(dataint1, dataint2);
    }
    receive_complete = 0;
    count_ReceiveData = 0;
    Clear_buf_string_receive();
  }
}
void Clear_buf_string_receive()
{
  for (int i = 0; i <= max_count_ReceiveData; i++)
  {
    buf_string_receive[i] = NULL;
  }
}

void loop()
{
}

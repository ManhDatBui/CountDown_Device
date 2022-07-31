# 1 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino"
# 2 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino" 2
# 3 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino" 2
# 4 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino" 2
# 5 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino" 2


# 6 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino"
LiquidCrystal lcd(35, 39, 27, 29, 31, 33);


char ReceiveData;
char start_sign='@';
char end_sign ='&';
char start_Data, end_Data;

int receive_complete=0;
int count_ReceiveData = 0;
char buf_string_receive[4];

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
int num[] = {num0 ,num1, num2, num3, num4, num5, num6, num7, num8, num9};

void on(byte num)
{
int result = (((num) >> (0)) & 0x01);
  if (result == 1)
  {
    digitalWrite(A, 0x1);}
  else
  {
    digitalWrite(A, 0x0);}
  result = (((num) >> (1)) & 0x01);
  if (result == 1)
  {
    digitalWrite(B, 0x1);}
  else
  {
    digitalWrite(B, 0x0);}
    result = (((num) >> (2)) & 0x01);
  if (result == 1)
  {
    digitalWrite(C, 0x1);}
  else
{
  digitalWrite(C, 0x0);}
  result = (((num) >> (3)) & 0x01);
  if (result == 1)
 {
  digitalWrite(D, 0x1);}
  else
  {
    digitalWrite(D, 0x0);}
  result = (((num) >> (4)) & 0x01);
  if (result == 1)
  {
    digitalWrite(E, 0x1);}
  else
  {
    digitalWrite(E, 0x0);}

  result = (((num) >> (5)) & 0x01);
  if (result == 1)
  {
    digitalWrite(F, 0x1);}
  else
  {
    digitalWrite(F, 0x0);}

  result = (((num) >> (6)) & 0x01);
  if (result == 1)
  {
    digitalWrite(G, 0x1);}
  else
  {
    digitalWrite(G, 0x0);}
  }


void on2(byte num)
{
int result = (((num) >> (0)) & 0x01);
if (result == 1)
{digitalWrite(Aa, 0x1);}
else
{digitalWrite(Aa, 0x0);}
result = (((num) >> (1)) & 0x01);
if (result == 1)
{digitalWrite(Ba, 0x1);}
else
{digitalWrite(Ba, 0x0);}
result = (((num) >> (2)) & 0x01);
if (result == 1)
{digitalWrite(Ca, 0x1);}
else
{digitalWrite(Ca, 0x0);}
result = (((num) >> (3)) & 0x01);
if (result == 1)
{digitalWrite(Da, 0x1);}
else
{digitalWrite(Da, 0x0);}
result = (((num) >> (4)) & 0x01);
if (result == 1)
{digitalWrite(Ea, 0x1);}
else
{digitalWrite(Ea, 0x0);}

result = (((num) >> (5)) & 0x01);
if (result == 1)
{digitalWrite(Fa, 0x1);}
else
{digitalWrite(Fa, 0x0);}

result = (((num) >> (6)) & 0x01);
if (result == 1)
{digitalWrite(Ga, 0x1);}
else
{digitalWrite(Ga, 0x0);}
}

void setup() {
pinMode(A, 0x1);
pinMode(B, 0x1);
pinMode(C, 0x1);
pinMode(D, 0x1);
pinMode(E, 0x1);
pinMode(F, 0x1);
pinMode(G, 0x1);
pinMode(10,0x1);
pinMode(11,0x1);
pinMode(Aa, 0x1);
pinMode(Ba, 0x1);
pinMode(Ca, 0x1);
pinMode(Da, 0x1);
pinMode(Ea, 0x1);
pinMode(Fa, 0x1);
pinMode(Ga, 0x1);
Serial3.begin(9600,0x06);
Serial.begin(9600);
lcd.begin(16,2);
lcd.setCursor(1,0);
lcd.print("Count: ");
}
void displays(int n,int x)
{
  int countfrom = n * 10 + x;
for(int i = countfrom; i>=0; i--)
{
  Serial3.println(i);
  lcd.setCursor(7,0);
  lcd.print(i);
  lcd.print(" ");
  int hc = i/10;
  int dv = i%10;
  on(num[hc]);
  on2(num[dv]);
  if( i == 0)
  {
    digitalWrite(11,0x1);
    delay(2000);
  }
  delay(1000);
  digitalWrite(11,0x0);
}
n = 0;
}
void _send()
{
 if( digitalRead(11) == 0)
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
    if(ReceiveData == start_sign)
    {
      count_ReceiveData = 0;
      start_Data = ReceiveData;
      buf_string_receive[count_ReceiveData]= ReceiveData;
    }
    // Kiem tra ki tu ket thuc
    if(ReceiveData == end_sign)
    {
      end_Data = ReceiveData;
      buf_string_receive[count_ReceiveData]= ReceiveData;
    }
    // Kiem tra done giu lieu da day du dinh dang ket thuc va bat dau 
    if((start_Data == start_sign)&&( end_Data == end_sign))
    {
      receive_complete=1;
      count_ReceiveData=0;
      start_Data=
# 228 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino" 3 4
                __null
# 228 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino"
                    ;
      end_Data=
# 229 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino" 3 4
              __null
# 229 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino"
                  ;
    }
    else
    {
      // Neu du lieu khong dung ki tu bat dau
      if(buf_string_receive[0] != start_sign)
      {
         Clear_buf_string_receive();
         count_ReceiveData = 0;
      }
      buf_string_receive[count_ReceiveData] = ReceiveData;
      count_ReceiveData++;
      if(count_ReceiveData == 4)
      {
        count_ReceiveData = 0;
        receive_complete = 0;
        Clear_buf_string_receive();
      }
    }

    if(receive_complete == 1)
     {
       // chuyen doi kieu char thanh int
       datachar1 = buf_string_receive[1];
       dataint1 = datachar1 - 48;
       datachar2 = buf_string_receive[2];
       dataint2 = datachar2 - 48;

      if(dataint1 >= 9)
      {
        if(dataint2 > 9 || dataint2 < 0)
        {
       displays(0,dataint1);
        }
      }
       if(dataint1 >= 0 && dataint1 <= 9 && dataint2 >=0 && dataint2 <=9)
      {

       displays(dataint1,dataint2);
      }
      receive_complete = 0;
      count_ReceiveData = 0;
      Clear_buf_string_receive();
     }
}
void Clear_buf_string_receive()
{
  for(int i=0; i<=4; i++)
  {
   buf_string_receive[i]=
# 278 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino" 3 4
                        __null
# 278 "E:\\UNIVERSITY\\SUBJECT\\GTDK-TBNV\\CK\\PROJECT_CK\\CHUONGTRINH\\Arduino\\countdown_arduino_ck\\countdown_arduino_ck.ino"
                            ;
  }
}

void loop() {

}

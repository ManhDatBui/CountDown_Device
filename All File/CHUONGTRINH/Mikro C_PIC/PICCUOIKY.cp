#line 1 "E:/UNIVERSITY/SUBJECT/GTDK-TBNV/CK/PROJECT_CK/CHUONGTRINH/Mikro C_PIC/PICCUOIKY.c"





sbit LCD_RS at RA0_bit;
sbit LCD_EN at RA1_bit;
sbit LCD_D4 at RC0_bit;
sbit LCD_D5 at RC1_bit;
sbit LCD_D6 at RC2_bit;
sbit LCD_D7 at RD7_bit;

sbit LCD_RS_Direction at TRISA0_bit;
sbit LCD_EN_Direction at TRISA1_bit;
sbit LCD_D4_Direction at TRISC0_bit;
sbit LCD_D5_Direction at TRISC1_bit;
sbit LCD_D6_Direction at TRISC2_bit;
sbit LCD_D7_Direction at TRISD7_bit;

char txt1[] = "count: ";
char ReceiveData;
char buffer[5];
char buffer1[2];
int count = 0;
char led_on_code[] = "le_on";
char led_off_code[] = "le_off";
char start_sign = '@';
char end_sign = '&';
char count_ReceiveData = 0;
char buf_string_receive[ 10 ];
char start_Data, end_Data;
char receive_complete = 0;


const unsigned char led7segg[] = {0xC0, 0xF9, 0xA4, 0xB0, 0x99, 0x92, 0x82, 0xF8, 0x80, 0x90};
int datachar1;
int dataint1;
int datachar2;
int dataint2;

void displays(int n,int x)
{
 int countfrom = (n * 10 + x);
 int i;
 for( i = countfrom; i>=0; i--)
 {
 int hc = i/10;
 int dv = i%10;
 sprintf(buffer,"%d&",i);
 UART_Write_Text(buffer);
 sprintf(buffer1,"%d ",i);
 Lcd_Out(1,1,txt1);
 Lcd_Out(1,8,buffer1);

 PORTD = led7segg[i/10];
 PORTB = led7segg[i%10];
 if (i == 0)
 {
 PORTB.RB7 = 0;
 delay_ms(2000);
 }
 delay_ms(1000);
 PORTB.RB7 = 1;
 }

}


void Clear_buf_string_receive(void)
{
unsigned char i;

for(i=0;i< 10 ;i++)
{
buf_string_receive[i] = '\0';
}
}

void interrupt(void)
{
 if(PIR1.RCIF == 1)
 {
 PIR1.RCIF = 0;
 ReceiveData = UART_Read();
 if(ReceiveData == start_sign)
 {
 count_ReceiveData = 0;
 start_Data = ReceiveData;
 buf_string_receive[count_ReceiveData]= ReceiveData;
 }

 if(ReceiveData == end_sign)
 {
 end_Data = ReceiveData;
 buf_string_receive[count_ReceiveData]= ReceiveData;
 }

 if((start_Data == start_sign)&&( end_Data == end_sign))
 {
 receive_complete=1;
 count_ReceiveData=0;
 start_Data= '\0';
 end_Data= '\0';
 }
 else
 {

 if(buf_string_receive[0] != start_sign)
 {
 Clear_buf_string_receive();
 count_ReceiveData = 0;
 }
 buf_string_receive[count_ReceiveData] = ReceiveData;
 count_ReceiveData++;
 if(count_ReceiveData ==  10 )
 {
 count_ReceiveData = 0;
 receive_complete = 0;
 Clear_buf_string_receive();
 }
 }
 if(receive_complete == 1)
 {

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
}
void main()
{
 unsigned char i = 0;
 ADCON1 |= 0x0F;
 CMCON |= 7;

 TRISD = 0x00;
 PORTD = 0x00;
 TRISB = 0x00;
 PORTB = 0x80;


 INTCON.INT0IF = 0;
 INTCON.INT0IE = 1;
 INTCON2.INTEDG0 = 1;
 PIR1.RCIF = 0;
 PIE1.RCIE = 1;
 INTCON.GIE = 1;
 INTCON.PEIE = 1;
 UART1_Init(9600);
 delay_ms(100);
 Lcd_Init();
 while(1);
}


_displays:

;PICCUOIKY.c,41 :: 		void displays(int n,int x)
;PICCUOIKY.c,43 :: 		int countfrom = (n * 10 + x);
	MOVF        FARG_displays_n+0, 0 
	MOVWF       R0 
	MOVF        FARG_displays_n+1, 0 
	MOVWF       R1 
	MOVLW       10
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	CALL        _Mul_16X16_U+0, 0
	MOVF        FARG_displays_x+0, 0 
	ADDWF       R0, 0 
	MOVWF       displays_i_L0+0 
	MOVF        FARG_displays_x+1, 0 
	ADDWFC      R1, 0 
	MOVWF       displays_i_L0+1 
;PICCUOIKY.c,45 :: 		for( i = countfrom; i>=0; i--)
L_displays0:
	MOVLW       128
	XORWF       displays_i_L0+1, 0 
	MOVWF       R0 
	MOVLW       128
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__displays33
	MOVLW       0
	SUBWF       displays_i_L0+0, 0 
L__displays33:
	BTFSS       STATUS+0, 0 
	GOTO        L_displays1
;PICCUOIKY.c,49 :: 		sprintf(buffer,"%d&",i);
	MOVLW       _buffer+0
	MOVWF       FARG_sprintf_wh+0 
	MOVLW       hi_addr(_buffer+0)
	MOVWF       FARG_sprintf_wh+1 
	MOVLW       ?lstr_1_PICCUOIKY+0
	MOVWF       FARG_sprintf_f+0 
	MOVLW       hi_addr(?lstr_1_PICCUOIKY+0)
	MOVWF       FARG_sprintf_f+1 
	MOVLW       higher_addr(?lstr_1_PICCUOIKY+0)
	MOVWF       FARG_sprintf_f+2 
	MOVF        displays_i_L0+0, 0 
	MOVWF       FARG_sprintf_wh+5 
	MOVF        displays_i_L0+1, 0 
	MOVWF       FARG_sprintf_wh+6 
	CALL        _sprintf+0, 0
;PICCUOIKY.c,50 :: 		UART_Write_Text(buffer);
	MOVLW       _buffer+0
	MOVWF       FARG_UART_Write_Text_uart_text+0 
	MOVLW       hi_addr(_buffer+0)
	MOVWF       FARG_UART_Write_Text_uart_text+1 
	CALL        _UART_Write_Text+0, 0
;PICCUOIKY.c,51 :: 		sprintf(buffer1,"%d ",i);
	MOVLW       _buffer1+0
	MOVWF       FARG_sprintf_wh+0 
	MOVLW       hi_addr(_buffer1+0)
	MOVWF       FARG_sprintf_wh+1 
	MOVLW       ?lstr_2_PICCUOIKY+0
	MOVWF       FARG_sprintf_f+0 
	MOVLW       hi_addr(?lstr_2_PICCUOIKY+0)
	MOVWF       FARG_sprintf_f+1 
	MOVLW       higher_addr(?lstr_2_PICCUOIKY+0)
	MOVWF       FARG_sprintf_f+2 
	MOVF        displays_i_L0+0, 0 
	MOVWF       FARG_sprintf_wh+5 
	MOVF        displays_i_L0+1, 0 
	MOVWF       FARG_sprintf_wh+6 
	CALL        _sprintf+0, 0
;PICCUOIKY.c,52 :: 		Lcd_Out(1,1,txt1);
	MOVLW       1
	MOVWF       FARG_Lcd_Out_row+0 
	MOVLW       1
	MOVWF       FARG_Lcd_Out_column+0 
	MOVLW       _txt1+0
	MOVWF       FARG_Lcd_Out_text+0 
	MOVLW       hi_addr(_txt1+0)
	MOVWF       FARG_Lcd_Out_text+1 
	CALL        _Lcd_Out+0, 0
;PICCUOIKY.c,53 :: 		Lcd_Out(1,8,buffer1);
	MOVLW       1
	MOVWF       FARG_Lcd_Out_row+0 
	MOVLW       8
	MOVWF       FARG_Lcd_Out_column+0 
	MOVLW       _buffer1+0
	MOVWF       FARG_Lcd_Out_text+0 
	MOVLW       hi_addr(_buffer1+0)
	MOVWF       FARG_Lcd_Out_text+1 
	CALL        _Lcd_Out+0, 0
;PICCUOIKY.c,55 :: 		PORTD = led7segg[i/10];
	MOVLW       10
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVF        displays_i_L0+0, 0 
	MOVWF       R0 
	MOVF        displays_i_L0+1, 0 
	MOVWF       R1 
	CALL        _Div_16x16_S+0, 0
	MOVLW       _led7segg+0
	ADDWF       R0, 0 
	MOVWF       TBLPTRL 
	MOVLW       hi_addr(_led7segg+0)
	ADDWFC      R1, 0 
	MOVWF       TBLPTRH 
	MOVLW       higher_addr(_led7segg+0)
	MOVWF       TBLPTRU 
	MOVLW       0
	BTFSC       R1, 7 
	MOVLW       255
	ADDWFC      TBLPTRU, 1 
	TBLRD*+
	MOVFF       TABLAT+0, PORTD+0
;PICCUOIKY.c,56 :: 		PORTB = led7segg[i%10];
	MOVLW       10
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVF        displays_i_L0+0, 0 
	MOVWF       R0 
	MOVF        displays_i_L0+1, 0 
	MOVWF       R1 
	CALL        _Div_16x16_S+0, 0
	MOVF        R8, 0 
	MOVWF       R0 
	MOVF        R9, 0 
	MOVWF       R1 
	MOVLW       _led7segg+0
	ADDWF       R0, 0 
	MOVWF       TBLPTRL 
	MOVLW       hi_addr(_led7segg+0)
	ADDWFC      R1, 0 
	MOVWF       TBLPTRH 
	MOVLW       higher_addr(_led7segg+0)
	MOVWF       TBLPTRU 
	MOVLW       0
	BTFSC       R1, 7 
	MOVLW       255
	ADDWFC      TBLPTRU, 1 
	TBLRD*+
	MOVFF       TABLAT+0, PORTB+0
;PICCUOIKY.c,57 :: 		if (i == 0)
	MOVLW       0
	XORWF       displays_i_L0+1, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__displays34
	MOVLW       0
	XORWF       displays_i_L0+0, 0 
L__displays34:
	BTFSS       STATUS+0, 2 
	GOTO        L_displays3
;PICCUOIKY.c,59 :: 		PORTB.RB7 = 0;
	BCF         PORTB+0, 7 
;PICCUOIKY.c,60 :: 		delay_ms(2000);
	MOVLW       51
	MOVWF       R11, 0
	MOVLW       187
	MOVWF       R12, 0
	MOVLW       223
	MOVWF       R13, 0
L_displays4:
	DECFSZ      R13, 1, 1
	BRA         L_displays4
	DECFSZ      R12, 1, 1
	BRA         L_displays4
	DECFSZ      R11, 1, 1
	BRA         L_displays4
	NOP
	NOP
;PICCUOIKY.c,61 :: 		}
L_displays3:
;PICCUOIKY.c,62 :: 		delay_ms(1000);
	MOVLW       26
	MOVWF       R11, 0
	MOVLW       94
	MOVWF       R12, 0
	MOVLW       110
	MOVWF       R13, 0
L_displays5:
	DECFSZ      R13, 1, 1
	BRA         L_displays5
	DECFSZ      R12, 1, 1
	BRA         L_displays5
	DECFSZ      R11, 1, 1
	BRA         L_displays5
	NOP
;PICCUOIKY.c,63 :: 		PORTB.RB7 = 1;
	BSF         PORTB+0, 7 
;PICCUOIKY.c,45 :: 		for( i = countfrom; i>=0; i--)
	MOVLW       1
	SUBWF       displays_i_L0+0, 1 
	MOVLW       0
	SUBWFB      displays_i_L0+1, 1 
;PICCUOIKY.c,64 :: 		}
	GOTO        L_displays0
L_displays1:
;PICCUOIKY.c,66 :: 		}
L_end_displays:
	RETURN      0
; end of _displays

_Clear_buf_string_receive:

;PICCUOIKY.c,69 :: 		void Clear_buf_string_receive(void)
;PICCUOIKY.c,73 :: 		for(i=0;i<max_count_ReceiveData;i++)
	CLRF        R1 
L_Clear_buf_string_receive6:
	MOVLW       10
	SUBWF       R1, 0 
	BTFSC       STATUS+0, 0 
	GOTO        L_Clear_buf_string_receive7
;PICCUOIKY.c,75 :: 		buf_string_receive[i] = '\0';
	MOVLW       _buf_string_receive+0
	MOVWF       FSR1 
	MOVLW       hi_addr(_buf_string_receive+0)
	MOVWF       FSR1H 
	MOVF        R1, 0 
	ADDWF       FSR1, 1 
	BTFSC       STATUS+0, 0 
	INCF        FSR1H, 1 
	CLRF        POSTINC1+0 
;PICCUOIKY.c,73 :: 		for(i=0;i<max_count_ReceiveData;i++)
	INCF        R1, 1 
;PICCUOIKY.c,76 :: 		}
	GOTO        L_Clear_buf_string_receive6
L_Clear_buf_string_receive7:
;PICCUOIKY.c,77 :: 		}
L_end_Clear_buf_string_receive:
	RETURN      0
; end of _Clear_buf_string_receive

_interrupt:

;PICCUOIKY.c,79 :: 		void interrupt(void)
;PICCUOIKY.c,81 :: 		if(PIR1.RCIF == 1)
	BTFSS       PIR1+0, 5 
	GOTO        L_interrupt9
;PICCUOIKY.c,83 :: 		PIR1.RCIF = 0;
	BCF         PIR1+0, 5 
;PICCUOIKY.c,84 :: 		ReceiveData = UART_Read();
	CALL        _UART_Read+0, 0
	MOVF        R0, 0 
	MOVWF       _ReceiveData+0 
;PICCUOIKY.c,85 :: 		if(ReceiveData == start_sign)
	MOVF        R0, 0 
	XORWF       _start_sign+0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L_interrupt10
;PICCUOIKY.c,87 :: 		count_ReceiveData = 0;
	CLRF        _count_ReceiveData+0 
;PICCUOIKY.c,88 :: 		start_Data = ReceiveData;
	MOVF        _ReceiveData+0, 0 
	MOVWF       _start_Data+0 
;PICCUOIKY.c,89 :: 		buf_string_receive[count_ReceiveData]= ReceiveData;
	MOVLW       _buf_string_receive+0
	MOVWF       FSR1 
	MOVLW       hi_addr(_buf_string_receive+0)
	MOVWF       FSR1H 
	MOVF        _count_ReceiveData+0, 0 
	ADDWF       FSR1, 1 
	BTFSC       STATUS+0, 0 
	INCF        FSR1H, 1 
	MOVF        _ReceiveData+0, 0 
	MOVWF       POSTINC1+0 
;PICCUOIKY.c,90 :: 		}
L_interrupt10:
;PICCUOIKY.c,92 :: 		if(ReceiveData == end_sign)
	MOVF        _ReceiveData+0, 0 
	XORWF       _end_sign+0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L_interrupt11
;PICCUOIKY.c,94 :: 		end_Data = ReceiveData;
	MOVF        _ReceiveData+0, 0 
	MOVWF       _end_Data+0 
;PICCUOIKY.c,95 :: 		buf_string_receive[count_ReceiveData]= ReceiveData;
	MOVLW       _buf_string_receive+0
	MOVWF       FSR1 
	MOVLW       hi_addr(_buf_string_receive+0)
	MOVWF       FSR1H 
	MOVF        _count_ReceiveData+0, 0 
	ADDWF       FSR1, 1 
	BTFSC       STATUS+0, 0 
	INCF        FSR1H, 1 
	MOVF        _ReceiveData+0, 0 
	MOVWF       POSTINC1+0 
;PICCUOIKY.c,96 :: 		}
L_interrupt11:
;PICCUOIKY.c,98 :: 		if((start_Data == start_sign)&&( end_Data == end_sign))
	MOVF        _start_Data+0, 0 
	XORWF       _start_sign+0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L_interrupt14
	MOVF        _end_Data+0, 0 
	XORWF       _end_sign+0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L_interrupt14
L__interrupt31:
;PICCUOIKY.c,100 :: 		receive_complete=1;
	MOVLW       1
	MOVWF       _receive_complete+0 
;PICCUOIKY.c,101 :: 		count_ReceiveData=0;
	CLRF        _count_ReceiveData+0 
;PICCUOIKY.c,102 :: 		start_Data= '\0';
	CLRF        _start_Data+0 
;PICCUOIKY.c,103 :: 		end_Data= '\0';
	CLRF        _end_Data+0 
;PICCUOIKY.c,104 :: 		}
	GOTO        L_interrupt15
L_interrupt14:
;PICCUOIKY.c,108 :: 		if(buf_string_receive[0] != start_sign)
	MOVF        _buf_string_receive+0, 0 
	XORWF       _start_sign+0, 0 
	BTFSC       STATUS+0, 2 
	GOTO        L_interrupt16
;PICCUOIKY.c,110 :: 		Clear_buf_string_receive();
	CALL        _Clear_buf_string_receive+0, 0
;PICCUOIKY.c,111 :: 		count_ReceiveData = 0;
	CLRF        _count_ReceiveData+0 
;PICCUOIKY.c,112 :: 		}
L_interrupt16:
;PICCUOIKY.c,113 :: 		buf_string_receive[count_ReceiveData] = ReceiveData;
	MOVLW       _buf_string_receive+0
	MOVWF       FSR1 
	MOVLW       hi_addr(_buf_string_receive+0)
	MOVWF       FSR1H 
	MOVF        _count_ReceiveData+0, 0 
	ADDWF       FSR1, 1 
	BTFSC       STATUS+0, 0 
	INCF        FSR1H, 1 
	MOVF        _ReceiveData+0, 0 
	MOVWF       POSTINC1+0 
;PICCUOIKY.c,114 :: 		count_ReceiveData++;
	INCF        _count_ReceiveData+0, 1 
;PICCUOIKY.c,115 :: 		if(count_ReceiveData == max_count_ReceiveData)
	MOVF        _count_ReceiveData+0, 0 
	XORLW       10
	BTFSS       STATUS+0, 2 
	GOTO        L_interrupt17
;PICCUOIKY.c,117 :: 		count_ReceiveData = 0;
	CLRF        _count_ReceiveData+0 
;PICCUOIKY.c,118 :: 		receive_complete = 0;
	CLRF        _receive_complete+0 
;PICCUOIKY.c,119 :: 		Clear_buf_string_receive();
	CALL        _Clear_buf_string_receive+0, 0
;PICCUOIKY.c,120 :: 		}
L_interrupt17:
;PICCUOIKY.c,121 :: 		}
L_interrupt15:
;PICCUOIKY.c,122 :: 		if(receive_complete == 1)
	MOVF        _receive_complete+0, 0 
	XORLW       1
	BTFSS       STATUS+0, 2 
	GOTO        L_interrupt18
;PICCUOIKY.c,125 :: 		datachar1 = buf_string_receive[1];
	MOVF        _buf_string_receive+1, 0 
	MOVWF       _datachar1+0 
	MOVLW       0
	MOVWF       _datachar1+1 
;PICCUOIKY.c,126 :: 		dataint1 = datachar1 - 48;
	MOVLW       48
	SUBWF       _datachar1+0, 0 
	MOVWF       R1 
	MOVLW       0
	SUBWFB      _datachar1+1, 0 
	MOVWF       R2 
	MOVF        R1, 0 
	MOVWF       _dataint1+0 
	MOVF        R2, 0 
	MOVWF       _dataint1+1 
;PICCUOIKY.c,127 :: 		datachar2 = buf_string_receive[2];
	MOVF        _buf_string_receive+2, 0 
	MOVWF       _datachar2+0 
	MOVLW       0
	MOVWF       _datachar2+1 
;PICCUOIKY.c,128 :: 		dataint2 = datachar2 - 48;
	MOVLW       48
	SUBWF       _datachar2+0, 0 
	MOVWF       _dataint2+0 
	MOVLW       0
	SUBWFB      _datachar2+1, 0 
	MOVWF       _dataint2+1 
;PICCUOIKY.c,130 :: 		if(dataint1 >= 9)
	MOVLW       128
	XORWF       R2, 0 
	MOVWF       R0 
	MOVLW       128
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__interrupt38
	MOVLW       9
	SUBWF       R1, 0 
L__interrupt38:
	BTFSS       STATUS+0, 0 
	GOTO        L_interrupt19
;PICCUOIKY.c,132 :: 		if(dataint2 > 9 || dataint2 < 0)
	MOVLW       128
	MOVWF       R0 
	MOVLW       128
	XORWF       _dataint2+1, 0 
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__interrupt39
	MOVF        _dataint2+0, 0 
	SUBLW       9
L__interrupt39:
	BTFSS       STATUS+0, 0 
	GOTO        L__interrupt30
	MOVLW       128
	XORWF       _dataint2+1, 0 
	MOVWF       R0 
	MOVLW       128
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__interrupt40
	MOVLW       0
	SUBWF       _dataint2+0, 0 
L__interrupt40:
	BTFSS       STATUS+0, 0 
	GOTO        L__interrupt30
	GOTO        L_interrupt22
L__interrupt30:
;PICCUOIKY.c,135 :: 		displays(0,dataint1);
	CLRF        FARG_displays_n+0 
	CLRF        FARG_displays_n+1 
	MOVF        _dataint1+0, 0 
	MOVWF       FARG_displays_x+0 
	MOVF        _dataint1+1, 0 
	MOVWF       FARG_displays_x+1 
	CALL        _displays+0, 0
;PICCUOIKY.c,136 :: 		}
L_interrupt22:
;PICCUOIKY.c,137 :: 		}
L_interrupt19:
;PICCUOIKY.c,138 :: 		if(dataint1 >= 0 && dataint1 <= 9 && dataint2 >=0 && dataint2 <=9)
	MOVLW       128
	XORWF       _dataint1+1, 0 
	MOVWF       R0 
	MOVLW       128
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__interrupt41
	MOVLW       0
	SUBWF       _dataint1+0, 0 
L__interrupt41:
	BTFSS       STATUS+0, 0 
	GOTO        L_interrupt25
	MOVLW       128
	MOVWF       R0 
	MOVLW       128
	XORWF       _dataint1+1, 0 
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__interrupt42
	MOVF        _dataint1+0, 0 
	SUBLW       9
L__interrupt42:
	BTFSS       STATUS+0, 0 
	GOTO        L_interrupt25
	MOVLW       128
	XORWF       _dataint2+1, 0 
	MOVWF       R0 
	MOVLW       128
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__interrupt43
	MOVLW       0
	SUBWF       _dataint2+0, 0 
L__interrupt43:
	BTFSS       STATUS+0, 0 
	GOTO        L_interrupt25
	MOVLW       128
	MOVWF       R0 
	MOVLW       128
	XORWF       _dataint2+1, 0 
	SUBWF       R0, 0 
	BTFSS       STATUS+0, 2 
	GOTO        L__interrupt44
	MOVF        _dataint2+0, 0 
	SUBLW       9
L__interrupt44:
	BTFSS       STATUS+0, 0 
	GOTO        L_interrupt25
L__interrupt29:
;PICCUOIKY.c,140 :: 		displays(dataint1,dataint2);
	MOVF        _dataint1+0, 0 
	MOVWF       FARG_displays_n+0 
	MOVF        _dataint1+1, 0 
	MOVWF       FARG_displays_n+1 
	MOVF        _dataint2+0, 0 
	MOVWF       FARG_displays_x+0 
	MOVF        _dataint2+1, 0 
	MOVWF       FARG_displays_x+1 
	CALL        _displays+0, 0
;PICCUOIKY.c,141 :: 		}
L_interrupt25:
;PICCUOIKY.c,143 :: 		receive_complete = 0;
	CLRF        _receive_complete+0 
;PICCUOIKY.c,144 :: 		count_ReceiveData = 0;
	CLRF        _count_ReceiveData+0 
;PICCUOIKY.c,145 :: 		Clear_buf_string_receive();
	CALL        _Clear_buf_string_receive+0, 0
;PICCUOIKY.c,146 :: 		}
L_interrupt18:
;PICCUOIKY.c,147 :: 		}
L_interrupt9:
;PICCUOIKY.c,148 :: 		}
L_end_interrupt:
L__interrupt37:
	RETFIE      1
; end of _interrupt

_main:

;PICCUOIKY.c,149 :: 		void main()
;PICCUOIKY.c,151 :: 		unsigned char i = 0;
;PICCUOIKY.c,152 :: 		ADCON1 |= 0x0F;
	MOVLW       15
	IORWF       ADCON1+0, 1 
;PICCUOIKY.c,153 :: 		CMCON  |= 7;
	MOVLW       7
	IORWF       CMCON+0, 1 
;PICCUOIKY.c,155 :: 		TRISD = 0x00;
	CLRF        TRISD+0 
;PICCUOIKY.c,156 :: 		PORTD = 0x00;
	CLRF        PORTD+0 
;PICCUOIKY.c,157 :: 		TRISB = 0x00;
	CLRF        TRISB+0 
;PICCUOIKY.c,158 :: 		PORTB = 0x80;
	MOVLW       128
	MOVWF       PORTB+0 
;PICCUOIKY.c,161 :: 		INTCON.INT0IF = 0;
	BCF         INTCON+0, 1 
;PICCUOIKY.c,162 :: 		INTCON.INT0IE = 1;
	BSF         INTCON+0, 4 
;PICCUOIKY.c,163 :: 		INTCON2.INTEDG0 = 1;
	BSF         INTCON2+0, 6 
;PICCUOIKY.c,164 :: 		PIR1.RCIF = 0;
	BCF         PIR1+0, 5 
;PICCUOIKY.c,165 :: 		PIE1.RCIE = 1;
	BSF         PIE1+0, 5 
;PICCUOIKY.c,166 :: 		INTCON.GIE = 1;
	BSF         INTCON+0, 7 
;PICCUOIKY.c,167 :: 		INTCON.PEIE = 1;
	BSF         INTCON+0, 6 
;PICCUOIKY.c,168 :: 		UART1_Init(9600);
	BSF         BAUDCON+0, 3, 0
	MOVLW       2
	MOVWF       SPBRGH+0 
	MOVLW       8
	MOVWF       SPBRG+0 
	BSF         TXSTA+0, 2, 0
	CALL        _UART1_Init+0, 0
;PICCUOIKY.c,169 :: 		delay_ms(100);
	MOVLW       3
	MOVWF       R11, 0
	MOVLW       138
	MOVWF       R12, 0
	MOVLW       85
	MOVWF       R13, 0
L_main26:
	DECFSZ      R13, 1, 1
	BRA         L_main26
	DECFSZ      R12, 1, 1
	BRA         L_main26
	DECFSZ      R11, 1, 1
	BRA         L_main26
	NOP
	NOP
;PICCUOIKY.c,170 :: 		Lcd_Init();
	CALL        _Lcd_Init+0, 0
;PICCUOIKY.c,171 :: 		while(1);
L_main27:
	GOTO        L_main27
;PICCUOIKY.c,172 :: 		}
L_end_main:
	GOTO        $+0
; end of _main

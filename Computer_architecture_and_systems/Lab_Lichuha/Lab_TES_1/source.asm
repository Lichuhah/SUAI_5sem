;������� ���������:
;��������� A+C-C*B, ��������� � A1;
	.ref _c_int00     ;����� �����
_c_int00:
	

	.text
	
		MVK .S1 1,A0 		;A = -8   	
 		MVK .S1 2,A1 		;B = 2 	
 		MVK .S1 3,A2 		;C = 6 	
 		
 	
 		MPY .M1 A1,A2,A1   	;��������� BxC, ��������� � A1
 		NOP 
	
		ADD .L1 A0,A2,A0	;�������� A+C, ��������� � �0

		SUB .L1 A0,A1,A0	;��������� A+C-B*C, ��������� � �0
		NOP
	.end
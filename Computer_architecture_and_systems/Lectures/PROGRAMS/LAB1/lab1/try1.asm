;������� ���������:
;��������� A+ABS(BxC-D), ��������� � A1;
	.ref _c_int00     ;����� �����
_c_int00:
	

	.text
	
		MVK .S1 -8,A0 		;A = -8   	
 		MVK .S1 2,A1 		;B = 2 	
 		MVK .S1 6,A2 		;C = 6 	
 		MVK .S1 20,A3 		;D = 20
 		
 	
 		MPY .M1 A1,A2,A1   	;��������� BxC, ��������� � A1
 		NOP 
 		
 		SUB .L1 A1, A3,A3	;��������� BxC-D, ��������� � A3 	
 	
		ABS	.L1	A3,A1   	;��������� ������ A1 = |A3| - ������; A3=BxC-D;
	
		ADD .L1 A0,A1,A1	;
	
 	
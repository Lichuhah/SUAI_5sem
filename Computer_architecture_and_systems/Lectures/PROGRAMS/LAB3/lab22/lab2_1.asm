;������������ ������������ ��������� 2 ��������
;������� A0 �������� �������� ����� ������������
;������������ ���������� ����������

 .ref _c_int00     ;����� �����
_c_int00:
	
;///////////////////////////////////////	
 .data   ;������ ������
 
array1:	.int 1,2,3;,4,5,6    ;������� ������ 32 ��������� �����
array2:	.int 1,2,3;,4,5,6 ;������� ������ 32 ��������� �����
size    .set 3		  	 	;������ �������(>1)(��������������� ���������)  	


;///////////////////////////////////////
 .text   ;������ ���� 
 

        ;�������������:
 		MVKL .S1 array1,A3    ;��������� ����� �������1 � A3
		MVKH .S1 array1,A3
		
		MVKL .S1 array2,A7    ;��������� ����� �������2 � A7
		MVKH .S1 array2,A7
		
		MVK .S1 size,A2    ;��������� ����� ��������� ������� � A2
		MVK .S1 0,A4	   ;������������ ������� ��������� �������	
		MVK .S1 0,A0	   ;����� ������������
		MVK .S2 0,B2	   ; ���. ������� ���������� �� ������� 1
		MVK .S1 0,A5	   ; ���. ������� ���������� �� ������� 1
		LDW   .D1  *A3++, B2	;��������� ������� ������� � B2		
		LDW   .D1  *A7++, A5	;��������� ������� ������� � A2     		
		
		
LOOP:			
	
		[A2] B .S1 LOOP			;������� ���� A2 <> 0  		
		SUB .L1 A2,1,A2      	;A2 := A2 - 1					
		LDW   .D1  *A3++, B2	;��������� ������� ������� � B2		
		LDW   .D1  *A7++, A5	;��������� ������� ������� � A2         				
		MPY .M1X A5,B2,A4   	;��������� ��������� ��������  		
		ADD .L1 A0, A4,A0		;����� ����������� ���������  		
		
		
			
		
			
		
		
		
		
	

    
 	
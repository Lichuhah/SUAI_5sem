	.ref _c_int00
_c_int00:
	.data
	
array1:		.int 1,1,1
array2: 	.int 1,2,3
arrayRes:	.int 0,0,0
size	.set 3	

	.text
	
		MVKL .S1 array1,A3 		;��������� ������ ������ � A3   	
 		MVKH .S1 array1,A3 		;
 		
 		MVKL .S1 array2,A7		;��������� ������ ������ � A4
 		MVKH .S1 array2,A7		;

		MVKL .S1 arrayRes,A1	;��������� ���������� � A1
 		MVKH .S1 arrayRes,A1	;

 		MVK .S1 size,A2 		;��������� ������ ������� � �2		
 	 
		MVK .S2 0,B2			;��� �� �� ������� ������� 
		MVK .S1 0,A5			;��� �� �� ������� �������
		MVK .S1 0,A0			;��� �����
		
LOOP:
		SUB .L1 A2,1,A2			;��������� �������
		LDW .D1 *A3[A2],B2		;��������� ��� �� ������� �������
		NOP 4
		LDW .D1 *A7[A2],A5		;��������� ��� �� ������� �������
		NOP 4
		ADD .L1X A5,B2,A0		;�������� ����� ��� ���������
		STW .D1 A0,*A1[A2]		;��������� ����� � ���������
		[A2] B .S1 LOOP
		NOP 5
	.end
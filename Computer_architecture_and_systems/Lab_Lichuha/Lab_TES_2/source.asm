	.ref _c_int00
_c_int00:
	.data
	
array1:		.short 1,1,1
array2: 	.short 1,2,3
arrayRes:	.short 0,0,0
size	.set 3	

	.text
	
		MVKL .S1 array1,A3 		;��������� ������ ������ � A3   	
 		MVKH .S1 array1,A3 		;
 		
 		MVKL .S1 array2,A4		;��������� ������ ������ � A4
 		MVKH .S1 array2,A4		;

		MVKL .S1 arrayRes,A5	;��������� ���������� � A5
 		MVKH .S1 arrayRes,A5	;

 		MVK .S1 size,A2 		;��������� ������ ������� � �2		
 	 
		MVK .S1 0,A6			;��� �� �� ������� ������� 
		MVK .S1 0,A7			;��� �� �� ������� �������
		MVK .S1 0,A8			;��� �����
		
LOOP:
		SUB .L1 A2,1,A2			;��������� �������
		LDW .D1 *A3[A2],A6		;��������� ��� �� ������� �������
		NOP 4
		LDW .D1 *A4[A2],A7		;��������� ��� �� ������� �������
		NOP 4
		ADD .L1 A6,A7,A8		;�������� ����� ��� ���������
		STW .D1 A8,*A5[A2]		;��������� ����� � ���������
		[A2] B .S1 LOOP
		NOP 5
	.end
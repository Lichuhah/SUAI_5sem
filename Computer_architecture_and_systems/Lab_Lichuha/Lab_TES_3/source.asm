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
 		
 		MVKL .S1 array2,A4		;��������� ������ ������ � A4
 		MVKH .S1 array2,A4		;

		MVKL .S1 arrayRes,A5	;��������� ���������� � A5
 		MVKH .S1 arrayRes,A5	;

 		MVK .S1 size,A2 		;��������� ������ ������� � �2		
 	 
		MVK .S1 0,A6			;��� �� �� ������� ������� 
		MVK .S1 0,A7			;��� �� �� ������� �������
		MVK .S1 0,A8			;��� �����

		LDW .D1 *A3++,A6		;��������� ��� �� ������� �������
		LDW .D1 *A4++,A7		;��������� ��� �� ������� �������
		
LOOP:
		[A2] B .S1 LOOP
		SUB .L1 A2,1,A2			;��������� �������
		LDW .D1 *A3++,A6		;��������� ��� �� ������� �������
		LDW .D1 *A4++,A7		;��������� ��� �� ������� �������
		ADD .L1 A6,A7,A8		;�������� ����� ��� ���������
		STW .D1 A8,*A5[A2]		;��������� ����� � ���������
	.end
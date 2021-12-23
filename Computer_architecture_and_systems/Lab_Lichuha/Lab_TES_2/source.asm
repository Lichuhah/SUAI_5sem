	.ref _c_int00
_c_int00:
	.data
	
array1:		.int 1,1,1
array2: 	.int 1,2,3
arrayRes:	.int 0,0,0
size	.set 3	

	.text
	
		MVKL .S1 array1,A3 		;загружаем первый вектор в A3   	
 		MVKH .S1 array1,A3 		;
 		
 		MVKL .S1 array2,A7		;загружаем второй вектор в A4
 		MVKH .S1 array2,A7		;

		MVKL .S1 arrayRes,A1	;загружаем резлультат в A1
 		MVKH .S1 arrayRes,A1	;

 		MVK .S1 size,A2 		;загружаем размер массива в А2		
 	 
		MVK .S2 0,B2			;тек эл из первого вектора 
		MVK .S1 0,A5			;тек эл из второго вектора
		MVK .S1 0,A0			;тек сумма
		
LOOP:
		SUB .L1 A2,1,A2			;уменьшаем счетчик
		LDW .D1 *A3[A2],B2		;загружаем тек эл первого вектора
		NOP 4
		LDW .D1 *A7[A2],A5		;загружаем тек эл второго вектора
		NOP 4
		ADD .L1X A5,B2,A0		;получаем сумму тек элементов
		STW .D1 A0,*A1[A2]		;загружаем сумму в результат
		[A2] B .S1 LOOP
		NOP 5
	.end
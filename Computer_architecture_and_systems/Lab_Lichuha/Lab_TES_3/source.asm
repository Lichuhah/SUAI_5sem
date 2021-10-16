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
 		
 		MVKL .S1 array2,A4		;загружаем второй вектор в A4
 		MVKH .S1 array2,A4		;

		MVKL .S1 arrayRes,A5	;загружаем резлультат в A5
 		MVKH .S1 arrayRes,A5	;

 		MVK .S1 size,A2 		;загружаем размер массива в А2		
 	 
		MVK .S1 0,A6			;тек эл из первого вектора 
		MVK .S1 0,A7			;тек эл из второго вектора
		MVK .S1 0,A8			;тек сумма

		LDW .D1 *A3++,A6		;загружаем тек эл первого вектора
		LDW .D1 *A4++,A7		;загружаем тек эл второго вектора
		
LOOP:
		[A2] B .S1 LOOP
		SUB .L1 A2,1,A2			;уменьшаем счетчик
		LDW .D1 *A3++,A6		;загружаем тек эл первого вектора
		LDW .D1 *A4++,A7		;загружаем тек эл второго вектора
		ADD .L1 A6,A7,A8		;получаем сумму тек элементов
		STW .D1 A8,*A5[A2]		;загружаем сумму в результат
	.end
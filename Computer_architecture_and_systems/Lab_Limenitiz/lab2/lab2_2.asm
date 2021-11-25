    .ref _c_int00
_c_int00:


.data

array1: .int 1, 2, 1
size .set 3


.text
    MVK .S1 0, A0 ; GOTO label
    MVK .S1 0, A1 ; TRUE

    MVK  .S1 0,      A2 ; index начала массива
    MVK  .S1 size,   A3 ; index конца массива
    MVKL .S1 array1, A4
    MVKH .S1 array1, A4

LOOP:
    ADD .L1 A2, 1, A2       ; A2 = A2 + 1 ; index левый
    SUB .L1 A3, 1, A3       ; A3 = A3 - 1 ; index правый

    ; условие: правый index не ноль 
    ; если 0 -> нормальный выход
	ADD .S1 A3, 0, A1
    [A1] B .S1 FINAL 
    NOP 5

    LDW .D1 *A4[A2], A5     ; загружаем текущий элемент в A5 ; левый элемент
    NOP 4                   ; 4х тактовая задержка загрузки

    LDW .D1 *A4[A3], A6     ; загружаем текущий элемент в A6 ; правый элемент
    NOP 4                   ; 4х тактовая задержка загрузки

    SUB .S1 A5, A6, A1 ; условие: правый == левый
    [A1] B .S1 LOOP             ; (правый == левый) если ноль       -> внутрь цикла
    NOP 5


FINAL:



 .ref _c_int00     ;òî÷êà âõîäà
_c_int00:
	
;///////////////////////////////////////	
 .data   ;ñåêöèÿ äàííûõ
 
array:	.int 1,-2,3,-4,-5,6    ;ñîçäàåì ìàññèâ 32 ðàçðÿäíûõ ÷èñåë
size    .set 6		  	 	;ðàçìåð ìàññèâà(>1)(ïðåïðîöåññîðíàÿ êîíñòàíòà)  	


;///////////////////////////////////////
 .text   ;ñåêöèÿ êîäà 
 
        ;Èíèöèàëèçàöèÿ:
 		MVKL .S1 array,A3    ;çàãðóæàåì àäðåñ ìàññèâà1 â A3
		MVKH .S1 array,A3

		MVK .S1 0,A1	   ; ìîäóëü
		MVK .S1 size,A2    ; çàãðóæàåì êîëâî ýëåìåíòîâ ìàññèâà â A2
		MVK .S1 0,A4	   ; ñóììà ïîëîæèòåëüíûõ ýëåìåíòîâ ìàññèâà	
		MVK .S2 0,B2	   ; òåê. ýëåìåíò âûáèðàåìûé èç ìàññèâà 1	
		MVK .S2 0,B1	   ; òåê. ýëåìåíò âûáèðàåìûé èç ìàññèâà 1

LOOP:
		SUB .L1 A2,1,A2      	; A2 := A2 - 1				;
		LDW   .D1  *A3[A2], B2	; çàãðóæàåì òåêóùèé ýëåìåíò â B2;     
		NOP 4					; 4õ òàêòîâàÿ çàäåðæêà çàãðóçêè ;

		ABS .L1 B2,A1		; ìîäóëü
		ADD .L1 A1,B2,A1	; ñëîæåíèå 

		[A1] ADD .L1 B2,A4,A4

		[A2] B .S1 LOOP			;ïåðåõîä åñëè A2 <> 0  
		NOP 5
	

    
 	
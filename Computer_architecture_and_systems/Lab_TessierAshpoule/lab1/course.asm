	.ref _c_int00     ;
_c_int00:
	

	.text
	
		MVK .S1 -8,A0 		; A = -8   	
 		MVK .S1 2,A1 		; B = 2 	
 		MVK .S1 6,A2 		; C = 6 	
 		MVK .S1 20,A3 		; D = 20
 		MVK .S1 1,A4		; 1 = 1
 		
		;1;
		ADD .L1 A0,A1,A0	; ñëîæåíèå A+B, Ðåçóëüòàò â A0

		;2;
		SUB .L1 A2,A3,A2	; âû÷èòàíèå C-D, ðåçóëüòàò â A2
		NOP

		;3;
		SUB .L1 A2,1,A2	; âû÷èòàíèå C-D-1, ðåçóëüòàò â A2
		NOP

		;4;
 		MPY .M1 A1,A0,A1   	; óìíîæåíèå (A+B)*B ðåçóëüòàò â A1
 		NOP 
	
		;5;
		SUB .L1 A1,A2,A0	; âû÷èòàíèå (A+B)*B-(C-D-1), ðåçóëüòàò â A0
		NOP
	.end
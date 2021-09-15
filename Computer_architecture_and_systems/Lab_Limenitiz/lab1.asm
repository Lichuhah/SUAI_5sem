_c_int00:

.text

		MVK .S1 8, A0		; A = 8
		MVK .S1 2, A1		; B = 2
		MVK .S1 4, A2		; C = 4
		MVK .S1 0, A3		; D = 0

		MVK .S1 4, A4		; 4
		MVK .S1 1, A5		; 1

		SUB .L1 A0, A2, A0	; A-C		
		SUB .L1 A1, A5, A1	; B-1

		MPY .M1 A0, A1, A0	; (A-C)*(B-1)
		MPY .M1 A3, A4, A3	; D*4

		SUB .L1 A0, A3, A0  ; D*4 + (A-C)*(B-1)


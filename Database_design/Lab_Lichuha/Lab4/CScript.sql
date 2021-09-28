SELECT * FROM Payment LEFT JOIN Owner_Payment ON Payment.ID = Owner_Payment.ID_Payment
WHERE Owner_Payment.ID_Payment IS NULL

SELECT * FROM Owner_Payment RIGHT JOIN Payment ON Payment.ID = Owner_Payment.ID_Payment
WHERE Owner_Payment.ID_Payment IS NULL
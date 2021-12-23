SELECT Owner.* FROM Owner 
WHERE NOT EXISTS
(SELECT * FROM Payment
WHERE Payment.Name LIKE 'O%' AND NOT EXISTS
(SELECT * FROM Owner_Payment as st_a
WHERE Owner.ID=st_a.ID_Owner
AND st_a.ID_Payment= Payment.ID))
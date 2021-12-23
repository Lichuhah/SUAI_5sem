CREATE TRIGGER build_after_delete
ON Building
AFTER DELETE
AS 

UPDATE Area SET 
FullPrice = FullPrice - deleted.Price FROM deleted
WHERE Area.Number = Number_Area
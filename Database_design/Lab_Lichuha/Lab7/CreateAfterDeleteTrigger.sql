CREATE TRIGGER build_after_delete
ON Building
AFTER DELETE
AS 

UPDATE Area SET 
FullPrice = FullPrice - (SELECT Price FROM inserted)
WHERE Area.Number = (SELECT Number_Area FROM inserted)
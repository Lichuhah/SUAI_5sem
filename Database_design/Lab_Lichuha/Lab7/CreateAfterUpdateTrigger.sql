CREATE TRIGGER build_after_update
ON Building
AFTER UPDATE
AS 

UPDATE Area SET
FullPrice = FullPrice - (SELECT Price FROM deleted)
WHERE Area.Number = (SELECT Number_Area FROM inserted)
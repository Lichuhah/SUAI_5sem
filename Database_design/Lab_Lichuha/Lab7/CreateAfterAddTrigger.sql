CREATE TRIGGER build_after_add
ON Building
AFTER INSERT
AS 

UPDATE Area SET
FullPrice = FullPrice - (SELECT Price FROM deleted) + (SELECT Price FROM inserted)
WHERE Area.Number = (SELECT Number_Area FROM inserted)
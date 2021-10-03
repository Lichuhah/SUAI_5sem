CREATE TRIGGER build_after_add
ON Building
AFTER INSERT
AS 

UPDATE Area SET
FullPrice = FullPrice + inserted.Price FROM inserted
WHERE Area.Number = Number_Area
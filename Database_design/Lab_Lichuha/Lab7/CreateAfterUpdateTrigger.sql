CREATE TRIGGER build_after_update
ON Building
AFTER UPDATE
AS 

UPDATE Area SET
FullPrice = FullPrice - deleted.Price FROM deleted
WHERE Area.Number = Number_Area

UPDATE Area SET
FullPrice = FullPrice + inserted.Price FROM inserted
WHERE Area.Number = Number_Area
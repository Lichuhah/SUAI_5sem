CREATE TRIGGER after_insert
ON Building
AFTER INSERT
AS 

UPDATE Area SET
FullPrice = FullPrice + (SELECT COALESCE(SUM(inserted.Price),0) FROM inserted
WHERE Number = Number_Area) 

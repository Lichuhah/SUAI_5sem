CREATE TRIGGER build_before_update
ON Building
INSTEAD OF UPDATE
AS 

DECLARE @IdNewType int
SELECT @IdNewType = ID_TypeBuilding FROM inserted
DECLARE @IdNewNumber int
SELECT @IdNewNumber = Number_Area FROM inserted

IF (NOT EXISTS (SELECT * FROM TypeBuilding WHERE TypeBuilding.ID IN (SELECT ID_TypeBuilding FROM inserted)) AND EXISTS (SELECT * FROM inserted WHERE ID_TypeBuilding IS NOT NULL))
	PRINT 'ER1'
ELSE 
	IF NOT EXISTS (SELECT * FROM Area WHERE (Area.Number IN (SELECT Number_Area FROM inserted)))
	PRINT 'ER2'
ELSE 
	BEGIN
	UPDATE Building SET 
	Number_Area = inserted.Number_Area,
	ID_TypeBuilding = inserted.ID_TypeBuilding,
	Price = inserted.Price,
	Size = inserted.Size
	FROM inserted
	WHERE Building.ID = inserted.ID
	END
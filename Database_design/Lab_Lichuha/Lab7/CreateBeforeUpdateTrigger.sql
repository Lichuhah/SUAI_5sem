CREATE TRIGGER build_before_update
ON Building
INSTEAD OF UPDATE
AS 

DECLARE @IdNewType int
SELECT @IdNewType = ID_TypeBuilding FROM inserted
DECLARE @IdNewNumber int
SELECT @IdNewNumber = Number_Area FROM inserted

IF (NOT EXISTS (SELECT * FROM TypeBuilding WHERE TypeBuilding.ID = @IdNewType) 
OR 
NOT EXISTS (SELECT * FROM Area WHERE Area.Number = @IdNewNumber))
	PRINT 'Œ¯»·Œ˜ ‡'
ELSE
	BEGIN
	UPDATE Building SET 
	Number_Area = @IdNewNumber,
	ID_TypeBuilding = @IdNewType,
	Price = (SELECT Price FROM inserted),
	Size = (SELECT Size FROM inserted)
	WHERE ID = (SELECT ID FROM inserted)
	END
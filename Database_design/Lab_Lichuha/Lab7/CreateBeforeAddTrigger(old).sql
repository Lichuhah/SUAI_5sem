CREATE TRIGGER build_before_add
ON Building
INSTEAD OF INSERT
AS 

DECLARE @IdType int
SELECT @IdType = TypeBuilding.ID FROM TypeBuilding JOIN inserted ON TypeBuilding.ID=inserted.ID_TypeBuilding 

DECLARE @IdNumber int
SELECT @IdNumber = Area.Number FROM Area JOIN inserted ON Area.Number=inserted.Number_Area 

IF @IdNumber IS NULL
	PRINT 'ERROR'
ELSE BEGIN
	IF @IdType IS NULL
		BEGIN
		SET @IdType=5
		END

	INSERT INTO Building(ID_TypeBuilding, Number_Area, Size, Price) VALUES (
	@IdType, (SELECT Number_Area FROM inserted), (SELECT Size FROM inserted), (SELECT Price FROM inserted))
END

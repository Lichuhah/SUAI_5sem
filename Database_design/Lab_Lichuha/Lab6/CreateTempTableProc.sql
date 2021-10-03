CREATE PROCEDURE infoGard
 AS
     BEGIN
	 CREATE TABLE #GardInfo1
	 (
	 [ID] [int] PRIMARY KEY IDENTITY (1,1),
	 [OwnerID] [int],
	 [OwnerName] [nvarchar](50),
	 [OwnerSurname] [nvarchar](50),
	 [CountAreas] [int],
	 [CountBuilds] [int],
	 )

	 INSERT INTO #GardInfo1(OwnerId,OwnerName,OwnerSurname)
		SELECT Owner.ID, Owner.Name, Owner.Surname FROM Owner

	 UPDATE #GardInfo1 SET CountAreas =
	    (SELECT COUNT(an) FROM (SELECT Area.Number as an FROM Area JOIN Owner_Area ON Area.Number=Owner_Area.Number_Area WHERE Owner_Area.Id_Owner=OwnerID) as temp)

	 UPDATE #GardInfo1 SET CountBuilds =
	    (SELECT COUNT(bi) FROM (SELECT Building.ID as bi 
		FROM Building JOIN Area ON Area.Number= Building.Number_Area JOIN Owner_Area ON Owner_Area.Number_Area = Area.Number WHERE Owner_Area.Id_Owner=OwnerID) as temp)

	 SELECT * FROM #GardInfo1

	 SELECT AVG (CountAreas) as 'Среднее кол-во участков',AVG(CountBuilds) as 'Среднее кол-во строений'FROM #GardInfo1

	 DROP TABLE #GardInfo1

	 END
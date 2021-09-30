SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number,TypeBuilding.Name HAVING TypeBuilding.Name = 'Туалет'
EXCEPT
SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number,TypeBuilding.Name HAVING TypeBuilding.Name = 'Баня'

SELECT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number,TypeBuilding.Name HAVING TypeBuilding.Name = 'Туалет' AND Area.Number NOT IN (
SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number,TypeBuilding.Name HAVING TypeBuilding.Name = 'Баня')

SELECT DISTINCT a.Number FROM
(
(SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID WHERE TypeBuilding.Name='Туалет') 
AS a 
LEFT JOIN 
(SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID WHERE TypeBuilding.Name ='Баня') 
AS b ON a.Number=b.Number
) WHERE b.Number IS NULL
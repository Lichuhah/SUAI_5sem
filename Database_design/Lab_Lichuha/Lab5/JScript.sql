SELECT DISTINCT Area.Number, Area.ID_Line, Area.Price, Area.Size FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number, Area.ID_Line, Area.Price, Area.Size,TypeBuilding.Name HAVING TypeBuilding.Name = '������'
EXCEPT
SELECT DISTINCT  Area.Number, Area.ID_Line, Area.Price, Area.Size FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number, Area.ID_Line, Area.Price, Area.Size,TypeBuilding.Name HAVING TypeBuilding.Name = '����'

SELECT Area.Number, Area.ID_Line, Area.Price, Area.Size FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number, Area.ID_Line, Area.Price, Area.Size,TypeBuilding.Name HAVING TypeBuilding.Name = '������' AND Area.Number NOT IN (
SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number,TypeBuilding.Name HAVING TypeBuilding.Name = '����')

SELECT DISTINCT a.Number, a.ID_Line, a.Price, a.Size FROM
(
(SELECT DISTINCT Area.Number, Area.ID_Line, Area.Price, Area.Size FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID WHERE TypeBuilding.Name='������') 
AS a 
LEFT JOIN 
(SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID WHERE TypeBuilding.Name ='����') 
AS b ON a.Number=b.Number
) WHERE b.Number IS NULL
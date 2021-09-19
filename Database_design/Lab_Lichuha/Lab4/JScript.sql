SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number,TypeBuilding.Name HAVING TypeBuilding.Name = '������'
EXCEPT
SELECT DISTINCT Area.Number FROM Area JOIN Building ON Area.Number = Building.Number_Area JOIN TypeBuilding ON Building.ID_TypeBuilding = TypeBuilding.ID
GROUP BY Area.Number,TypeBuilding.Name HAVING TypeBuilding.Name = '����'
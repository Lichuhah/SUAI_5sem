SELECT DISTINCT Area.Number FROM Building JOIN Area ON Building.Number_Area=Area.Number 
GROUP BY Area.Number HAVING COUNT(Building.ID_TypeBuilding)>1
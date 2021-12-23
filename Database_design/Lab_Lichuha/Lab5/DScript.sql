SELECT Area.Number, Owner.Name, COUNT(distinct Building.ID_TypeBuilding)
FROM Building 
JOIN Area ON Building.Number_Area=Area.Number 
JOIN Owner_Area ON Area.Number=Owner_Area.Number_Area 
JOIN Owner ON Owner.ID=Owner_Area.Id_Owner
GROUP BY Area.Number, Owner.Name HAVING COUNT(distinct Building.ID_TypeBuilding)
= 
(
SELECT MAX(tbl.count) FROM (SELECT Area.Number as 'num', COUNT(distinct Building.ID_TypeBuilding) as 'count'
FROM Building 
JOIN Area ON Building.Number_Area=Area.Number 
JOIN Owner_Area ON Area.Number=Owner_Area.Number_Area 
GROUP BY Area.Number) as tbl
)


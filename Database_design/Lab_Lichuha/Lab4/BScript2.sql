--SELECT a.Number_Area,b.Number_Area,a.ID_TypeBuilding,b.ID_TypeBuilding FROM Building a, Building b
SELECT DISTINCT a.Number_Area, Area.ID_Line, Area.Price, Area.Size 
FROM Building a, Building b JOIN Area ON Number_Area=Area.Number
WHERE a.ID_TypeBuilding!=b.ID_TypeBuilding and a.Number_Area=b.Number_Area

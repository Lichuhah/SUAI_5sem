--SELECT a.Number_Area,b.Number_Area,a.ID_TypeBuilding,b.ID_TypeBuilding FROM Building a, Building b
SELECT DISTINCT a.Number_Area FROM Building a, Building b
WHERE a.ID_TypeBuilding!=b.ID_TypeBuilding and a.Number_Area=b.Number_Area

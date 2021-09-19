SELECT DISTINCT TOP 1 Area.Number,COUNT(Building.ID_TypeBuilding) as 'Типы построек', Owner.ID, Owner.Name, Owner.Midname
FROM Building JOIN Area ON Building.Number_Area=Area.Number JOIN Owner_Area ON Area.Number=Owner_Area.Number_Area JOIN Owner ON Owner.ID=Owner_Area.Id_Owner
GROUP BY Area.Number, Owner.ID, Owner.Name, Owner.Midname

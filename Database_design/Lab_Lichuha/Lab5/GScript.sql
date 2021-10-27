SELECT Owner.Name, Owner.Surname, a1.Size FROM Area a1 
JOIN Owner_Area ON a1.Number=Owner_Area.Number_Area 
JOIN Owner ON Owner.ID=Owner_Area.Id_Owner
WHERE a1.Size >= ALL (SELECT Size FROM Area a2 )

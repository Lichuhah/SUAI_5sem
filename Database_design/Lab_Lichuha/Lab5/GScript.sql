SELECT Owner.Name, Owner.Surname, a1.Size FROM Area a1 JOIN Owner_Area ON a1.Number=Owner_Area.Number_Area JOIN Owner ON Owner.ID=Owner_Area.Id_Owner
WHERE not exists (SELECT * FROM Area a2
					 WHERE a2.Number <> a1.Number AND a2.Size>a1.Size)

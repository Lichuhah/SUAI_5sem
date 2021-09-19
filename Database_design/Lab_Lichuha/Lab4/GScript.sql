SELECT TOP 1 WITH TIES Owner.Id,Owner.Name,Owner.Midname,Area.Size
FROM Area JOIN Owner_Area ON Area.Number=Owner_Area.Number_Area JOIN Owner ON Owner.ID=Owner_Area.Id_Owner
ORDER BY Area.Size DESC;
CREATE TABLE Owner_Area_Old (
[Number_Area] [int],
[Id_Owner] [int],
)

INSERT INTO Owner_Area_Old VALUES (2,2),(3,2)

MERGE Owner_Area USING Owner_Area_Old ON Owner_Area.Number_Area = Owner_Area_Old.Number_Area
WHEN MATCHED THEN
		UPDATE SET Owner_Area.Id_Owner=Owner_Area_Old.Id_Owner
WHEN NOT MATCHED THEN
		INSERT VALUES(Owner_Area_Old.Number_Area, Owner_Area_Old.Id_Owner)
;

DROP TABLE Owner_Area_Old
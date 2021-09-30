CREATE TRIGGER build_before_delete
ON TypeBuilding
INSTEAD OF DELETE
AS 

UPDATE Building SET
ID_TypeBuilding = NULL WHERE ID_TypeBuilding = (SELECT ID FROM deleted)

DELETE FROM TypeBuilding WHERE ID = (SELECT ID FROM deleted)
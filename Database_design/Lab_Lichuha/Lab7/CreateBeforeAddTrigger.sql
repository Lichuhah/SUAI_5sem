CREATE TRIGGER before_add
ON Owner
INSTEAD OF INSERT
AS 

INSERT INTO Owner SELECT LEFT(Name,1),Surname, Birthday, LEFT(Midname,1),HashBytes('MD5',OwnerKey)
FROM inserted


CREATE TRIGGER before_insert
ON Owner
INSTEAD OF INSERT
AS 
INSERT INTO Owner  (Name, Surname, Birthday, Midname)
(SELECT LEFT(Name,1), Surname, Birthday, Left(Midname,1) FROM inserted)

SELECT LEFT(Name,1), Surname, Birthday, Left(Midname,1) FROM inserted


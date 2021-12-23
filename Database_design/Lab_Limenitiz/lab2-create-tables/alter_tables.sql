ALTER TABLE Clothes
ADD COLUMN description varchar(200) default null;

ALTER TABLE Clothes
DROP COLUMN description;


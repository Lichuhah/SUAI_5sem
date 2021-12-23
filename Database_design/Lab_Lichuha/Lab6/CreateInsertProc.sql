CREATE PROCEDURE ins_area
(
@areaNum int,
@lineNum int,
@size int,
@price int
) AS
     BEGIN
        DECLARE @id_line_new int
		DECLARE @id_area_new int

		IF NOT EXISTS (SELECT * FROM Line WHERE Line.Number=@lineNum)
			 INSERT INTO Line VALUES (@lineNum)

		SET @id_line_new = (SELECT TOP 1 Line.ID FROM Line ORDER BY ID DESC)
		INSERT INTO Area VALUES (@areaNum, @id_line_new, @size, @price)
     END
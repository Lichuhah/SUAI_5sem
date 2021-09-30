CREATE PROCEDURE ins_area
(
@lineNum int,
@size int,
@price int
) AS
     BEGIN
        DECLARE @id_line_new int
		DECLARE @id_area_new int

		IF NOT EXISTS (SELECT * FROM Line WHERE Line.Number=@lineNum)
			 INSERT INTO Line VALUES (@lineNum)

		SET @id_line_new = (SELECT TOP 1 Line.Number FROM Line WHERE Line.ID=@lineNum)
		INSERT INTO Area VALUES (@id_line_new, @size, @price)
     END
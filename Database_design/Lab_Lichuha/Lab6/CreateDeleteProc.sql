CREATE PROCEDURE del_area
(
@areaNum int
) AS
     BEGIN
	 IF NOT EXISTS (SELECT * FROM Building WHERE Building.Number_Area=@areaNum) BEGIN
		DECLARE @lineDelId int
		SET @lineDelId=(SELECT Area.ID_Line FROM Area WHERE Area.Number=@areaNum)

		DELETE FROM Area WHERE Area.Number = @areaNum
		
		IF NOT EXISTS (SELECT * FROM Area WHERE Area.ID_Line=@lineDelId)
			DELETE FROM Line WHERE Line.ID=@lineDelId
	 END
	 ELSE PRINT 'Error'
	 END
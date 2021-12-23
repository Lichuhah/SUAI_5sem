CREATE PROCEDURE count_areas
 AS
     BEGIN
	 RETURN (SELECT COUNT(Area.Number) FROM Area)
	 END
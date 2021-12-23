DECLARE @res INT;  
EXEC @res = count_areas;  
SELECT 'Return Status' = @res;  
GO  
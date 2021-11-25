CREATE TRIGGER before_update
ON Area
INSTEAD OF UPDATE
AS 

DECLARE @num int = 0
WHILE(1 = 1) BEGIN
SELECT @num = MIN(Number) FROM deleted 
WHERE Number > @num
IF @num IS NULL BREAK
INSERT INTO Area_log SELECT * FROM deleted WHERE Number=@num
END

UPDATE ta SET ta.ID_Line=tb.ID_Line, ta.Size=tb.Size, ta.FullPrice=tb.FullPrice
FROM Area as ta INNER JOIN inserted as tb ON ta.Number = tb.Number

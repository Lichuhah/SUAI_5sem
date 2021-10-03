CREATE PROCEDURE del_cascade_owner
(
@ownerID int
) AS
     BEGIN
	 DELETE FROM Owner_Area WHERE Owner_Area.Id_Owner=@ownerID
	 DELETE FROM Owner_Payment WHERE Owner_Payment.Id_Owner=@ownerID
	 DELETE FROM Owner WHERE Owner.ID = @ownerID
	 END
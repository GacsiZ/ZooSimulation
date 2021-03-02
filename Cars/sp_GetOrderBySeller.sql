SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_GetOrderBySeller]
	@SellerName NVARCHAR(220)
AS
BEGIN 
	 -- az utóbbi 1 hónapban minden az adott értékesőhöz tartozó megrendelés 
	 select * from [dbo].[Order] as OD
			join [dbo].[User] as US on US.Id = OD.Saler
		Where Us.Name = @SellerName and OD.OrderDate < DATEADD(month, -1, GETDATE())
END;
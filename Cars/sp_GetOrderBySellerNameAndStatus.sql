SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_GetOrderBySellerNameAndStatus]
	@SellerName NVARCHAR(220)
AS
BEGIN 
	 -- a legalább 2 hónapja megrendelt, de még nem átadott megrendelések, amik az adott  értékesítőhöz tartoznak 

	 select * from [dbo].[Order] as OD
			join [dbo].[User] as US on US.Id = OD.Saler
		Where OD.Status != 5 and Us.Name = @SellerName and OD.OrderDate < DATEADD(month, -2, GETDATE())
END;
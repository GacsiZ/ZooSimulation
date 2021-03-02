SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_GetOrderByAllOrderName]
	@OrderName NVARCHAR(220)
AS
BEGIN 
	 -- az egyes megrendelők előző rendelése 
	 select * from [dbo].[Order] as OD
			join [dbo].[User] as US on US.Id = OD.Saler
		Where Us.Name = @OrderName 
END;
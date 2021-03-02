
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_GetOrderByOrderNameSuccesFullStatus]
	@OrderName NVARCHAR(220)
AS
BEGIN 
	 -- az egyes megrendelők előző sikeres megrendelései 
	 select * from [dbo].[Order] as OD
			join [dbo].[User] as US on US.Id = OD.Saler
			join [dbo].[Order_State] as OS on OS.Id = OD.Status
		Where Us.Name = @OrderName and Os.Id=5
END;
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
	-- Megrendelve->Gy�rt�sban->Sz�ll�t�s alatt->Telephelyen->�tadva �s T�r�lve  
CREATE TABLE [dbo].[Order_State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status_Name] NVARCHAR(200)  not null,
)
GO
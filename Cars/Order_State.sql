SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
	-- Megrendelve->Gyártásban->Szállítás alatt->Telephelyen->Átadva és Törölve  
CREATE TABLE [dbo].[Order_State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status_Name] NVARCHAR(200)  not null,
)
GO
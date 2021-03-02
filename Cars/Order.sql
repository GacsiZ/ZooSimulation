SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Saler] int NOT NULL,
	[Status] int not null,
	[CarTypeId] int not null,
	[OrderDate] datetime not null
)
GO
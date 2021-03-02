SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(300)  NOT NULL,
	[Addres] nvarchar(300) not null,
	[Phone] nvarchar(11) not null,
	[IsSaler] int not null
)
GO
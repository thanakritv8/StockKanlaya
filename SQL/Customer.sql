USE [kanlaya]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 09/04/2017 22:57:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[IdCustomer] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[Transpot] [nvarchar](200) NULL,
	[Tel] [nvarchar](10) NULL,
	[Country] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](5) NULL,
	[Email] [nvarchar](100) NULL,
	[PathPicture] [nvarchar](max) NULL,
	[GroupCus] [nvarchar](100) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[IdCustomer] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


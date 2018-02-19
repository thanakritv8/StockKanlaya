USE [kanlaya]
GO

/****** Object:  Table [dbo].[ListOrder]    Script Date: 09/22/2017 12:57:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ListOrder](
	[IdListOrder] [int] IDENTITY(1,1) NOT NULL,
	[IdOrder] [nvarchar](max) NULL,
	[Amount] [int] NULL,
	[Price] [float] NULL,
	[IdProduct] [nvarchar](50) NULL,
	[NameMenu] [nvarchar](max) NULL,
	[StatusFree] [nvarchar](50) NULL,
 CONSTRAINT [PK_ListOrder] PRIMARY KEY CLUSTERED 
(
	[IdListOrder] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


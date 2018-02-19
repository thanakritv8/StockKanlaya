USE [kanlaya]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 08/29/2017 16:46:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[IdProduct] [nvarchar](10) NOT NULL,
	[NameProduct] [nvarchar](100) NULL,
	[Price_Buy] [float] NULL,
	[Price_Sell] [float] NULL,
	[PathPicture] [nvarchar](max) NULL,
	[Stock] [int] NULL,
	[Unit] [nvarchar](50) NULL,
	[IdCategory] [nvarchar](7) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


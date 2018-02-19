USE [kanlaya]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 10/07/2017 14:35:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[IdCategory] [nvarchar](7) NOT NULL,
	[NameCategory] [nvarchar](100) NULL,
	[Detail] [nvarchar](max) NULL,
	[Brand] [nvarchar](100) NULL,
	[Block] [nvarchar](100) NULL,
	[Position] [nvarchar](100) NULL,
	[Tag] [nvarchar](100) NULL,
	[PathPicture] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[IdCategory] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


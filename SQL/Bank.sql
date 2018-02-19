USE [kanlaya]
GO

/****** Object:  Table [dbo].[Bank]    Script Date: 09/04/2017 19:58:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bank](
	[IdBank] [int] IDENTITY(1,1) NOT NULL,
	[NameBank] [nvarchar](50) NULL,
	[NumBank] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[Branch] [nvarchar](200) NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[IdBank] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


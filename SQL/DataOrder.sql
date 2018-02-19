USE [kanlaya]
GO

/****** Object:  Table [dbo].[DataOrder]    Script Date: 09/22/2017 12:57:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DataOrder](
	[IdOrder] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[TypePay] [nvarchar](50) NULL,
	[TransportPay] [nvarchar](50) NULL,
	[StatusTransport] [nvarchar](50) NULL,
	[Rebate] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Transport] [nvarchar](max) NULL,
	[Country] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](5) NULL,
	[CreateDate] [datetime] NULL,
	[Path] [nvarchar](max) NULL,
	[Bank] [nvarchar](50) NULL,
	[IdCustomer] [int] NULL,
	[DateBank] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


USE [kanlaya]
GO

/****** Object:  Table [dbo].[Lesson]    Script Date: 08/29/2017 16:46:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lesson](
	[IdLesson] [int] IDENTITY(1,1) NOT NULL,
	[Lesson] [nvarchar](50) NULL,
	[LessonDate] [datetime] NULL,
	[LessonPay] [float] NULL,
	[LessonStatus] [nvarchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[IdOrder] [nvarchar](max) NULL,
 CONSTRAINT [PK_Lesson] PRIMARY KEY CLUSTERED 
(
	[IdLesson] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


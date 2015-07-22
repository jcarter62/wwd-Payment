/****** Object:  Table [dbo].[CRDepItem]    Script Date: 7/8/2015 8:20:35 AM ******/
IF OBJECT_ID('dbo.CRDepItem', 'U') IS NOT NULL
	DROP TABLE [dbo].[CRDepItem];

/****** Object:  Table [dbo].[CRDepItem]    Script Date: 7/8/2015 8:20:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CRDepItem](
	[Id] [varchar](40) NOT NULL,
	[IDBatch] [varchar](40) NULL,
	[CRMid] [varchar](40) NULL,
	[Amount] [float] NULL,
	[PayType] [varchar](20) NULL,
	[PayRef] [varchar](20) NULL,
	[State] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



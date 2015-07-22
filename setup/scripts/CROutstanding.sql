/****** Object:  Table [dbo].[CROutstanding]    Script Date: 7/8/2015 8:15:24 AM ******/
IF OBJECT_ID('dbo.CROutstanding', 'U') IS NOT NULL
	DROP TABLE [dbo].[CROutstanding];

/****** Object:  Table [dbo].[CROutstanding]    Script Date: 7/8/2015 8:15:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CROutstanding](
	[ItemGroup] [int] NOT NULL,
	[TranType] [varchar](6) NULL,
	[Description] [varchar](100) NULL,
	[DueDate] [varchar](10) NULL,
	[Amount] [float] NULL,
	[Account] [int] NULL,
	[Invoice] [int] NULL,
	[Session] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



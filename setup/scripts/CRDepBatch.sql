/****** Object:  Table [dbo].[CRDepBatch]    Script Date: 7/8/2015 8:19:12 AM ******/
IF OBJECT_ID('dbo.CRDepBatch', 'U') IS NOT NULL
	DROP TABLE [dbo].[CRDepBatch];


/****** Object:  Table [dbo].[CRDepBatch]    Script Date: 7/8/2015 8:19:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CRDepBatch](
	[Id] [varchar](40) NOT NULL,
	[IDBank] [varchar](20) NULL,
	[State] [varchar](15) NULL,
	[Amount] [float] NULL,
	[Qty] [int] NULL,
	[DepositDate] [datetime] NULL,
	[CDate] [datetime] NULL,
	[CUser] [varchar](50) NULL,
	[UDate] [datetime] NULL,
	[UUser] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-June-18
-- Description:	Set Create User & timestamp on Insert
-- =============================================
CREATE TRIGGER [dbo].[tr_CRDepBatch_Insert]
   ON  [dbo].[CRDepBatch]
   for INSERT
AS 
BEGIN
  SET NOCOUNT ON;
  declare @now datetime;
  declare @uname varchar(128);
  set @now = getdate();
  set @uname = left(dbo.Get_NT_Username(),10);

  update CRDepBatch 
  set cdate  = @now,
    cuser = @uname 
  from CRDepBatch m inner join inserted i on m.id = i.id;

END

GO
-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-June-18
-- Description:	Set Create User & timestamp on Insert
-- =============================================
CREATE TRIGGER [dbo].[tr_CRDepBatch_Update]
   ON  [dbo].[CRDepBatch]
   for Update
AS 
BEGIN
  SET NOCOUNT ON;
  declare @now datetime;
  declare @uname varchar(128);
  set @now = getdate();
  set @uname = left(dbo.Get_NT_Username(),10);

  update CRDepBatch 
  set udate  = @now,
    uuser = @uname 
  from CRDepBatch m inner join inserted i on m.id = i.id;
END

GO

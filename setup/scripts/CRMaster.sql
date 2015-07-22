/****** Object:  Table [dbo].[CRMaster]    Script Date: 7/8/2015 8:08:32 AM ******/
IF OBJECT_ID('dbo.CRMaster', 'U') IS NOT NULL
	DROP TABLE [dbo].[CRMaster];

/****** Object:  Table [dbo].[CRMaster]    Script Date: 7/8/2015 8:08:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CRMaster](
	[Id] [varchar](40) NOT NULL,
	[StateRcv] [varchar](15) NULL,
	[StateGA] [varchar](15) NULL,
	[StateAR] [varchar](15) NULL,
	[SessionId] [varchar](40) NULL,
	[DeliveryName] [varchar](50) NULL,
	[RcptID] [varchar](15) NULL,
	[Amount] [float] NULL,
	[PayType] [varchar](20) NULL,
	[PayRef] [varchar](20) NULL,
	[PayVia] [varchar](20) NULL,
	[Note] [varchar](80) NULL,
	[Postmark] [datetime] NULL,
	[CDate] [datetime] NULL,
	[CUser] [varchar](50) NULL,
	[UDate] [datetime] NULL,
	[UUser] [varchar](50) NULL,
 CONSTRAINT [PK_CRMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) 

GO

SET ANSI_PADDING OFF
GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-May-14
-- Description:	Set Create User & timestamp on Insert
-- =============================================
CREATE TRIGGER [dbo].[tr_CrMaster_Insert]
   ON  [dbo].[CRMaster]
   for INSERT
AS 
BEGIN
  SET NOCOUNT ON;
  declare @now datetime;
  declare @uname varchar(128);
  set @now = getdate();
  set @uname = left(dbo.Get_NT_Username(),10);

  update CRMaster 
  set cdate  = @now,
    cuser = @uname 
  from CRMaster m inner join inserted i on m.id = i.id;

END

GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-May-14
-- Description:	Set Create User & timestamp on Insert
-- =============================================
CREATE TRIGGER [dbo].[tr_CrMaster_Update]
   ON  [dbo].[CRMaster]
   for Update
AS 
BEGIN
  SET NOCOUNT ON;
  declare @now datetime;
  declare @uname varchar(128);
  set @now = getdate();
  set @uname = left(dbo.Get_NT_Username(),10);

  update CRMaster 
  set udate  = @now,
    uuser = @uname 
  from CRMaster m inner join inserted i on m.id = i.id;

END

GO




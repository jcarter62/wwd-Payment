/****** Object:  Table [dbo].[CRDetail]    Script Date: 7/8/2015 8:12:34 AM ******/
IF OBJECT_ID('dbo.CRDetail', 'U') IS NOT NULL
	DROP TABLE [dbo].[CRDetail];

/****** Object:  Table [dbo].[CRDetail]    Script Date: 7/8/2015 8:12:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CRDetail](
	[Id] [varchar](40) NOT NULL,
	[State] [varchar](15) NULL,
	[SessionId] [varchar](40) NULL,
	[CRMid] [varchar](40) NULL,
	[Account] [varchar](20) NULL,
	[Name] [varchar](50) NULL,
	[Amount] [float] NULL,
	[Type] [varchar](20) NULL,
	[Note] [varchar](80) NULL,
	[CDate] [datetime] NULL,
	[CUser] [varchar](50) NULL,
	[UDate] [datetime] NULL,
	[UUser] [varchar](50) NULL,
 CONSTRAINT [PK_CRDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-May-14
-- Description:	Set Create User & timestamp on Insert
-- =============================================
create TRIGGER [dbo].[tr_CrDetail_Insert]
   ON  [dbo].[CRDetail]
   for INSERT
AS 
BEGIN
  SET NOCOUNT ON;
  declare @now datetime;
  declare @uname varchar(128);
  set @now = getdate();
  set @uname = left(dbo.Get_NT_Username(),10);

  update CRDetail 
  set cdate  = @now,
    cuser = @uname 
  from CRDetail m inner join inserted i on m.id = i.id;

END


GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-June-01
-- Description:	Set Update User & timestamp
-- =============================================
CREATE TRIGGER [dbo].[tr_CrDetail_Update]
   ON  [dbo].[CRDetail]
   for Update
AS 
BEGIN
  SET NOCOUNT ON;
  declare @now datetime;
  declare @uname varchar(128);
  set @now = getdate();
  set @uname = left(dbo.Get_NT_Username(),10);

  update CRDetail 
  set udate  = @now,
    uuser = @uname 
  from CRDetail m inner join inserted i on m.id = i.id;

END


GO

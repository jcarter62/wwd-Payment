/****** Object:  Table [dbo].[CRMasterId]    Script Date: 7/8/2015 8:14:03 AM ******/
IF OBJECT_ID('dbo.CRMasterId', 'U') IS NOT NULL
	DROP TABLE [dbo].[CRMasterId];

/****** Object:  Table [dbo].[CRMasterId]    Script Date: 7/8/2015 8:14:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CRMasterId](
	[id] [varchar](40) NOT NULL,
	[RcptId] [varchar](15) NOT NULL,
	[CDate] [datetime] NULL,
	[CUser] [varchar](50) NULL,
 CONSTRAINT [PK_CRMasterId] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-May-29
-- Description:	Set Create User & timestamp on Insert
-- ============================================
Create TRIGGER [dbo].[tr_CrMasterId_Insert]
   ON  [dbo].[CRMasterId]
   for INSERT
AS 
BEGIN
  SET NOCOUNT ON;
  declare @now datetime;
  declare @uname varchar(50);
  set @now = getdate();
  set @uname = left(dbo.Get_NT_Username(),50);

  update CRMasterId 
  set cdate  = @now,
    cuser = @uname 
  from CRMasterId m inner join inserted i on m.id = i.id;

END

GO

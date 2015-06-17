CREATE TABLE [dbo].[CRMaster] (
    [Id]           VARCHAR (40) NOT NULL,
    [State]        VARCHAR (15) NULL,
    [SessionId]    VARCHAR (40) NULL,
    [DeliveryName] VARCHAR (50) NULL,
    [RcptID]       VARCHAR (15) NULL,
    [Amount]       FLOAT (53)   NULL,
    [PayType]      VARCHAR (20) NULL,
    [PayRef]       VARCHAR (20) NULL,
	[PayVia]	   VARCHAR (20) NULL,
    [Note]         VARCHAR (80) NULL,
    [CDate]        DATETIME     NULL,
    [CUser]        VARCHAR (50) NULL,
    [UDate]        DATETIME     NULL,
    [UUser]        VARCHAR (50) NULL,
    CONSTRAINT [PK_CRMaster] PRIMARY KEY CLUSTERED ([Id] ASC)
);


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

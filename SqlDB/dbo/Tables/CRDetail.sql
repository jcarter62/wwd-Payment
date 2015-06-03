CREATE TABLE [dbo].[CRDetail] (
    [Id]        VARCHAR (40) NOT NULL,
    [State]     VARCHAR (15) NULL,
    [SessionId] VARCHAR (40) NULL,
    [CRMid]     VARCHAR (40) NULL,
    [Account]   VARCHAR (20) NULL,
    [Amount]    FLOAT (53)   NULL,
    [Type]      VARCHAR (20) NULL,
    [Note]      VARCHAR (80) NULL,
    [CDate]     DATETIME     NULL,
    [CUser]     VARCHAR (50) NULL,
    [UDate]     DATETIME     NULL,
    [UUser]     VARCHAR (50) NULL,
    CONSTRAINT [PK_CRDetail] PRIMARY KEY CLUSTERED ([Id] ASC)
);


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


CREATE TABLE [dbo].[CRDepBatch]
(
	[Id] VARCHAR(40) NOT NULL PRIMARY KEY, 
    [IDBank] VARCHAR(20) NULL, 
    [State] VARCHAR(15) NULL, 
    [Amount] FLOAT NULL, 
    [Qty] INT NULL, 
    [CDate] DATETIME NULL, 
    [CUser] VARCHAR(50) NULL, 
    [UDate] DATETIME NULL, 
    [UUser] VARCHAR(50) NULL
)

go
-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-June-18
-- Description:	Set Create User & timestamp on Insert
-- =============================================
CREATE TRIGGER tr_CRDepBatch_Insert
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

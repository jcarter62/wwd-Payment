CREATE TABLE [dbo].[CRMasterId] (
    [id]     VARCHAR (40) NOT NULL,
    [RcptId] VARCHAR (15) NOT NULL,
    [CDate]  DATETIME     NULL,
    [CUser]  VARCHAR (50) NULL,
    CONSTRAINT [PK_CRMasterId] PRIMARY KEY CLUSTERED ([id] ASC)
);


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

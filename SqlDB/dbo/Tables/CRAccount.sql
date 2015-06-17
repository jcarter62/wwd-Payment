CREATE TABLE [dbo].[CRAccount](
	[id] [varchar](40) NOT NULL CONSTRAINT [DF_CRAccount_id]  DEFAULT ([dbo].[shortGuid](newid())),
	[AccountNo] [varchar](50) NULL,
	[AccountName] [varchar](50) NULL,
	[AccountNoInt] [int] NULL,
 CONSTRAINT [PK_CRAccount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

go

CREATE TRIGGER tr_CrAccount_Insert
	ON [dbo].[CRAccount]
	FOR INSERT
	AS
	BEGIN
		SET NOCOUNT ON;

		update CRAccount
		set id = dbo.shortGuid(newid())
		from CRAccount a inner join inserted i on a.AccountNo = i.AccountNo
		where a.id is null;
	END
GO



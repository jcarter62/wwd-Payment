CREATE TABLE [dbo].[CRDepItem]
(
	[Id] VARCHAR(40) NOT NULL PRIMARY KEY, 
    [IDBatch] VARCHAR(40) NULL, 
    [CRMid] VARCHAR(40) NULL, 
    [Amount] FLOAT NULL, 
    [PayType] VARCHAR (20) NULL,
    [PayRef] VARCHAR (20) NULL,
    [State] VARCHAR (15) NULL
)
go

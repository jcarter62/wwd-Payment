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
/****** Object:  Table [dbo].[CROutstanding]    Script Date: 7/8/2015 8:15:24 AM ******/
IF OBJECT_ID('dbo.CROutstanding', 'U') IS NOT NULL
	DROP TABLE [dbo].[CROutstanding];

/****** Object:  Table [dbo].[CROutstanding]    Script Date: 7/8/2015 8:15:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CROutstanding](
	[ItemGroup] [int] NOT NULL,
	[TranType] [varchar](6) NULL,
	[Description] [varchar](100) NULL,
	[DueDate] [varchar](10) NULL,
	[Amount] [float] NULL,
	[Account] [int] NULL,
	[Invoice] [int] NULL,
	[Session] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


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
/****** Object:  Table [dbo].[CRDepItem]    Script Date: 7/8/2015 8:20:35 AM ******/
IF OBJECT_ID('dbo.CRDepItem', 'U') IS NOT NULL
	DROP TABLE [dbo].[CRDepItem];

/****** Object:  Table [dbo].[CRDepItem]    Script Date: 7/8/2015 8:20:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CRDepItem](
	[Id] [varchar](40) NOT NULL,
	[IDBatch] [varchar](40) NULL,
	[CRMid] [varchar](40) NULL,
	[Amount] [float] NULL,
	[PayType] [varchar](20) NULL,
	[PayRef] [varchar](20) NULL,
	[State] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  View [dbo].[v_CrReceipt]    Script Date: 7/8/2015 8:44:04 AM ******/
IF OBJECT_ID('dbo.v_crreceipt', 'V') IS NOT NULL
	DROP VIEW [dbo].[v_CrReceipt];
GO

/****** Object:  View [dbo].[v_CrReceipt]    Script Date: 7/8/2015 8:44:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_CrReceipt]
AS
SELECT        m.Id, m.DeliveryName AS mDeliveryName, m.Amount AS mAmount, m.PayRef AS mPayRef, m.PayType AS mPayType, m.PayVia AS mPayVia, m.Note AS mnote, d.Account AS dAccount, d.Name AS dName, 
                         d.Amount AS dAmount, d.Note AS dnote, m.RcptID AS mRcptID, m.CDate AS mCreatedOn, d.Type AS dType
FROM            dbo.CRMaster AS m INNER JOIN
                         dbo.CRDetail AS d ON m.Id = d.CRMid

GO

/****** Object:  View [dbo].[v_TestData1]    Script Date: 7/8/2015 8:49:28 AM ******/
IF OBJECT_ID('dbo.v_TestData1', 'V') IS NOT NULL
	DROP VIEW [dbo].[v_TestData1];
GO

/****** Object:  View [dbo].[v_TestData1]    Script Date: 7/8/2015 8:49:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[v_TestData1] as
select n.NAME_ID as account,n.FullName,
d.BillingType_ID as type,
sum( d.CurrAmount ) as Amount
from name n
inner join ardtl d on n.NAME_ID = d.Name_Id and d.Posted = 1 and d.ActionDate > ( getdate() - 750 )
group by n.NAME_ID,n.FullName, d.BillingType_ID 
having ( sum( d.CurrAmount ) > 0 )

GO


/****** Object:  StoredProcedure [dbo].[sp_Outstanding]    Script Date: 7/8/2015 8:50:36 AM ******/
IF OBJECT_ID('dbo.sp_Outstanding', 'P') IS NOT NULL
	DROP PROCEDURE [dbo].[sp_Outstanding];
GO

/****** Object:  StoredProcedure [dbo].[sp_Outstanding]    Script Date: 7/8/2015 8:50:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2015-June-30
-- Description:	Produce list of outstanding charges for customer/account
-- =============================================
CREATE PROCEDURE [dbo].[sp_Outstanding] ( 
	@Account int = 1,
	@Session varchar(50) = null
)
AS
BEGIN
	SET NOCOUNT ON;

	if not ( @Account is null ) 
	begin

		select d.tranid, space(100) as Parcel, 1 as Ordr, m.Invoice_NO 
		into #tid
		from ardtl d
		inner join armst m on m.armstid = d.armstid 
		where d.name_id = @account and
		(m.CurrAmount > 0) and (d.CurrAmount > 0);

		update #tid 
		set Parcel = 
		case 
		  when d.BillingType_ID = 'Water' then
			' '
		  else 
			' ...'
		end
		from #tid t inner join ardtl d on t.TranId = d.TranId;


		select distinct parcel_id 
		into #OtherLands 
		from PaFields
		where name_id = @account and 
		( getdate() between begindate and isnull(enddate,getdate()) );

		insert into #tid
		select d.TranId, o.Parcel_Id, 2 as Ordr, d.Invoice_NO
		from ardtl d 
		inner join #OtherLands o on d.Parcel_Id = o.Parcel_Id
		and d.BillingType_ID <> 'Water' and d.CurrAmount > 0;


		select 
		  t.Ordr, d.BillingType_ID, t.Parcel, 
		  convert(varchar(10), d.DueDate, 120) as DueDate, 
		  sum(d.curramount) as Amount, d.Name_Id, d.Invoice_NO
		into #list
		from ardtl d
		inner join #tid t on d.TranId = t.TranId
		inner join armst m on m.armstid = d.ARMSTID
		group by t.Ordr, d.BillingType_ID, t.Parcel, d.armstid,  d.DueDate,  d.Name_Id, d.Invoice_NO;

		-- select * from #tid order by parcel 
		drop table #tid ;
		drop table #OtherLands;

		if ( @Session is null ) 
		begin
			select 
				l.Ordr as ItemGroup, 
				l.BillingType_ID as TranType, 
				l.Parcel as Description, 
				l.DueDate, 
				l.Amount, 
				l.Name_Id as Account, 
				l.Invoice_NO as Invoice
				from #list l
			order by Ordr, Parcel, DueDate, Name_Id;
		end
		else 
		begin
		    delete CROutStanding
			where Session = @Session;

		    insert into CROutStanding 
			select 
				l.Ordr as ItemGroup, 
				l.BillingType_ID as TranType, 
				l.Parcel as Description, 
				l.DueDate, 
				l.Amount, 
				l.Name_Id as Account,
				l.Invoice_NO as Invoice,
				@Session as Session
				from #list l
			order by Ordr, Parcel, DueDate, Name_Id;

			declare @numRows int;
			select @numRows = count(*) from CROutstanding where Session = @Session;
			return @numRows;
		end
	end --  if not ( @Account is null ) 
END

GO


IF OBJECT_ID('dbo.CrArMst', 'U') IS NOT NULL
	DROP TABLE [dbo].[CrArMst];

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CrArMst](
	[id] [varchar](40) NOT NULL,
	[ArMstId] [int] NULL,
	[CrMid] [varchar](50) NULL,
	[CrDid] [varchar](50) NULL,
 CONSTRAINT [PK_CRArMst] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

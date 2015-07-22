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



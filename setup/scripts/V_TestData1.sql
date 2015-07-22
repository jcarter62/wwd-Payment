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




create view v_TestData1 as
select n.NAME_ID as account,n.FullName,
d.BillingType_ID as type,
sum( d.CurrAmount ) as Amount
from name n
inner join ardtl d on n.NAME_ID = d.Name_Id and d.Posted = 1 and d.ActionDate > ( getdate() - 750 )
group by n.NAME_ID,n.FullName, d.BillingType_ID 
having ( sum( d.CurrAmount ) > 0 )

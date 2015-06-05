

SELECT [NAME_ID],[FullName]
  FROM [SQL-SVR\MSSQLR2].[wmis_ibm].[dbo].[NAME]

select * from CRAccount;


insert into CRAccount ( AccountNo, AccountName ) 
SELECT convert(varchar(15),[NAME_ID]) as AccountNo ,[FullName] as AccountName
  FROM [SQL-SVR\MSSQLR2].[wmis_ibm].[dbo].[NAME]

update CRAccount
set AccountNoInt = convert(int, AccountNo)
from CRAccount

drop function dbo.get_NT_Username
go

Create FUNCTION dbo.get_NT_Username()
RETURNS varchar(40) AS  
BEGIN 
  declare @NT_Username varchar(128)

  select @NT_Username = (select NT_UserName from master.dbo.sysprocesses where Spid = @@Spid)

  return(@NT_Username)
END



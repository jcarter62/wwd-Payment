DROP FUNCTION [dbo].[shortGuid]
GO

-- =============================================
-- Author:		Jim Carter
-- Create date: 2014-May-28
-- Description:	Create short guid
-- =============================================
create FUNCTION [dbo].[shortGuid](@guid varchar(40))
RETURNS varchar(40)
AS
BEGIN
	DECLARE @Rslt varchar(40);
	set @Rslt = REPLACE(@guid,'-','');
	set @Rslt = LOWER(@Rslt);
	RETURN @rslt;
END

GO

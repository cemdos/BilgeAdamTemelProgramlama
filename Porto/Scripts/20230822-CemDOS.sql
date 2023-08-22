
-- =============================================
-- Author:		cem doþ
-- Create date: 22.08.2023
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE sp_CategoryCtrl_AddCategory(@Name VARCHAR(MAX), @Description VARCHAR(MAX))
AS
BEGIN
	insert into Category ([Name],[Description],Deleted)
	VALUES(@Name,@Description,0)
	select 0 AS ErrorCode
END
GO
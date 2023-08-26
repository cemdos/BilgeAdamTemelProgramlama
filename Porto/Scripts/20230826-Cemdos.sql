CREATE OR ALTER PROCEDURE sp_CategoryCtrl_AddCategory(@Name VARCHAR(MAX), @Description VARCHAR(MAX),@ParentID INT)
AS
BEGIN
	insert into Category ([Name],[Description],[ParentID],Deleted)
	VALUES(@Name,@Description,@ParentID,0)
	select 0 AS ErrorCode
END
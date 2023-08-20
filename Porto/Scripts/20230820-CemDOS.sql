
-- =============================================
-- Author:		cem doþ
-- Create date: 20.08.2023
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE sp_CategoryCtrl_GetCategory
AS
BEGIN
	select 
		ID,
		Name,
		Description,
		ParentID 
	from Category 
	where Deleted = 0
END
GO

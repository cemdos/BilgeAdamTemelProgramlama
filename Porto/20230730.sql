CREATE proc [dbo].[sp_ProductWithCategory](@CategoryId INT=NULL)
as
BEGIN
	--DECLARE @CategoryId INT = 4;
	IF @CategoryId IS NULL
	BEGIN
		select p.* from Product as p
			inner join Category as c
				on p.ID_Category = c.ID
	END
	ELSE
	BEGIN
		with temp_Table AS (
			select ID,Name,Description,ImgUrl,ParentID,0 as AltKategoriSeviyesi from Category 
				where ID = 1
			UNION ALL
			select c.ID,c.Name,c.Description,c.ImgUrl,c.ParentID,t.AltKategoriSeviyesi+1 from Category as c
			INNER JOIN temp_Table as t
				on c.ParentID = t.ID
		)

		,temp_pictures AS (
			select 
				ROW_NUMBER() over (partition by ID_Product order by ID) AS RowNumber,
				ID_Product,
				ImageUrl
			from Picture
		)

		select 
			p.ID,
			p.Name,
			p.Description,
			p.UnitPrice,
			p.Discount,
			p.UnitPriceInStock,
			(select ImageUrl from temp_pictures where ID_Product = p.ID AND RowNumber = 1) AS MasterPic,
			(select ImageUrl from temp_pictures where ID_Product = p.ID AND RowNumber = 2) AS SlavePic
		from Product as p
		inner join temp_Table as t
			on p.ID_Category = t.ID
		where p.Deleted=0
	END
END

GO

CREATE PROCEDURE sp_GetProductDetail(@ProductId INT)
AS
BEGIN
	select 
		p.ID,
		p.Name,
		p.Description,
		p.UnitPrice,
		p.SKU,
		p.UnitPriceInStock,
		c.Name AS CategoryName
	from Product as p
	left join Category as c
		on p.ID_Category = c.ID
			and c.Deleted = 0
	where p.Deleted = 0 AND p.ID=@ProductId
END
GO

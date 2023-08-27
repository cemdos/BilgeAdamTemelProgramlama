create or alter proc sp_ProductCtrl_GetProductList
AS
select 
	p.ID,
	p.Name,
	p.Description,
	p.UnitPrice,
	c.Name AS CategoryName,
	p.Discount,
	p.UnitPrice,
	p.UnitPriceInStock
from Product as p
left join Category as c
	on p.ID_Category = c.ID

-------------------------------------
--INDEX ATMA

CREATE NONCLUSTERED INDEX [NCI-ParentId] ON [dbo].[Category]
(
	[ParentID] ASC
)
INCLUDE([Name],[Description]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)

GO


-- Rastgele kay�t insert edildi.
--INSERT INTO [User] (UserName,[Password],Email,Deleted)
--VALUES('cemdos','1234','dos.cem@gmail.com',0)

-- =============================================
-- Author:		Cem DO�
-- Create date: 19.08.2023
-- Description:	Kullan�c� giri� i�lemleri i�in olusturulan prosed�rd�r.
-- =============================================
CREATE PROCEDURE sp_Login(@Username VARCHAR(50), @Password VARCHAR(50))
AS
BEGIN
	select 
		ID,
		UserName 
	from [User] 
	where 
		UserName = @Username 
		and [Password] = @Password 
END
GO

select * from [User]
-- Rastgele kayýt insert edildi.
--INSERT INTO [User] (UserName,[Password],Email,Deleted)
--VALUES('cemdos','1234','dos.cem@gmail.com',0)

-- =============================================
-- Author:		Cem DOÞ
-- Create date: 19.08.2023
-- Description:	Kullanýcý giriþ iþlemleri için olusturulan prosedürdür.
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

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE dbo.WriteContact
   @FirstName varchar(50),
   @LastName varchar(50),
   @BirthDate varchar(50),
   @Email varchar(50)


AS
BEGIN

	SET NOCOUNT ON;

	if not exists(select * from dbo.Contacts c where c.Email = @Email ) 
		BEGIN
			insert into dbo.Contacts(FirstName, LastName, BirthDate, Email, Created, Changed)
			values (@FirstName, @LastName, @BirthDate , @Email, cast(getdate() as datetime), cast(getdate() as datetime) )
		END

END
GO

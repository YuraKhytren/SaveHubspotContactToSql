use ContactDB

insert into dbo.Contacts(FirstName, LastName, BirthDate, Email, Created, Changed)
values ('Franco', 'Franco', '10.10.1990' , 'Franco@gmail.com', cast(getdate() as datetime), cast(getdate() as datetime) )
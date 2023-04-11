use ContactDB

CREATE TABLE Contacts(
Id int IDENTITY(1,1) primary key not null,
FirstName varchar(50),
LastName varchar(50),
BirthDate varchar(20),
Email varchar(200),
Created datetime,
Changed datetime
)

CREATE TABLE [User](
	ID INT NOT NULL IDENTITY(1,1),
	Name varchar(100),
	Phone varchar(100),
	Mail varchar(50),
	Password varchar(50),

	Primary Key(ID)
);
--DROP TABLE [User];

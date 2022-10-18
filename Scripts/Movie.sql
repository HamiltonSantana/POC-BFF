CREATE TABLE [Movie]
(
	ID INT NOT NULL IDENTITY(1,1),
	Name varchar(20),
	Description varchar(140),
	CategorieID int NOT NULL,

	Primary Key(ID),
	Foreign Key(CategorieID) REFERENCES [Categorie](ID)
);
--DROP TABLE [Movie];

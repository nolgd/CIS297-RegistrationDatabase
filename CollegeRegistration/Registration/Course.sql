CREATE TABLE [dbo].[Course]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Number] NVARCHAR(10) NOT NULL, 
    [Credits] INT NOT NULL, 
    [Department] NCHAR(10) NOT NULL
)

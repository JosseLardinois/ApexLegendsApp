CREATE TABLE [dbo].[Karakter]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [KarakterId] INT NOT NULL, 
    [KarakterSoort] NVARCHAR(50) NOT NULL, 
    [Karakternaam] NVARCHAR(50) NOT NULL
)

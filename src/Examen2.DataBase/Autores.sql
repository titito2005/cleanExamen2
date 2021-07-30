CREATE TABLE [dbo].[Autores]
(
	[IdPublicacion] VARCHAR(10) NOT NULL,
	[IdAutor] VARCHAR (10) NOT NULL,
	[NombreAutor] VARCHAR(50) NOT NULL,
	[Posicion] INT NOT NULL,
	PRIMARY KEY (IdPublicacion, NombreAutor),
	CONSTRAINT [FK_ID_Publicacion] FOREIGN KEY ([IdPublicacion]) REFERENCES [dbo].[Publicacion] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [FK_ID_AutorPublicacion] FOREIGN KEY ([IdAutor]) REFERENCES [dbo].[Investigador] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
)

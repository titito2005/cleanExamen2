CREATE TABLE [dbo].[GrupoInvestigacion]
(
	[Id] VARCHAR(10) NOT NULL,
	[Nombre] VARCHAR(50) NOT NULL,
	[Descripcion] VARCHAR(100) NOT NULL,
	[FechaCreacion] DATE NOT NULL,
	[IdCoordinador] VARCHAR(10) NOT NULL,
	PRIMARY KEY (Id),
	CONSTRAINT [FK_ID_Coordinador] FOREIGN KEY ([IdCoordinador]) REFERENCES [dbo].[Coordinador] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
)

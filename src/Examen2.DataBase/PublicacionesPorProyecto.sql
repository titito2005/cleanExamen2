CREATE TABLE [dbo].[PublicacionesPorProyecto]
(
	[IdGrupo] VARCHAR(10) NOT NULL,
	[IdPublicacion] VARCHAR(10) NOT NULL,
	PRIMARY KEY (IdGrupo, IdPublicacion),
	CONSTRAINT [FK_ID_GrupoPublicacion] FOREIGN KEY ([IdGrupo]) REFERENCES [dbo].[GrupoInvestigacion] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [FK_ID_InvestigadorPublicacion] FOREIGN KEY ([IdPublicacion]) REFERENCES [dbo].[Publicacion] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
)

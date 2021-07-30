CREATE TABLE [dbo].[InvestigadoresPorProyecto]
(
	[IdGrupo] VARCHAR(10) NOT NULL,
	[IdInvestigador] VARCHAR(10) NOT NULL,
	PRIMARY KEY(IdGrupo, IdInvestigador),
	CONSTRAINT [FK_ID_Grupo] FOREIGN KEY ([IdGrupo]) REFERENCES [dbo].[GrupoInvestigacion] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [FK_ID_Investigador] FOREIGN KEY ([IdInvestigador]) REFERENCES [dbo].[Investigador] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
)

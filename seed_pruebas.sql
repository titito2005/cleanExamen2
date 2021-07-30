USE Examen2_DB_Test
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*Agregando datos a tabla estudiante*/
MERGE INTO Coordinador AS Target USING 
    (VALUES 
        ('1111', 'Luis', '2015-12-17', '2018-12-17'),
        ('1112', 'Rosa', '2015-12-17', '2017-12-17'),
        ('1113', 'Ana', '2015-12-17', '2019-12-17'),
        ('1114', 'Juan', '2015-12-17', '2020-12-17')
     )
AS Source ([Id], Nombre, FechaInicio, FechaFinal) 
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN INSERT (Id, Nombre, FechaInicio, FechaFinal) VALUES (Id, Nombre, FechaInicio, FechaFinal);


/*Agregando datos a tabla publicacion*/
MERGE INTO Publicacion AS Target USING 
    (VALUES 
        ('2221', 'Las Naves Espaciales', 'Sobre las naves espaciales...', 'Revista', 'NatGeo'),
        ('2222', 'El mundo', '¿Cómo gira el mundo?', 'Conferencia', 'NatGeo'),
        ('2223', 'El agua', '¿Cómo tomar agua?', 'Conferencia', 'NatGeo'),
        ('2224', 'Los aliens', 'El area 51 es real', 'Revista', 'NatGeo')
     )
AS Source ([Id], Nombre, Resumen, Tipo, Referencia) 
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN INSERT (Id, Nombre, Resumen, Tipo, Referencia)  VALUES (Id, Nombre, Resumen, Tipo, Referencia);

/*Agregando datos a tabla investigador*/
MERGE INTO Investigador AS Target USING 
    (VALUES 
        ('3331', 'Einstein', 'Dr'),
        ('3332', 'Isaac', 'Dr'),
        ('3333', 'Diego', 'Dr'),
        ('3334', 'Platón', 'Dr')
     )
AS Source ([Id], Nombre, MaxGrado) 
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN INSERT (Id, Nombre, MaxGrado)  VALUES (Id, Nombre, MaxGrado);

/*Agregando datos a tabla autores*/
MERGE INTO Autores AS Target USING 
    (VALUES 
        ('2221', '3331', 'Einstein', 1),
        ('2222', '3332', 'Isaac', 1),
        ('2223', '3333', 'Diego', 1),
        ('2224', '3334', 'Platón', 1)
     )
AS Source ([IdPublicacion], IdAutor, NombreAutor, Posicion) 
ON Target.IdPublicacion = Source.IdPublicacion
WHEN NOT MATCHED BY TARGET THEN INSERT (IdPublicacion, IdAutor, NombreAutor, Posicion)  VALUES (IdPublicacion, IdAutor, NombreAutor, Posicion);


/*Agregando datos a tabla GrupoInvestigacion*/
MERGE INTO GrupoInvestigacion AS Target USING 
    (VALUES 
        ('4441', 'Grupo del Espacio', 'Grupo que estudia nuevos planetas habitables', '2018-12-17', '1111'),
        ('4442', 'Grupo del Tiempo', 'Grupo que estudia el paso del tiempo', '2013-12-17', '1112'),
        ('4443', 'Grupo del Agua', 'Grupo que estudia como purificar el agua', '2012-12-17', '1113'),
        ('4444', 'Grupo de los aliens', 'Grupo que estudia la existencia de ET', '2019-12-17', '1114')
     )
AS Source ([Id], Nombre, Descripcion, FechaCreacion, IdCoordinador) 
ON Target.Id = Source.Id
WHEN NOT MATCHED BY TARGET THEN INSERT (Id, Nombre, Descripcion, FechaCreacion, IdCoordinador)   VALUES (Id, Nombre, Descripcion, FechaCreacion, IdCoordinador);

/*Agregando datos a tabla InvestigadoresPorProyecto*/
MERGE INTO InvestigadoresPorProyecto AS Target USING 
    (VALUES 
        ('4441', '3331'),
        ('4442', '3332'),
        ('4443', '3333'),
        ('4444', '3334')
     )
AS Source ([IdGrupo], IdInvestigador) 
ON Target.IdGrupo = Source.IdGrupo
WHEN NOT MATCHED BY TARGET THEN INSERT (IdGrupo, IdInvestigador)  VALUES (IdGrupo, IdInvestigador);


/*Agregando datos a tabla PublicacionesPorProyecto*/
MERGE INTO PublicacionesPorProyecto AS Target USING 
    (VALUES 
        ('4441', '2221'),
        ('4442', '2222'),
        ('4443', '2223'),
        ('4444', '2224')
     )
AS Source ([IdGrupo], IdPublicacion) 
ON Target.IdGrupo = Source.IdGrupo
WHEN NOT MATCHED BY TARGET THEN INSERT (IdGrupo, IdPublicacion)  VALUES (IdGrupo, IdPublicacion);
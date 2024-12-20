USE [WebApi]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Alquiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdVehiculo] [int] NOT NULL,
	[FechaInicio] [smalldatetime] NOT NULL,
	[FechaFin] [smalldatetime] NOT NULL,
	[Observaciones] [varchar](5000) NULL,
 CONSTRAINT [PK_Alquiler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EstadoVehiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_EstadoVehiculo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Marca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Modelo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Vehiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMarca] [int] NOT NULL,
	[IdModelo] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
	[FechaModelo] [smalldatetime] NOT NULL,
	[Observaciones] [varchar](5000) NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Alquiler] ON 

INSERT [Alquiler] ([Id], [IdCliente], [IdVehiculo], [FechaInicio], [FechaFin], [Observaciones]) VALUES (2, 1, 1, CAST(N'2024-12-20T00:00:00' AS SmallDateTime), CAST(N'2024-12-20T02:21:00' AS SmallDateTime), N'asdasdasd222222')
SET IDENTITY_INSERT [Alquiler] OFF
GO
SET IDENTITY_INSERT [Cliente] ON 

INSERT [Cliente] ([Id], [Nombre], [Email]) VALUES (1, N'Ale', N'AleM@pp.com')
INSERT [Cliente] ([Id], [Nombre], [Email]) VALUES (2, N'Juan', N'Juan@pp.com')
INSERT [Cliente] ([Id], [Nombre], [Email]) VALUES (3, N'Nataly', N'nataly@pp.com')
SET IDENTITY_INSERT [Cliente] OFF
GO
SET IDENTITY_INSERT [EstadoVehiculo] ON 

INSERT [EstadoVehiculo] ([Id], [Descripcion]) VALUES (1, N'Libre')
INSERT [EstadoVehiculo] ([Id], [Descripcion]) VALUES (2, N'Reservado')
INSERT [EstadoVehiculo] ([Id], [Descripcion]) VALUES (3, N'Alquilado')
INSERT [EstadoVehiculo] ([Id], [Descripcion]) VALUES (4, N'En Reparacion')
SET IDENTITY_INSERT [EstadoVehiculo] OFF
GO
SET IDENTITY_INSERT [Marca] ON 

INSERT [Marca] ([Id], [Descripcion]) VALUES (1, N'Peugeot')
INSERT [Marca] ([Id], [Descripcion]) VALUES (2, N'Mercedes benz')
INSERT [Marca] ([Id], [Descripcion]) VALUES (3, N'Ford')
SET IDENTITY_INSERT [Marca] OFF
GO
SET IDENTITY_INSERT [Modelo] ON 

INSERT [Modelo] ([Id], [Descripcion]) VALUES (1, N'208')
INSERT [Modelo] ([Id], [Descripcion]) VALUES (2, N'2008')
INSERT [Modelo] ([Id], [Descripcion]) VALUES (3, N'2007')
INSERT [Modelo] ([Id], [Descripcion]) VALUES (4, N'3008')
INSERT [Modelo] ([Id], [Descripcion]) VALUES (5, N'QP')
INSERT [Modelo] ([Id], [Descripcion]) VALUES (6, N'SUV')
INSERT [Modelo] ([Id], [Descripcion]) VALUES (7, N'CONDE')
INSERT [Modelo] ([Id], [Descripcion]) VALUES (8, N'Mustang')
SET IDENTITY_INSERT [Modelo] OFF
GO
SET IDENTITY_INSERT [Vehiculo] ON 

INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (1, 1, 1, 1, CAST(N'2023-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (2, 1, 2, 1, CAST(N'2022-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (3, 1, 3, 1, CAST(N'2020-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (4, 1, 4, 1, CAST(N'2021-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (5, 2, 5, 1, CAST(N'2022-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (6, 2, 6, 1, CAST(N'2020-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (7, 2, 7, 1, CAST(N'2019-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (8, 3, 8, 1, CAST(N'2016-01-01T00:00:00' AS SmallDateTime), NULL)
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (9, 1, 1, 1, CAST(N'2024-12-20T00:00:00' AS SmallDateTime), N'adsadasd')
INSERT [Vehiculo] ([Id], [IdMarca], [IdModelo], [IdEstado], [FechaModelo], [Observaciones]) VALUES (10, 1, 1, 1, CAST(N'2024-12-20T00:00:00' AS SmallDateTime), N'strinsdasdasdasdasdg')
SET IDENTITY_INSERT [Vehiculo] OFF
GO
ALTER TABLE [Vehiculo] ADD  CONSTRAINT [DF_Vehiculo_FechaModelo]  DEFAULT ((2020)) FOR [FechaModelo]
GO
ALTER TABLE [Alquiler]  WITH CHECK ADD  CONSTRAINT [FK_Alquiler_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [Cliente] ([Id])
GO
ALTER TABLE [Alquiler] CHECK CONSTRAINT [FK_Alquiler_Cliente]
GO
ALTER TABLE [Alquiler]  WITH CHECK ADD  CONSTRAINT [FK_Alquiler_Vehiculo] FOREIGN KEY([IdVehiculo])
REFERENCES [Vehiculo] ([Id])
GO
ALTER TABLE [Alquiler] CHECK CONSTRAINT [FK_Alquiler_Vehiculo]
GO
ALTER TABLE [Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_EstadoVehiculo] FOREIGN KEY([IdEstado])
REFERENCES [EstadoVehiculo] ([Id])
GO
ALTER TABLE [Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_EstadoVehiculo]
GO
ALTER TABLE [Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_Marca] FOREIGN KEY([IdMarca])
REFERENCES [Marca] ([Id])
GO
ALTER TABLE [Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_Marca]
GO
ALTER TABLE [Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_Modelo] FOREIGN KEY([IdModelo])
REFERENCES [Modelo] ([Id])
GO
ALTER TABLE [Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_Modelo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Alquiler_Devolver]
@IdVehiculo int,
@Observaciones varchar(5000)
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.


update Vehiculo set
IdEstado = 1 
where Id = @IdVehiculo

update Alquiler set
FechaFin = GETDATE(),
Observaciones = @Observaciones
where IdVehiculo = @IdVehiculo


END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END

SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*

*/
CREATE PROCEDURE [Alquiler_Insert]
@IdCliente int,
@IdVehiculo int,
@FechaInicio smalldatetime, 
@FechaFin smalldatetime,
@Observaciones varchar(5000)
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.

declare @AlquilerValido int, @VehiculoNoApto int

select @AlquilerValido = datediff(day,a.FechaInicio,getdate()) 
from Alquiler a
where a.IdCliente = @IdCliente

select @VehiculoNoApto = count(*) from Vehiculo v where v.Id = @IdVehiculo and v.IdEstado != 1 


-- print '--------------------------------------------------------------- Validaciones --------------------------------------------------------------------------------'

IF ( @AlquilerValido = 0 )
begin
	RAISERROR ('ya existe un alquiler el dia de hoy para ese cliente' ,10, 1 );
	return;
end

IF ( @VehiculoNoApto > 0 )
begin
	RAISERROR ('No es posible alquilar ese vehiculo' ,10, 1 );
	return;
end

--------------------------------------------------------------------------------------------

insert into Alquiler (IdCliente,IdVehiculo,FechaInicio,FechaFin,Observaciones) values ( @IdCliente,@IdVehiculo,@FechaInicio,@FechaFin,@Observaciones)

update Vehiculo set
IdEstado = 3
where Id = @IdVehiculo

END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END

SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Alquiler_List]
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.

Select
a.Id,
a.IdVehiculo,
a.IdCliente,
c.Nombre as Cliente,
mo.Descripcion as Modelo,
ma.Descripcion as Marca,
e.Descripcion as EstadoVehiculo,
a.FechaInicio,
a.FechaFin,
a.Observaciones
From Alquiler a (nolock)
inner join Vehiculo v
	on v.Id = a.IdVehiculo
inner join Modelo mo 
	on v.IdModelo = mo.Id
inner join Marca ma 
	on ma.Id = v.IdMarca
inner join EstadoVehiculo e
	on e.Id = v.IdEstado
inner join Cliente c
	 on  c.Id = a.IdCliente 

END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END


SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Cliente_List]
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.

Select
c.Id,
c.Nombre,
c.Email
From Cliente c (nolock)

END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END


SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Marca_List]
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.

Select
m.Id,
m.Descripcion
From Marca m (nolock)

END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END


SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Modelo_List]
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.

Select
m.Id,
m.Descripcion
From Modelo m (nolock)

END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END


SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Vehiculo_Insert]
@IdMarca int, 
@IdModelo int,
@IdEstado int,
@FechaModelo smalldatetime,
@Observaciones varchar(5000)
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.

insert into Vehiculo (IdMarca,IdModelo,IdEstado,FechaModelo,Observaciones) values (@IdMarca,@IdModelo,@IdEstado,@FechaModelo, @Observaciones ) 

END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END

SET ANSI_NULLS ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Vehiculo_List]
AS
BEGIN
declare @MsgError varchar(100)

BEGIN TRY
SET NOCOUNT ON; --No necesitamos pedirle al motor que cuente los registos.
SET ANSI_NULLS ON; --Habilitamos que interprete los NULLS 
SET QUOTED_IDENTIFIER ON; --Habilitamos Interpretacion de Comillas y comillas dobles validas
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Necesitamos acceder a la info sin que este comiteada
SET ANSI_WARNINGS ON; --no necesitamos que nos avice los warning, variables sin usar, etc...
SET Language Spanish --Seteamos la lengua independiente del server, asi aparece en espanol.

Select
v.Id,
v.IdModelo,
v.IdMarca,
v.IdEstado,
mo.Descripcion as Modelo,
ma.Descripcion as Marca,
e.Descripcion as EstadoVehiculo,
v.FechaModelo,
v.Observaciones
From Vehiculo v (nolock)
inner join Modelo mo
	on mo.Id = v.IdModelo
inner join Marca ma 
	 on ma.Id = v.IdMarca
inner join EstadoVehiculo e 
	on e.Id = v.IdEstado
where datediff(year,v.FechaModelo,GETDATE()) < 5 -- no tenga mas de 5 anos
	
END try

BEGIN CATCH
set @MsgError = ERROR_NUMBER() + ERROR_MESSAGE() + ERROR_SEVERITY() + ERROR_STATE() + ERROR_PROCEDURE() + ERROR_LINE()
RAISERROR(@MsgError, 16, 1);
END CATCH;
END


SET ANSI_NULLS ON
GO

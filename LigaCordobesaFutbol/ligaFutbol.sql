USE [master]
GO
/****** Object:  Database [LigaCordobesaFutbol]    Script Date: 31/8/2023 23:01:53 ******/
CREATE DATABASE [LigaCordobesaFutbol]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LigaCordobesaFutbol', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LigaCordobesaFutbol.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LigaCordobesaFutbol_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LigaCordobesaFutbol_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LigaCordobesaFutbol] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LigaCordobesaFutbol].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LigaCordobesaFutbol] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET ARITHABORT OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET  MULTI_USER 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LigaCordobesaFutbol] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LigaCordobesaFutbol] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LigaCordobesaFutbol] SET QUERY_STORE = ON
GO
ALTER DATABASE [LigaCordobesaFutbol] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LigaCordobesaFutbol]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[iDEquipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NULL,
	[directorTecnico] [int] NOT NULL,
 CONSTRAINT [pkEquipo] PRIMARY KEY CLUSTERED 
(
	[iDEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[persona] [int] NOT NULL,
	[equipo] [int] NOT NULL,
	[camiseta] [int] NULL,
	[posicion] [int] NULL,
	[idJugador] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pkJugador] PRIMARY KEY CLUSTERED 
(
	[idJugador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[dni] [int] NOT NULL,
	[nombreCompleto] [varchar](60) NULL,
	[fechaNac] [datetime] NULL,
 CONSTRAINT [pkPersona] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posiciones]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posiciones](
	[iDPosicion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NULL,
 CONSTRAINT [pkPosicion] PRIMARY KEY CLUSTERED 
(
	[iDPosicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Equipos]  WITH CHECK ADD  CONSTRAINT [fkDT] FOREIGN KEY([directorTecnico])
REFERENCES [dbo].[Personas] ([dni])
GO
ALTER TABLE [dbo].[Equipos] CHECK CONSTRAINT [fkDT]
GO
ALTER TABLE [dbo].[Jugadores]  WITH CHECK ADD  CONSTRAINT [fkEquipo] FOREIGN KEY([equipo])
REFERENCES [dbo].[Equipos] ([iDEquipo])
GO
ALTER TABLE [dbo].[Jugadores] CHECK CONSTRAINT [fkEquipo]
GO
ALTER TABLE [dbo].[Jugadores]  WITH CHECK ADD  CONSTRAINT [fkPersona] FOREIGN KEY([persona])
REFERENCES [dbo].[Personas] ([dni])
GO
ALTER TABLE [dbo].[Jugadores] CHECK CONSTRAINT [fkPersona]
GO
ALTER TABLE [dbo].[Jugadores]  WITH CHECK ADD  CONSTRAINT [fkPosicion] FOREIGN KEY([posicion])
REFERENCES [dbo].[Posiciones] ([iDPosicion])
GO
ALTER TABLE [dbo].[Jugadores] CHECK CONSTRAINT [fkPosicion]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_JUGADORES]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_CONSULTAR_JUGADORES]
as
begin
	select dni, nombreCompleto, fechaNac
	from Jugadores join Personas on Jugadores.persona = Personas.dni
end
GO
/****** Object:  StoredProcedure [dbo].[SP_EQUIPO]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_EQUIPO]
@dt int,
@nombre varchar(40)
AS
begin
	insert into Equipos(nombre,directorTecnico)
	values(@nombre,@dt)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_JUGADOR]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_JUGADOR]
@persona int,
@equipo int,
@camiseta int,
@posicion int
as
begin
	insert into Jugadores(persona,equipo,camiseta,posicion)
	values(@persona,@equipo,@camiseta,@posicion)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_PERSONAS]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create procedure [dbo].[SP_PERSONAS]
  as
begin
	select * from Personas
end
GO
/****** Object:  StoredProcedure [dbo].[SP_POSICIONES]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_POSICIONES]
as
begin
	select * from Posiciones
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_ULTIMO]    Script Date: 31/8/2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ULTIMO]
@last int output
as
begin
	set @last = (select max(iDEquipo) from Equipos)
end
GO
USE [master]
GO
ALTER DATABASE [LigaCordobesaFutbol] SET  READ_WRITE 
GO

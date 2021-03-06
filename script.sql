USE [master]
GO
/****** Object:  Database [siCore]    Script Date: 5.01.2022 20:31:23 ******/
CREATE DATABASE [siCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'siCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\siCore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'siCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\siCore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [siCore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [siCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [siCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [siCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [siCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [siCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [siCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [siCore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [siCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [siCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [siCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [siCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [siCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [siCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [siCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [siCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [siCore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [siCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [siCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [siCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [siCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [siCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [siCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [siCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [siCore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [siCore] SET  MULTI_USER 
GO
ALTER DATABASE [siCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [siCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [siCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [siCore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [siCore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [siCore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [siCore] SET QUERY_STORE = OFF
GO
USE [siCore]
GO
/****** Object:  Table [dbo].[basketbol_19_20_sezon_euro]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_19_20_sezon_euro](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NOT NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
 CONSTRAINT [PK_basketbol_19_20_sezon_euro] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_19_20_sezon_nba_east]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_19_20_sezon_nba_east](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
 CONSTRAINT [PK_basketbol_19_20_sezon_nba_east] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_19_20_sezon_nba_west]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_19_20_sezon_nba_west](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
 CONSTRAINT [PK_basketbol_19_20_sezon_nba_west] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_19_20_sezon_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_19_20_sezon_tr](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
 CONSTRAINT [PK_basketbol_19_20_sezon_tr] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_20_21_sezon_euro]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_20_21_sezon_euro](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
 CONSTRAINT [PK_basketbol_20_21_sezon_euro] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_20_21_sezon_nba_east]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_20_21_sezon_nba_east](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
 CONSTRAINT [PK_basketbol_20_21_sezon_nba_east] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_20_21_sezon_nba_west]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_20_21_sezon_nba_west](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
 CONSTRAINT [PK_basketbol_20_21_sezon_nba_west] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_20_21_sezon_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_20_21_sezon_tr](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
 CONSTRAINT [PK_basketbol_20_21_sezon_tr] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_21_22_sezon_euro]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_21_22_sezon_euro](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
 CONSTRAINT [PK_basketbol_21_22_sezon_euro] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_21_22_sezon_nba_east]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_21_22_sezon_nba_east](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
 CONSTRAINT [PK_basketbol_21_22_sezon_nba_east] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_21_22_sezon_nba_west]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_21_22_sezon_nba_west](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
 CONSTRAINT [PK_basketbol_21_22_sezon_nba_west] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_21_22_sezon_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_21_22_sezon_tr](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_atılan_basket] [int] NULL,
	[takim_yenilen_basket] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
 CONSTRAINT [PK_basketbol_21_22_sezon_tr] PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbol_takimlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbol_takimlar](
	[takim_id] [int] IDENTITY(200,2) NOT NULL,
	[takim_adi] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_19_20_euro]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_19_20_euro](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_19_20_nba_east]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_19_20_nba_east](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_19_20_nba_west]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_19_20_nba_west](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_19_20_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_19_20_tr](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_20_21_euro]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_20_21_euro](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_20_21_nba_east]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_20_21_nba_east](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_20_21_nba_west]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_20_21_nba_west](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_20_21_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_20_21_tr](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_21_22_euro]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_21_22_euro](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_21_22_nba_east]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_21_22_nba_east](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_21_22_nba_west]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_21_22_nba_west](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basketbolcular_21_22_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basketbolcular_21_22_tr](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_basket_ortalamasi] [float] NULL,
	[yapilan_asist_ortalamasi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_19_pilotlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_19_pilotlar](
	[takim_id] [int] NOT NULL,
	[pilot_id] [int] NOT NULL,
	[win] [int] NOT NULL,
	[pole_position] [int] NOT NULL,
	[podium] [int] NULL,
	[puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pilot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_19_takimlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_19_takimlar](
	[takim_id] [int] NOT NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_20_pilotlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_20_pilotlar](
	[takim_id] [int] NOT NULL,
	[pilot_id] [int] NOT NULL,
	[win] [int] NOT NULL,
	[pole_position] [int] NOT NULL,
	[podium] [int] NULL,
	[puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pilot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_20_takimlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_20_takimlar](
	[takim_id] [int] NOT NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_21_pilotlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_21_pilotlar](
	[takim_id] [int] NOT NULL,
	[pilot_id] [int] NOT NULL,
	[win] [int] NOT NULL,
	[pole_position] [int] NOT NULL,
	[podium] [int] NULL,
	[puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pilot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_21_takimlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_21_takimlar](
	[takim_id] [int] NOT NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_pilotlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_pilotlar](
	[pilot_id] [int] NOT NULL,
	[pilot_name] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[pilot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[f1_takimlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f1_takimlar](
	[takim_id] [int] IDENTITY(500,1) NOT NULL,
	[takim_adi] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_19_20_sezon_eng]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_19_20_sezon_eng](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_19_20_sezon_ita]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_19_20_sezon_ita](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_19_20_sezon_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_19_20_sezon_tr](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_20_21_sezon_eng]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_20_21_sezon_eng](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_20_21_sezon_ita]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_20_21_sezon_ita](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_20_21_sezon_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_20_21_sezon_tr](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_21_22_sezon_eng]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_21_22_sezon_eng](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_21_22_sezon_ita]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_21_22_sezon_ita](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_21_22_sezon_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_21_22_sezon_tr](
	[takim_id] [int] NOT NULL,
	[takim_galibiyet] [int] NULL,
	[takim_maglubiyet] [int] NULL,
	[takim_beraberlik] [int] NULL,
	[takim_atılan_gol] [int] NULL,
	[takim_yenilen_gol] [int] NULL,
	[takim_averaj] [int] NULL,
	[takim_puan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbol_takimlar]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbol_takimlar](
	[takim_id] [int] IDENTITY(1,1) NOT NULL,
	[takim_adi] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[takim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_19_20_eng]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_19_20_eng](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_19_20_ita]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_19_20_ita](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_19_20_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_19_20_tr](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_20_21_eng]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_20_21_eng](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_20_21_ita]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_20_21_ita](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_20_21_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_20_21_tr](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_21_22_eng]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_21_22_eng](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_21_22_ita]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_21_22_ita](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[futbolcular_21_22_tr]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[futbolcular_21_22_tr](
	[takim_id] [int] NOT NULL,
	[futbolcu_id] [int] NOT NULL,
	[futbolcu_isim] [nvarchar](30) NOT NULL,
	[atilan_gol] [int] NULL,
	[yapilan_asist] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[futbolcu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_name]    Script Date: 5.01.2022 20:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_name](
	[column1] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro] ADD  CONSTRAINT [DF__basketbol__takim__7A3223E8]  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro] ADD  CONSTRAINT [DF__basketbol__takim__7B264821]  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro] ADD  CONSTRAINT [DF__basketbol__takim__7C1A6C5A]  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro] ADD  CONSTRAINT [DF__basketbol__takim__7D0E9093]  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro] ADD  CONSTRAINT [DF__basketbol__takim__7E02B4CC]  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro] ADD  CONSTRAINT [DF__basketbol__takim__7EF6D905]  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_euro] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_east] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_west] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_atılan_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_yenilen_basket]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_galibiyet]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_maglubiyet]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_beraberlik]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_atılan_gol]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_yenilen_gol]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_averaj]
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr] ADD  DEFAULT ((0)) FOR [takim_puan]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro]  WITH CHECK ADD  CONSTRAINT [FK__basketbol__takim__793DFFAF] FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_euro] CHECK CONSTRAINT [FK__basketbol__takim__793DFFAF]
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_east]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_nba_west]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_19_20_sezon_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_euro]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_east]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_nba_west]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_20_21_sezon_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_euro]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_east]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_nba_west]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbol_21_22_sezon_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_19_20_euro]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_19_20_nba_east]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_19_20_nba_west]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_19_20_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_20_21_euro]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_20_21_nba_east]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_20_21_nba_west]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_20_21_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_21_22_euro]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_21_22_nba_east]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_21_22_nba_west]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[basketbolcular_21_22_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[basketbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[f1_19_pilotlar]  WITH CHECK ADD FOREIGN KEY([pilot_id])
REFERENCES [dbo].[f1_pilotlar] ([pilot_id])
GO
ALTER TABLE [dbo].[f1_19_pilotlar]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[f1_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[f1_19_takimlar]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[f1_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[f1_20_pilotlar]  WITH CHECK ADD FOREIGN KEY([pilot_id])
REFERENCES [dbo].[f1_pilotlar] ([pilot_id])
GO
ALTER TABLE [dbo].[f1_20_pilotlar]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[f1_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[f1_20_takimlar]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[f1_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[f1_21_pilotlar]  WITH CHECK ADD FOREIGN KEY([pilot_id])
REFERENCES [dbo].[f1_pilotlar] ([pilot_id])
GO
ALTER TABLE [dbo].[f1_21_pilotlar]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[f1_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[f1_21_takimlar]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[f1_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_eng]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_ita]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_19_20_sezon_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_eng]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_ita]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_20_21_sezon_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_eng]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_ita]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbol_21_22_sezon_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_19_20_eng]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_19_20_ita]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_19_20_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_20_21_eng]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_20_21_ita]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_20_21_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_21_22_eng]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_21_22_ita]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
ALTER TABLE [dbo].[futbolcular_21_22_tr]  WITH CHECK ADD FOREIGN KEY([takim_id])
REFERENCES [dbo].[futbol_takimlar] ([takim_id])
GO
USE [master]
GO
ALTER DATABASE [siCore] SET  READ_WRITE 
GO

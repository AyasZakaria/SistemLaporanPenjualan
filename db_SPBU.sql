USE [master]
GO
/****** Object:  Database [db_SPBU]    Script Date: 25/10/2018 14:30:26 ******/
CREATE DATABASE [db_SPBU]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_SPBU', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_SPBU.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_SPBU_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_SPBU_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_SPBU] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_SPBU].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_SPBU] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_SPBU] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_SPBU] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_SPBU] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_SPBU] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_SPBU] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_SPBU] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_SPBU] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_SPBU] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_SPBU] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_SPBU] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_SPBU] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_SPBU] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_SPBU] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_SPBU] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_SPBU] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_SPBU] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_SPBU] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_SPBU] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_SPBU] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_SPBU] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_SPBU] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_SPBU] SET RECOVERY FULL 
GO
ALTER DATABASE [db_SPBU] SET  MULTI_USER 
GO
ALTER DATABASE [db_SPBU] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_SPBU] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_SPBU] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_SPBU] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_SPBU] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_SPBU', N'ON'
GO
USE [db_SPBU]
GO
/****** Object:  Table [dbo].[tbl_bbm]    Script Date: 25/10/2018 14:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_bbm](
	[id_bbm] [varchar](15) NOT NULL,
	[nama_bbm] [varchar](20) NULL,
	[harga] [int] NULL,
 CONSTRAINT [PK_tbl_bbm] PRIMARY KEY CLUSTERED 
(
	[id_bbm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_penerimaan]    Script Date: 25/10/2018 14:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_penerimaan](
	[id_penerimaan] [int] NOT NULL,
	[id_bbm] [varchar](15) NULL,
	[tgl_penerimaan] [date] NULL,
	[jumlah_penerimaan] [int] NULL,
 CONSTRAINT [PK_tbl_pemasukan] PRIMARY KEY CLUSTERED 
(
	[id_penerimaan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pengeluaran]    Script Date: 25/10/2018 14:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pengeluaran](
	[id_pengeluaran] [varchar](15) NOT NULL,
	[deskripsi] [varchar](20) NULL,
	[jumlah_pengeluaran] [int] NULL,
 CONSTRAINT [PK_tbl_pengeluaran] PRIMARY KEY CLUSTERED 
(
	[id_pengeluaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pompa]    Script Date: 25/10/2018 14:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pompa](
	[id_pompa] [varchar](15) NOT NULL,
	[nama_pompa] [varchar](50) NULL,
	[id_bbm] [varchar](15) NULL,
 CONSTRAINT [PK_tbl_pompa] PRIMARY KEY CLUSTERED 
(
	[id_pompa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_stock]    Script Date: 25/10/2018 14:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_stock](
	[id_stok] [int] IDENTITY(1,1) NOT NULL,
	[id_bbm] [varchar](15) NULL,
	[tgl_stok] [date] NULL,
	[jumlah_stok] [int] NULL,
 CONSTRAINT [PK_tbl_stock] PRIMARY KEY CLUSTERED 
(
	[id_stok] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_transaksi]    Script Date: 25/10/2018 14:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_transaksi](
	[id_transaksi] [varchar](15) NOT NULL,
	[id_pompa] [varchar](15) NULL,
	[stand_meter_awal] [int] NULL,
	[stand_meter_akhir] [int] NULL,
	[tgl_transaksi] [date] NULL,
 CONSTRAINT [PK_tbl_transaksi] PRIMARY KEY CLUSTERED 
(
	[id_transaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_penerimaan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_penerimaan_tbl_bbm] FOREIGN KEY([id_bbm])
REFERENCES [dbo].[tbl_bbm] ([id_bbm])
GO
ALTER TABLE [dbo].[tbl_penerimaan] CHECK CONSTRAINT [FK_tbl_penerimaan_tbl_bbm]
GO
ALTER TABLE [dbo].[tbl_pompa]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pompa_tbl_bbm] FOREIGN KEY([id_bbm])
REFERENCES [dbo].[tbl_bbm] ([id_bbm])
GO
ALTER TABLE [dbo].[tbl_pompa] CHECK CONSTRAINT [FK_tbl_pompa_tbl_bbm]
GO
ALTER TABLE [dbo].[tbl_stock]  WITH CHECK ADD  CONSTRAINT [FK_tbl_stock_tbl_bbm] FOREIGN KEY([id_bbm])
REFERENCES [dbo].[tbl_bbm] ([id_bbm])
GO
ALTER TABLE [dbo].[tbl_stock] CHECK CONSTRAINT [FK_tbl_stock_tbl_bbm]
GO
ALTER TABLE [dbo].[tbl_transaksi]  WITH CHECK ADD  CONSTRAINT [FK_tbl_transaksi_tbl_pompa] FOREIGN KEY([id_pompa])
REFERENCES [dbo].[tbl_pompa] ([id_pompa])
GO
ALTER TABLE [dbo].[tbl_transaksi] CHECK CONSTRAINT [FK_tbl_transaksi_tbl_pompa]
GO
USE [master]
GO
ALTER DATABASE [db_SPBU] SET  READ_WRITE 
GO

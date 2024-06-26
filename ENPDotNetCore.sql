USE [master]
GO
/****** Object:  Database [ENPDotNetCore]    Script Date: 23-Apr-24 1:17:35 AM ******/
CREATE DATABASE [ENPDotNetCore] ON  PRIMARY 
( NAME = N'ENPDotNetCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ENPDotNetCore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ENPDotNetCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ENPDotNetCore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ENPDotNetCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ENPDotNetCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ENPDotNetCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ENPDotNetCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ENPDotNetCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ENPDotNetCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ENPDotNetCore] SET RECOVERY FULL 
GO
ALTER DATABASE [ENPDotNetCore] SET  MULTI_USER 
GO
ALTER DATABASE [ENPDotNetCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ENPDotNetCore] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ENPDotNetCore', N'ON'
GO
USE [ENPDotNetCore]
GO
/****** Object:  Table [dbo].[Tbl_Blog]    Script Date: 23-Apr-24 1:17:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Blog](
	[BlogId] [int] IDENTITY(1,1) NOT NULL,
	[BlogTitle] [varchar](50) NOT NULL,
	[BlogAuthor] [varchar](50) NOT NULL,
	[BlogContent] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Blog] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Blog] ON 

INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (1, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (2, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (3, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (4, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (5, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (6, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (7, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (8, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (9, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (10, N'Test Title', N'Test Author', N'Test Content')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (11, N'test', N'test', N'test')
INSERT [dbo].[Tbl_Blog] ([BlogId], [BlogTitle], [BlogAuthor], [BlogContent]) VALUES (12, N'title11', N'author11', N'title11')
SET IDENTITY_INSERT [dbo].[Tbl_Blog] OFF
GO
USE [master]
GO
ALTER DATABASE [ENPDotNetCore] SET  READ_WRITE 
GO

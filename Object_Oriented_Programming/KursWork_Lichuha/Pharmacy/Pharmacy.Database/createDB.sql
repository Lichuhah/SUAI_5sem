USE [master]
GO
/****** Object:  Database [PharmacyDB]    Script Date: 30.10.2021 13:37:56 ******/
CREATE DATABASE [PharmacyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PharmacyDB', FILENAME = N'D:\Programms\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PharmacyDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PharmacyDB_log', FILENAME = N'D:\Programms\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PharmacyDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PharmacyDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PharmacyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PharmacyDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PharmacyDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PharmacyDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PharmacyDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PharmacyDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PharmacyDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PharmacyDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PharmacyDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PharmacyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PharmacyDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PharmacyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PharmacyDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PharmacyDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PharmacyDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PharmacyDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PharmacyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PharmacyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PharmacyDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PharmacyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PharmacyDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PharmacyDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PharmacyDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PharmacyDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PharmacyDB] SET  MULTI_USER 
GO
ALTER DATABASE [PharmacyDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PharmacyDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PharmacyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PharmacyDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PharmacyDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PharmacyDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PharmacyDB] SET QUERY_STORE = OFF
GO
USE [PharmacyDB]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryProduct]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryProduct](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Type_ID] [int] NULL,
 CONSTRAINT [PK_CategoryProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormProduct]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormProduct](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Type_ID] [int] NULL,
	[Unit] [nvarchar](10) NULL,
 CONSTRAINT [PK_FormProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacy]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Warehouse_ID] [int] NULL,
 CONSTRAINT [PK_Pharmacy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Category_ID] [int] NULL,
	[NeedRecipe] [bit] NULL,
	[Deleted] [bit] NULL,
	[Brand_ID] [int] NULL,
	[Form_ID] [int] NULL,
	[Price] [int] NULL,
	[Count] [float] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Pharmacy_ID] [int] NULL,
	[Price] [float] NULL,
	[Date] [datetime2](7) NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleItem]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sale_ID] [int] NOT NULL,
	[Product_ID] [int] NULL,
	[Count] [int] NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_Sale_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeProduct]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeProduct](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_TypeProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Pharmacy_ID] [int] NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WareHouse]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WareHouse](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Pharmacy_ID] [int] NULL,
 CONSTRAINT [PK_WareHouse_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WarehouseChanges]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WarehouseChanges](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Warehouse_ID] [int] NULL,
	[Product_ID] [int] NULL,
	[Count] [int] NULL,
	[Type] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Date] [datetime2](7) NULL,
 CONSTRAINT [PK_WarehouseChanges] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WareHouseItem]    Script Date: 30.10.2021 13:37:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WareHouseItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WareHouse_ID] [int] NULL,
	[Product_ID] [int] NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Brand] ON 

INSERT [dbo].[Brand] ([ID], [Name]) VALUES (1, N'Витрум')
INSERT [dbo].[Brand] ([ID], [Name]) VALUES (2, N'Компливит')
INSERT [dbo].[Brand] ([ID], [Name]) VALUES (3, N'Аква Марис')
INSERT [dbo].[Brand] ([ID], [Name]) VALUES (4, N'Adelline')
INSERT [dbo].[Brand] ([ID], [Name]) VALUES (5, N'ФармСтандарт-Уфавита')
SET IDENTITY_INSERT [dbo].[Brand] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryProduct] ON 

INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (1, N'Витамины и минералы', 1)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (2, N'Противопростудные препараты', 1)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (3, N'Против боли и воспаления', 1)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (4, N'Жкт и печень ', 1)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (5, N'Бады', 1)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (6, N'Уход за лицом', 2)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (7, N'Уход за телом', 2)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (8, N'Уход за волосами', 2)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (9, N'Гигиена', 3)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (10, N'Косметика', 3)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (11, N'Измерение давления', 4)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (12, N'Измерение температуры тела', 4)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (13, N'Измерение уровня сахара', 4)
INSERT [dbo].[CategoryProduct] ([ID], [Name], [Type_ID]) VALUES (14, N'Почки и мочевыводящие пути', 1)
SET IDENTITY_INSERT [dbo].[CategoryProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[FormProduct] ON 

INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (1, N'Аэрозоли', 1, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (2, N'Растворы', 1, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (3, N'Таблетки', 1, N'шт.')
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (4, N'Сиропы', 1, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (5, N'Капли', 1, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (6, N'Другое', NULL, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (7, N'Тональное средство', 2, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (8, N'Скраб', 2, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (9, N'Сыворотка', 2, NULL)
INSERT [dbo].[FormProduct] ([ID], [Name], [Type_ID], [Unit]) VALUES (10, N'Маска', 2, NULL)
SET IDENTITY_INSERT [dbo].[FormProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[Pharmacy] ON 

INSERT [dbo].[Pharmacy] ([ID], [Address], [Warehouse_ID]) VALUES (1, N'Улица Колотушкина', 1)
INSERT [dbo].[Pharmacy] ([ID], [Address], [Warehouse_ID]) VALUES (2, N'fsfsfe', 3)
SET IDENTITY_INSERT [dbo].[Pharmacy] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [Name], [Category_ID], [NeedRecipe], [Deleted], [Brand_ID], [Form_ID], [Price], [Count]) VALUES (1, N'Витрум Омега -3 плюс', 1, 0, 0, 1, 3, 1079, 60)
INSERT [dbo].[Product] ([ID], [Name], [Category_ID], [NeedRecipe], [Deleted], [Brand_ID], [Form_ID], [Price], [Count]) VALUES (2, N'Витрум Мемори плюс', 1, 0, 0, 1, 3, 898, 30)
INSERT [dbo].[Product] ([ID], [Name], [Category_ID], [NeedRecipe], [Deleted], [Brand_ID], [Form_ID], [Price], [Count]) VALUES (3, N'Компливит Аква Д3', 1, 0, 0, 2, 5, 289, 20)
INSERT [dbo].[Product] ([ID], [Name], [Category_ID], [NeedRecipe], [Deleted], [Brand_ID], [Form_ID], [Price], [Count]) VALUES (4, N'Аква Марис Классик спрей', 2, 0, 0, 3, 1, 299, 30)
INSERT [dbo].[Product] ([ID], [Name], [Category_ID], [NeedRecipe], [Deleted], [Brand_ID], [Form_ID], [Price], [Count]) VALUES (31, N'Антиква Рапид', 14, 1, 0, 5, 3, 2738, 30)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Sale] ON 

INSERT [dbo].[Sale] ([ID], [Pharmacy_ID], [Price], [Date]) VALUES (1, 1, 1, CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sale] ([ID], [Pharmacy_ID], [Price], [Date]) VALUES (2, 1, 1, CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sale] ([ID], [Pharmacy_ID], [Price], [Date]) VALUES (11, NULL, 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sale] ([ID], [Pharmacy_ID], [Price], [Date]) VALUES (12, NULL, 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sale] ([ID], [Pharmacy_ID], [Price], [Date]) VALUES (13, NULL, 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sale] ([ID], [Pharmacy_ID], [Price], [Date]) VALUES (16, NULL, 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sale] ([ID], [Pharmacy_ID], [Price], [Date]) VALUES (1014, NULL, 6330, CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Sale] OFF
GO
SET IDENTITY_INSERT [dbo].[SaleItem] ON 

INSERT [dbo].[SaleItem] ([ID], [Sale_ID], [Product_ID], [Count], [Price]) VALUES (1, 1, 1, 1, 1)
INSERT [dbo].[SaleItem] ([ID], [Sale_ID], [Product_ID], [Count], [Price]) VALUES (2, 2, 1, 1, 1)
INSERT [dbo].[SaleItem] ([ID], [Sale_ID], [Product_ID], [Count], [Price]) VALUES (3, 2, 2, 1, 1)
INSERT [dbo].[SaleItem] ([ID], [Sale_ID], [Product_ID], [Count], [Price]) VALUES (6, 16, 1, 1, 0)
INSERT [dbo].[SaleItem] ([ID], [Sale_ID], [Product_ID], [Count], [Price]) VALUES (7, 16, 2, 1, 0)
INSERT [dbo].[SaleItem] ([ID], [Sale_ID], [Product_ID], [Count], [Price]) VALUES (1004, 1014, 31, 1, 2738)
INSERT [dbo].[SaleItem] ([ID], [Sale_ID], [Product_ID], [Count], [Price]) VALUES (1005, 1014, 2, 2, 1796)
SET IDENTITY_INSERT [dbo].[SaleItem] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeProduct] ON 

INSERT [dbo].[TypeProduct] ([ID], [Name]) VALUES (1, N'Лекарства и БАДы')
INSERT [dbo].[TypeProduct] ([ID], [Name]) VALUES (2, N'Активная косметика')
INSERT [dbo].[TypeProduct] ([ID], [Name]) VALUES (3, N'Красота и здоровье')
INSERT [dbo].[TypeProduct] ([ID], [Name]) VALUES (4, N'Медицинские приборы')
SET IDENTITY_INSERT [dbo].[TypeProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Login], [Password], [Name], [Pharmacy_ID], [Role]) VALUES (1, N'1', N'1', N'Admin     ', NULL, 0)
INSERT [dbo].[User] ([ID], [Login], [Password], [Name], [Pharmacy_ID], [Role]) VALUES (2, N'2', N'1', N'Admin1', 1, 0)
INSERT [dbo].[User] ([ID], [Login], [Password], [Name], [Pharmacy_ID], [Role]) VALUES (3, N'3', N'1', N'man', 1, 1)
INSERT [dbo].[User] ([ID], [Login], [Password], [Name], [Pharmacy_ID], [Role]) VALUES (1002, N'c', N'1', N'Кассир', NULL, 2)
INSERT [dbo].[User] ([ID], [Login], [Password], [Name], [Pharmacy_ID], [Role]) VALUES (1003, N'w', N'1', N'Склад', NULL, 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[WareHouse] ON 

INSERT [dbo].[WareHouse] ([ID], [Pharmacy_ID]) VALUES (1, 1)
INSERT [dbo].[WareHouse] ([ID], [Pharmacy_ID]) VALUES (3, 2)
SET IDENTITY_INSERT [dbo].[WareHouse] OFF
GO
SET IDENTITY_INSERT [dbo].[WarehouseChanges] ON 

INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (1, 1, 1, 15, N'Зачисление', N'тест', CAST(N'2021-10-04T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (2, 1, 1, -5, N'Списание', N'тест', CAST(N'2021-04-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (3, 1, 2, 15, N'Зачисление', N'тест', CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (8, NULL, 1, 5, N'Зачисление', N'', CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (9, NULL, 1, -5, N'Списание', N'', CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (10, NULL, 3, 1, N'Зачисление', N'тест', CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (11, NULL, 1, -1, N'Списание', N'', CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (12, NULL, 1, 1, N'Зачисление', N'', CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (13, NULL, 3, -1, N'Списание', N'', CAST(N'2021-10-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (14, NULL, 31, 10, N'Зачисление', N'тест', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WarehouseChanges] ([ID], [Warehouse_ID], [Product_ID], [Count], [Type], [Description], [Date]) VALUES (15, NULL, 31, -4, N'Списание', N'тест', CAST(N'2021-10-09T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[WarehouseChanges] OFF
GO
SET IDENTITY_INSERT [dbo].[WareHouseItem] ON 

INSERT [dbo].[WareHouseItem] ([ID], [WareHouse_ID], [Product_ID], [Count]) VALUES (1, 1, 1, 3)
INSERT [dbo].[WareHouseItem] ([ID], [WareHouse_ID], [Product_ID], [Count]) VALUES (2, 1, 2, 8)
INSERT [dbo].[WareHouseItem] ([ID], [WareHouse_ID], [Product_ID], [Count]) VALUES (4, NULL, 31, 5)
SET IDENTITY_INSERT [dbo].[WareHouseItem] OFF
GO
ALTER TABLE [dbo].[CategoryProduct]  WITH CHECK ADD  CONSTRAINT [FK_CategoryProduct_TypeProduct] FOREIGN KEY([Type_ID])
REFERENCES [dbo].[TypeProduct] ([ID])
GO
ALTER TABLE [dbo].[CategoryProduct] CHECK CONSTRAINT [FK_CategoryProduct_TypeProduct]
GO
ALTER TABLE [dbo].[FormProduct]  WITH CHECK ADD  CONSTRAINT [FK_FormProduct_TypeProduct] FOREIGN KEY([Type_ID])
REFERENCES [dbo].[TypeProduct] ([ID])
GO
ALTER TABLE [dbo].[FormProduct] CHECK CONSTRAINT [FK_FormProduct_TypeProduct]
GO
ALTER TABLE [dbo].[Pharmacy]  WITH CHECK ADD  CONSTRAINT [FK_Pharmacy_WareHouse] FOREIGN KEY([Warehouse_ID])
REFERENCES [dbo].[WareHouse] ([ID])
GO
ALTER TABLE [dbo].[Pharmacy] CHECK CONSTRAINT [FK_Pharmacy_WareHouse]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Brand] FOREIGN KEY([Brand_ID])
REFERENCES [dbo].[Brand] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Brand]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_CategoryProduct] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[CategoryProduct] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_CategoryProduct]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_FormProduct] FOREIGN KEY([Form_ID])
REFERENCES [dbo].[FormProduct] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_FormProduct]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Pharmacy] FOREIGN KEY([Pharmacy_ID])
REFERENCES [dbo].[Pharmacy] ([ID])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Pharmacy]
GO
ALTER TABLE [dbo].[SaleItem]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Product_Product] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[SaleItem] CHECK CONSTRAINT [FK_Sale_Product_Product]
GO
ALTER TABLE [dbo].[SaleItem]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Product_Sale] FOREIGN KEY([Sale_ID])
REFERENCES [dbo].[Sale] ([ID])
GO
ALTER TABLE [dbo].[SaleItem] CHECK CONSTRAINT [FK_Sale_Product_Sale]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Pharmacy] FOREIGN KEY([Pharmacy_ID])
REFERENCES [dbo].[Pharmacy] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Pharmacy]
GO
ALTER TABLE [dbo].[WareHouse]  WITH CHECK ADD  CONSTRAINT [FK_WareHouse_Pharmacy1] FOREIGN KEY([Pharmacy_ID])
REFERENCES [dbo].[Pharmacy] ([ID])
GO
ALTER TABLE [dbo].[WareHouse] CHECK CONSTRAINT [FK_WareHouse_Pharmacy1]
GO
ALTER TABLE [dbo].[WarehouseChanges]  WITH CHECK ADD  CONSTRAINT [FK_WarehouseChanges_Product] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[WarehouseChanges] CHECK CONSTRAINT [FK_WarehouseChanges_Product]
GO
ALTER TABLE [dbo].[WarehouseChanges]  WITH CHECK ADD  CONSTRAINT [FK_WarehouseChanges_WareHouse1] FOREIGN KEY([Warehouse_ID])
REFERENCES [dbo].[WareHouse] ([ID])
GO
ALTER TABLE [dbo].[WarehouseChanges] CHECK CONSTRAINT [FK_WarehouseChanges_WareHouse1]
GO
ALTER TABLE [dbo].[WareHouseItem]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Product] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[WareHouseItem] CHECK CONSTRAINT [FK_Warehouse_Product]
GO
ALTER TABLE [dbo].[WareHouseItem]  WITH CHECK ADD  CONSTRAINT [FK_WareHouseItem_WareHouse] FOREIGN KEY([WareHouse_ID])
REFERENCES [dbo].[WareHouse] ([ID])
GO
ALTER TABLE [dbo].[WareHouseItem] CHECK CONSTRAINT [FK_WareHouseItem_WareHouse]
GO
USE [master]
GO
ALTER DATABASE [PharmacyDB] SET  READ_WRITE 
GO

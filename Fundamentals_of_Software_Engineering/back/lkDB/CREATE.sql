USE [master]
GO
/****** Object:  Database [LkBD]    Script Date: 03.10.2021 22:27:24 ******/
CREATE DATABASE [LkBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LkBD', FILENAME = N'D:\Programms\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LkBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 0)
 LOG ON 
( NAME = N'LkBD_log', FILENAME = N'D:\Programms\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LkBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 0)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LkBD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LkBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LkBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LkBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LkBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LkBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LkBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [LkBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LkBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LkBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LkBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LkBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LkBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LkBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LkBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LkBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LkBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LkBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LkBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LkBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LkBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LkBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LkBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LkBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LkBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LkBD] SET  MULTI_USER 
GO
ALTER DATABASE [LkBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LkBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LkBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LkBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LkBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LkBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LkBD] SET QUERY_STORE = OFF
GO
USE [LkBD]
GO
/****** Object:  Table [dbo].[Discipline]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discipline](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Exam] [int] NULL,
	[Hours] [int] NULL,
 CONSTRAINT [PK_Discipline] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](10) NULL,
	[Course] [int] NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group_Discipline]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_Discipline](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Discipline_ID] [int] NULL,
	[Group_ID] [int] NULL,
 CONSTRAINT [PK_Group_Discipline] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group_Speciality]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_Speciality](
	[ID] [nchar](10) NOT NULL,
	[Speciality_ID] [int] NULL,
	[Group_ID] [int] NULL,
 CONSTRAINT [PK_Group_Speciality] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassTask]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassTask](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaskUser_ID] [int] NULL,
	[Answer] [nvarchar](max) NULL,
	[Date] [date] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_PassTask] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Speciality]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Speciality](
	[iD] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Education] [int] NULL,
 CONSTRAINT [PK_Speciality] PRIMARY KEY CLUSTERED 
(
	[iD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Group_Discipline_ID] [int] NULL,
	[DeadLine] [date] NULL,
	[MaxMark] [int] NULL,
	[Name] [nvarchar](30) NULL,
	[Number] [int] NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task_User]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Task_ID] [int] NULL,
	[User_ID] [int] NULL,
	[Mark] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Task_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](15) NULL,
	[Password] [nvarchar](20) NULL,
	[UserRole_ID] [int] NULL,
	[PhoneNumber] [nvarchar](12) NULL,
	[Mail] [nvarchar](30) NULL,
	[Group_ID] [int] NULL,
	[Fullname_ID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Fullname]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Fullname](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[OtherName] [nvarchar](20) NULL,
 CONSTRAINT [PK_User_Fullname] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 03.10.2021 22:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Discipline] ON 

INSERT [dbo].[Discipline] ([ID], [Name], [Exam], [Hours]) VALUES (1, N'ППС', NULL, NULL)
INSERT [dbo].[Discipline] ([ID], [Name], [Exam], [Hours]) VALUES (2, N'Физра', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Discipline] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([ID], [Number], [Course]) VALUES (1, N'4932', NULL)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Group_Discipline] ON 

INSERT [dbo].[Group_Discipline] ([ID], [Discipline_ID], [Group_ID]) VALUES (1, 1, 1)
INSERT [dbo].[Group_Discipline] ([ID], [Discipline_ID], [Group_ID]) VALUES (2, 2, 1)
SET IDENTITY_INSERT [dbo].[Group_Discipline] OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON 

INSERT [dbo].[Task] ([ID], [Group_Discipline_ID], [DeadLine], [MaxMark], [Name], [Number], [Description]) VALUES (1, 1, CAST(N'2021-10-30' AS Date), 10, N'ДОКУМЕНТАЦИЯ СУКА', NULL, NULL)
INSERT [dbo].[Task] ([ID], [Group_Discipline_ID], [DeadLine], [MaxMark], [Name], [Number], [Description]) VALUES (2, 1, CAST(N'2021-10-31' AS Date), 10, N'ЕЩЕ ДОКУМЕНТАЦИЯ СУКА', NULL, NULL)
INSERT [dbo].[Task] ([ID], [Group_Discipline_ID], [DeadLine], [MaxMark], [Name], [Number], [Description]) VALUES (3, 2, CAST(N'2030-01-01' AS Date), 1, N'Ну сходи на физру уже(((', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
SET IDENTITY_INSERT [dbo].[Task_User] ON 

INSERT [dbo].[Task_User] ([ID], [Task_ID], [User_ID], [Mark], [Status]) VALUES (1, 1, 4, 9, 1)
INSERT [dbo].[Task_User] ([ID], [Task_ID], [User_ID], [Mark], [Status]) VALUES (2, 2, 4, 0, 0)
INSERT [dbo].[Task_User] ([ID], [Task_ID], [User_ID], [Mark], [Status]) VALUES (3, 3, 4, 0, 0)
SET IDENTITY_INSERT [dbo].[Task_User] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Login], [Password], [UserRole_ID], [PhoneNumber], [Mail], [Group_ID], [Fullname_ID]) VALUES (1, N'1', N'qwerty', NULL, N'88005553535', N'a@mail.ru', NULL, NULL)
INSERT [dbo].[User] ([ID], [Login], [Password], [UserRole_ID], [PhoneNumber], [Mail], [Group_ID], [Fullname_ID]) VALUES (2, N'2', N'qwerty', NULL, N'88005553535', N'b@yandex.ru', NULL, NULL)
INSERT [dbo].[User] ([ID], [Login], [Password], [UserRole_ID], [PhoneNumber], [Mail], [Group_ID], [Fullname_ID]) VALUES (3, N'3', N'qwerty', NULL, N'88005553535', N'test@test.ru', NULL, NULL)
INSERT [dbo].[User] ([ID], [Login], [Password], [UserRole_ID], [PhoneNumber], [Mail], [Group_ID], [Fullname_ID]) VALUES (4, N'Student', N'1', 1, N'88005553531', N'loh@suai.ru', 1, 4)
INSERT [dbo].[User] ([ID], [Login], [Password], [UserRole_ID], [PhoneNumber], [Mail], [Group_ID], [Fullname_ID]) VALUES (5, N'Lecture', N'1', 2, N'88005553532', N'fattahova@suai.ru', NULL, NULL)
INSERT [dbo].[User] ([ID], [Login], [Password], [UserRole_ID], [PhoneNumber], [Mail], [Group_ID], [Fullname_ID]) VALUES (6, N'Deanat', N'1', 3, N'88005553533', N'b@gmail.ru', NULL, NULL)
INSERT [dbo].[User] ([ID], [Login], [Password], [UserRole_ID], [PhoneNumber], [Mail], [Group_ID], [Fullname_ID]) VALUES (8, N'None', N'1', 5, N'88005553534', N'v@mail.ru', NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[User_Fullname] ON 

INSERT [dbo].[User_Fullname] ([ID], [Name], [LastName], [OtherName]) VALUES (1, N'Test', N'Test', N'Test')
INSERT [dbo].[User_Fullname] ([ID], [Name], [LastName], [OtherName]) VALUES (2, NULL, NULL, NULL)
INSERT [dbo].[User_Fullname] ([ID], [Name], [LastName], [OtherName]) VALUES (3, NULL, NULL, NULL)
INSERT [dbo].[User_Fullname] ([ID], [Name], [LastName], [OtherName]) VALUES (4, N'Студент', N'Студентов', N'Студентович')
INSERT [dbo].[User_Fullname] ([ID], [Name], [LastName], [OtherName]) VALUES (5, N'а', N'а', N'а')
INSERT [dbo].[User_Fullname] ([ID], [Name], [LastName], [OtherName]) VALUES (6, N'б', N'б', N'бб')
INSERT [dbo].[User_Fullname] ([ID], [Name], [LastName], [OtherName]) VALUES (7, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User_Fullname] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([ID], [Name]) VALUES (1, N'STUDENT   ')
INSERT [dbo].[UserRole] ([ID], [Name]) VALUES (2, N'LECTURE   ')
INSERT [dbo].[UserRole] ([ID], [Name]) VALUES (3, N'DEANAT    ')
INSERT [dbo].[UserRole] ([ID], [Name]) VALUES (5, NULL)
SET IDENTITY_INSERT [dbo].[UserRole] OFF
GO
ALTER TABLE [dbo].[Group_Discipline]  WITH CHECK ADD  CONSTRAINT [FK_Group_Discipline_Discipline1] FOREIGN KEY([Discipline_ID])
REFERENCES [dbo].[Discipline] ([ID])
GO
ALTER TABLE [dbo].[Group_Discipline] CHECK CONSTRAINT [FK_Group_Discipline_Discipline1]
GO
ALTER TABLE [dbo].[Group_Discipline]  WITH CHECK ADD  CONSTRAINT [FK_Group_Discipline_Group1] FOREIGN KEY([Group_ID])
REFERENCES [dbo].[Group] ([ID])
GO
ALTER TABLE [dbo].[Group_Discipline] CHECK CONSTRAINT [FK_Group_Discipline_Group1]
GO
ALTER TABLE [dbo].[Group_Speciality]  WITH CHECK ADD  CONSTRAINT [FK_Group_Speciality_Group] FOREIGN KEY([Group_ID])
REFERENCES [dbo].[Group] ([ID])
GO
ALTER TABLE [dbo].[Group_Speciality] CHECK CONSTRAINT [FK_Group_Speciality_Group]
GO
ALTER TABLE [dbo].[Group_Speciality]  WITH CHECK ADD  CONSTRAINT [FK_Group_Speciality_Speciality] FOREIGN KEY([Speciality_ID])
REFERENCES [dbo].[Speciality] ([iD])
GO
ALTER TABLE [dbo].[Group_Speciality] CHECK CONSTRAINT [FK_Group_Speciality_Speciality]
GO
ALTER TABLE [dbo].[PassTask]  WITH CHECK ADD  CONSTRAINT [FK_PassTask_Task_User] FOREIGN KEY([TaskUser_ID])
REFERENCES [dbo].[Task_User] ([ID])
GO
ALTER TABLE [dbo].[PassTask] CHECK CONSTRAINT [FK_PassTask_Task_User]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Group_Discipline] FOREIGN KEY([Group_Discipline_ID])
REFERENCES [dbo].[Group_Discipline] ([ID])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Group_Discipline]
GO
ALTER TABLE [dbo].[Task_User]  WITH CHECK ADD  CONSTRAINT [FK_Task_User_Task] FOREIGN KEY([Task_ID])
REFERENCES [dbo].[Task] ([ID])
GO
ALTER TABLE [dbo].[Task_User] CHECK CONSTRAINT [FK_Task_User_Task]
GO
ALTER TABLE [dbo].[Task_User]  WITH CHECK ADD  CONSTRAINT [FK_Task_User_User] FOREIGN KEY([User_ID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Task_User] CHECK CONSTRAINT [FK_Task_User_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Group] FOREIGN KEY([Group_ID])
REFERENCES [dbo].[Group] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Group]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_User_Fullname] FOREIGN KEY([Fullname_ID])
REFERENCES [dbo].[User_Fullname] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_User_Fullname]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserRole] FOREIGN KEY([UserRole_ID])
REFERENCES [dbo].[UserRole] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserRole]
GO
USE [master]
GO
ALTER DATABASE [LkBD] SET  READ_WRITE 
GO

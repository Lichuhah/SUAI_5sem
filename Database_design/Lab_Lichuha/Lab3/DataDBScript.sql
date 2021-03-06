SET IDENTITY_INSERT [dbo].[Line] ON 

INSERT [dbo].[Line] ([ID], [Number]) VALUES (1, 1)
INSERT [dbo].[Line] ([ID], [Number]) VALUES (2, 2)
INSERT [dbo].[Line] ([ID], [Number]) VALUES (3, 3)
SET IDENTITY_INSERT [dbo].[Line] OFF
GO
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([ID], [Name]) VALUES (1, N'Вывоз мусора')
INSERT [dbo].[Payment] ([ID], [Name]) VALUES (2, N'Охрана')
INSERT [dbo].[Payment] ([ID], [Name]) VALUES (3, N'Шторы в школу')
SET IDENTITY_INSERT [dbo].[Payment] OFF
GO
SET IDENTITY_INSERT [dbo].[Owner] ON 

INSERT [dbo].[Owner] ([ID], [Name], [Surname], [Midname], [Birthday]) VALUES (1, N'Александра', N'Лисина', N'Сергеевна', CAST(N'1958-01-11' AS Date))
INSERT [dbo].[Owner] ([ID], [Name], [Surname], [Midname], [Birthday]) VALUES (2, N'Дмитрий', N'Ильин', N'Евгеньевич', CAST(N'1984-08-23' AS Date))
SET IDENTITY_INSERT [dbo].[Owner] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeBuilding] ON 

INSERT [dbo].[TypeBuilding] ([ID], [Name]) VALUES (1, N'Жилое строение')
INSERT [dbo].[TypeBuilding] ([ID], [Name]) VALUES (2, N'Баня')
INSERT [dbo].[TypeBuilding] ([ID], [Name]) VALUES (3, N'Туалет')
INSERT [dbo].[TypeBuilding] ([ID], [Name]) VALUES (4, N'Гараж')
SET IDENTITY_INSERT [dbo].[TypeBuilding] OFF
GO
SET IDENTITY_INSERT [dbo].[Area] ON 

INSERT [dbo].[Area] ([Number], [ID_Line], [Size], [Price]) VALUES (1, 1, 10, 500000)
INSERT [dbo].[Area] ([Number], [ID_Line], [Size], [Price]) VALUES (2, 1, 15, 700000)
INSERT [dbo].[Area] ([Number], [ID_Line], [Size], [Price]) VALUES (3, 2, 10, 500000)
SET IDENTITY_INSERT [dbo].[Area] OFF
GO
SET IDENTITY_INSERT [dbo].[Building] ON 

INSERT [dbo].[Building] ([ID], [Number_Area], [ID_TypeBuilding], [Size], [Price]) VALUES (1, 1, 1, 50, 600000)
INSERT [dbo].[Building] ([ID], [Number_Area], [ID_TypeBuilding], [Size], [Price]) VALUES (2, 1, 2, 30, 200000)
INSERT [dbo].[Building] ([ID], [Number_Area], [ID_TypeBuilding], [Size], [Price]) VALUES (3, 1, 3, 4, 30000)
INSERT [dbo].[Building] ([ID], [Number_Area], [ID_TypeBuilding], [Size], [Price]) VALUES (4, 2, 1, 80, 1800000)
INSERT [dbo].[Building] ([ID], [Number_Area], [ID_TypeBuilding], [Size], [Price]) VALUES (5, 3, 1, 60, 1000000)
INSERT [dbo].[Building] ([ID], [Number_Area], [ID_TypeBuilding], [Size], [Price]) VALUES (7, 3, 3, 6, 60000)
SET IDENTITY_INSERT [dbo].[Building] OFF
GO

INSERT [dbo].[Owner_Area] ([Number_Area], [Id_Owner]) VALUES (1, 1)
INSERT [dbo].[Owner_Area] ([Number_Area], [Id_Owner]) VALUES (2, 2)
INSERT [dbo].[Owner_Area] ([Number_Area], [Id_Owner]) VALUES (3, 2)
GO
SET IDENTITY_INSERT [dbo].[Owner_Payment] ON 

INSERT [dbo].[Owner_Payment] ([Number], [ID_Owner], [ID_Payment], [Amount]) VALUES (1, 1, 1, 500)
INSERT [dbo].[Owner_Payment] ([Number], [ID_Owner], [ID_Payment], [Amount]) VALUES (2, 1, 2, 700)
SET IDENTITY_INSERT [dbo].[Owner_Payment] OFF
GO




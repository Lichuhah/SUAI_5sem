CREATE TABLE Building (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Number_Area] [int] NOT NULL,
[ID_TypeBuilding] [int] NOT NULL,
[Size] [float],
[Price] [float]
)

CREATE TABLE TypeBuilding (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Name] [nvarchar](50) NOT NULL,
)

CREATE TABLE Area (
[Number] [int] PRIMARY KEY IDENTITY (1,1),
[ID_Line] [int] NOT NULL,
[Size] [float],
[Price] [float]
)

CREATE TABLE Line (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Number] [int] NOT NULL,
)

ALTER TABLE Building WITH CHECK ADD FOREIGN KEY (ID_TypeBuilding) REFERENCES TypeBuilding (ID)
ALTER TABLE Building WITH CHECK ADD FOREIGN KEY (Number_Area) REFERENCES Area (Number)
ALTER TABLE Area WITH CHECK ADD FOREIGN KEY (ID_Line) REFERENCES Line (ID)

CREATE TABLE Owner (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Name] [nvarchar](50) NOT NULL,
[Surname] [nvarchar](50),
[Midname] [nvarchar](50),
[Birthday] [date]
)

CREATE TABLE Payment (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Name] [nvarchar](50) NOT NULL,
)

CREATE TABLE Owner_Payment (
[Number] [int] PRIMARY KEY IDENTITY (1,1),
[ID_Owner] [int] NOT NULL,
[ID_Payment] [int] NOT NULL,
[Amount] [int],
)

ALTER TABLE Owner_Payment WITH CHECK ADD FOREIGN KEY (ID_Owner) REFERENCES Owner (ID)
ALTER TABLE Owner_Payment WITH CHECK ADD FOREIGN KEY (ID_Payment) REFERENCES Payment (ID)

CREATE TABLE Owner_Area (
[Number_Area] [int] NOT NULL,
[Id_Owner] [int] NOT NULL,

CONSTRAINT PK_Owner_Area PRIMARY KEY NONCLUSTERED ([Number_Area],[Id_Owner]),
FOREIGN KEY (Number_Area) REFERENCES Area (Number),
FOREIGN KEY (Id_Owner) REFERENCES Owner (ID)
)
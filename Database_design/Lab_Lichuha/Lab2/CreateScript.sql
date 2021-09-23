

CREATE TABLE TypeBuilding (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Name] [nvarchar](50) NOT NULL,
)

CREATE TABLE Line (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Number] [int] NOT NULL,
)

CREATE TABLE Area (
[Number] [int] PRIMARY KEY IDENTITY (1,1),
[ID_Line] [int] NOT NULL FOREIGN KEY (ID_Line) REFERENCES Line (ID) ON DELETE NO ACTION ON UPDATE CASCADE,
[Size] [float],
[Price] [float]
)

CREATE TABLE Building (
[ID] [int] PRIMARY KEY IDENTITY (1,1),
[Number_Area] [int] NOT NULL FOREIGN KEY (Number_Area) REFERENCES Area (Number) 
ON DELETE CASCADE ON UPDATE CASCADE,
[ID_TypeBuilding] [int] FOREIGN KEY (ID_TypeBuilding) REFERENCES TypeBuilding (ID) 
ON DELETE SET NULL ON UPDATE NO ACTION,
[Size] [float],
[Price] [float]
)

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
[ID_Owner] [int] NOT NULL FOREIGN KEY (ID_Owner) REFERENCES Owner (ID)
ON DELETE NO ACTION ON UPDATE NO ACTION,
[ID_Payment] [int] NOT NULL FOREIGN KEY (ID_Payment) REFERENCES Payment (ID)
ON DELETE NO ACTION ON UPDATE NO ACTION,
[Amount] [int],
)


CREATE TABLE Owner_Area (
[Number_Area] [int] NOT NULL,
[Id_Owner] [int] NOT NULL,
CONSTRAINT PK_Owner_Area PRIMARY KEY NONCLUSTERED ([Number_Area],[Id_Owner]),
FOREIGN KEY (Number_Area) REFERENCES Area (Number)
ON DELETE NO ACTION ON UPDATE CASCADE,
FOREIGN KEY (Id_Owner) REFERENCES Owner (ID)
ON DELETE CASCADE ON UPDATE NO ACTION 
)


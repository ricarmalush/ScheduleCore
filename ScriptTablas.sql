Use SchedulekCore;
go

-------------------------------------------------------------------------------------------------------------
CREATE TABLE Country
(
IdCountry int Identity(1,1), --Llave Primaria
CountryName varchar(50),
Down bit,

CONSTRAINT PK_Country_IdCountry PRIMARY KEY(IdCountry), --Llave Primaria
)
GO
-------------------------------------------------------------------------------------------------------------
CREATE TABLE Province
(
IdProvince int Identity(1,1), --Llave Primaria
IdCountry int,
ProvinceName varchar(50),
Down bit,

CONSTRAINT PK_Province_IdProvince PRIMARY KEY(IdProvince), --Llave Primaria
CONSTRAINT FK_Province_IdCountry FOREIGN KEY (IdCountry) REFERENCES Country(IdCountry),
)
GO
-------------------------------------------------------------------------------------------------------------
CREATE TABLE Town
(
IdTown int Identity(1,1), --Llave Primaria
IdProvince int,
TownName varchar(50),
Down bit,

CONSTRAINT PK_Town_IdTown PRIMARY KEY(IdTown), --Llave Primaria
CONSTRAINT FK_Town_IdProvince FOREIGN KEY  (IdProvince) REFERENCES Province(IdProvince),
)
GO
-------------------------------------------------------------------------------------------------------------
CREATE TABLE Person
(
IdPersona int Identity(1,1), --Llave Primaria
IdTown int,
PersonName varchar(50),
FirstName varchar(50),
LasName varchar(50),
HighDate datetime,
LowDate datetime,
Down bit

CONSTRAINT PK_Persona_IdPersona PRIMARY KEY(IdPersona),
CONSTRAINT FK_Persona_IdTown FOREIGN KEY  (IdTown) REFERENCES Town(IdTown),--Llave Primaria
)
Go
-------------------------------------------------------------------------------------------------------------
CREATE TABLE Direccion
(
IdDireccion int Identity(1,1), --Llave Primaria
IdPersona int,
Calle varchar(50),
CP varchar(50),

CONSTRAINT PK_Direccion_IdDireccion PRIMARY KEY(IdDireccion),
CONSTRAINT FK_Direccion_IdPersona FOREIGN KEY  (IdPersona) REFERENCES Persona(IdPersona),--Llave Primaria
)
Go
-------------------------------------------------------------------------------------------------------------
CREATE TABLE ClientOclock
(
IdClientOclock int Identity(1,1), --Llave Primaria
IdPersona int,

CONSTRAINT PK_ClientOclock_IdClientOclock PRIMARY KEY(IdClientOclock), --Llave Primaria
CONSTRAINT FK_ClientOclock_IdPersona FOREIGN KEY  (IdPersona) REFERENCES Persona(IdPersona),
)
GO


-------------------------------------------------------------------------------------------------------------
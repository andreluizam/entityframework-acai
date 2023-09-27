IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Adicionais' AND TYPE = 'U')
CREATE TABLE Adicionais(
ID int NOT NULL primary key identity,
Nome varchar(60),
CodigoBarra varchar(14),
Valor decimal(18,2)
)
GO

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'Clientes' AND TYPE = 'U')
CREATE TABLE Clientes(
ID int NOT NULL primary key identity,
Nome varchar(60),
Telefone varchar(25),
)
GO
Use master
CREATE DATABASE Agenda;
GO
USE Agenda;
CREATE TABLE Grupos (
    IdGrupo INT PRIMARY KEY IDENTITY(1,1),
    NombreGrupo VARCHAR(50) NOT NULL
);

CREATE TABLE Contactos (
    IdContacto INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL UNIQUE,
    Email VARCHAR(100),
    IdGrupo INT,
    FOREIGN KEY (IdGrupo) REFERENCES Grupos(IdGrupo)
);

CREATE TABLE Telefonos (
    IdContacto INT NOT NULL,
    Numero VARCHAR(20) NOT NULL,
    Descripcion VARCHAR(50),
    PRIMARY KEY (IdContacto, Numero),
    FOREIGN KEY (IdContacto) REFERENCES Contactos(IdContacto)
);
Go
Use Agenda
Delete Telefonos
Delete Contactos
Delete Grupos
Go

-- Reiniciar los autonuméricos

DBCC CHECKIDENT ('Grupos', RESEED, 0);
DBCC CHECKIDENT ('Contactos', RESEED, 0);

-- Insertar grupos
SET IDENTITY_INSERT Grupos ON;
INSERT INTO Grupos (IdGrupo, NombreGrupo) VALUES (1,'Amistades');
INSERT INTO Grupos (IdGrupo,NombreGrupo) VALUES (2,'Familia');
INSERT INTO Grupos (IdGrupo,NombreGrupo) VALUES (3,'2Dam');
INSERT INTO Grupos (IdGrupo,NombreGrupo) VALUES (4,'Cuatrovientos');
SET IDENTITY_INSERT Grupos OFF;
-- Insertar Contactos

SET IDENTITY_INSERT Contactos ON;
INSERT INTO Contactos (IdContacto,Nombre, Email, IdGrupo) 
VALUES (1,'Vegas Nieto Danel', 'vegasnietodanel@email.com', 3);

INSERT INTO Contactos(IdContacto, Nombre, Email, IdGrupo) 
VALUES (2,'Prado Palo Youness', NULL, 3);

INSERT INTO Contactos(IdContacto, Nombre, Email, IdGrupo) 
VALUES (3,'Apesteguia Armendariz Inazio', 'apesteguiaarmendariinazio@email.com', 3);

INSERT INTO Contactos(IdContacto, Nombre, Email, IdGrupo) 
VALUES (4,'Cabrera Bravo Lucía', NULL, NULL);

INSERT INTO Contactos(IdContacto, Nombre, Email, IdGrupo) 
VALUES (5,'Fontsere Del Cerro Allison', 'fontseredelcerrorallison@email.com', 2);

INSERT INTO Contactos(IdContacto, Nombre, Email, IdGrupo) 
VALUES (6,'Bravo Ibero Karla', NULL, 3);

INSERT INTO Contactos(IdContacto, Nombre, Email, IdGrupo) 
VALUES (7,'Loharces Lopez Cristian', 'loharceslopezcristian@email.com', 3);

INSERT INTO Contactos(IdContacto, Nombre, Email, IdGrupo) 
VALUES (8,'Mouhcine Prado Ander', 'mouhcinepradoander@email.com', 2);

INSERT INTO Contactos (IdContacto, Nombre, Email, IdGrupo) 
VALUES (14, 'Astigarraga Asier', 'astigarraga@email.com', null);

INSERT INTO Contactos (IdContacto, Nombre, Email, IdGrupo) 
VALUES (16, 'Mamani Osés Ibai', 'ibai@email.com', null);

INSERT INTO Contactos (IdContacto, Nombre, Email, IdGrupo) 
VALUES (19, 'Gorosabel Huarte Iker', 'ikergorosabel@email.com', 3);

INSERT INTO Contactos (IdContacto, Nombre, Email, IdGrupo) 
VALUES (20, 'Martín Noya Susana', 'susana@email.com', 3);
SET IDENTITY_INSERT Contactos OFF
-- Telefonos
INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (5, '948454545', 'Casa');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (2, '123456789', 'Móvil Personal');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (5, '987654321', 'Trabajo');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (4, '948555555', 'Casa');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (5, '444444444', 'Móvil Personal');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (6, '948333333', 'Casa');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (7, '222222222', 'Trabajo');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (8, '111111111', 'Móvil Personal');
INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (1, '948454545', 'Casa');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (1, '612345678', null);

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (2, '623456789', null);

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (3, '948654321', 'Trabajo');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (3, '111111111', null);

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (4, '655555555', 'Madre');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (5, '644444444', null);

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (6, '633333333', 'Pareja');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (7, '948222222', 'Trabajo');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (8, '611111111', 'Móvil Personal');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (14, '644444444', 'Personal');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (14, '611111111', null);

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (16, '611111111', null);

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (16, '649121212', 'Madre');

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (19, '611111111', null);

INSERT INTO Telefonos (IdContacto, Numero, Descripcion) 
VALUES (3, '611111111', null);
Go
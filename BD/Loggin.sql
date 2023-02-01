CREATE DATABASE LOGINN;
USE  LOGINN;

CREATE TABLE Usuarios
(
Nombre varchar(30),
Contraseña varchar (30),
Roll varchar(25)
); 

create procedure iniciar
@Nombre varchar(30),
@Contraseña varchar (30)
as
SELECT *FROM Usuarios WHERE 
Nombre=@Nombre and Contraseña=@Contraseña
go




INSERT INTO Usuarios VALUES ('diegoo','1234','Administrador');
INSERT INTO Usuarios VALUES ('alexiss','456','Cliente');
INSERT INTO Usuarios VALUES ('mariaa','789','Secretaria');

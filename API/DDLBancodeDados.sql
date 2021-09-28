CREATE DATABASE BancoDeDados;
GO

USE BancoDeDados;

CREATE TABLE Usuarios(
	idUsuario INT PRIMARY KEY IDENTITY,
	nomeUsuario VARCHAR(50) NOT NULL,
	emailUsuario VARCHAR(75) NOT NULL,
	senhaUsuario VARCHAR(8) NOT NULL
);
GO

SELECT * FROM Usuarios;
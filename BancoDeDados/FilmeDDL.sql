-- criando banco de dados
CREATE DATABASE FILME;
GO

-- acessando o banco de dados
USE FILME;
GO

CREATE TABLE Genero(
	idGenero INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL
);
GO

CREATE TABLE Filme(
	idFilme INT PRIMARY KEY IDENTITY,
	idGenero INT FOREIGN KEY REFERENCES Genero (idGenero),
	NomeFilme VARCHAR(150) NOT NULL,
	Sinopse VARCHAR(255)
);
GO


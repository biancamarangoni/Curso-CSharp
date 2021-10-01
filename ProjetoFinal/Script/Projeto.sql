CREATE DATABASE EscolaSenai;
GO

USE EscolaSenai;

CREATE TABLE Alunos(
	 idAluno INT PRIMARY KEY IDENTITY,
	 nomeAluno VARCHAR(50) NOT NULL,
	 emailAluno VARCHAR(50) NOT NULL,
	 enderecoAluno VARCHAR(70)NOT NULL,
	 telefoneAluno VARCHAR(11), 
	 escolaridadeAluno VARCHAR(30)
 );
 GO

 SELECT * FROM Alunos;
 DROP TABLE Alunos;

 CREATE TABLE Professores(
	idProfessor INT PRIMARY KEY IDENTITY,
	nomeProfessor VARCHAR(50) NOT NULL,
	emailProfessor VARCHAR(50) NOT NULL,
	enderecoProfessor VARCHAR(70) NOT NULL,
	telefoneProfessor VARCHAR(11),
	cargoProfessor VARCHAR(30) NOT NULL
);
GO

SELECT * FROM Professores;



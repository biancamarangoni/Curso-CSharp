USE FILME
GO

INSERT INTO Genero (Nome)
VALUES ('Ação'), ('Ficção'), ('Aventura'), ('Comédia'), ('Romance');
GO

--selecionar registro de uma tabela
SELECT idGenero, Nome FROM Genero;

--deletar registro de uma tabela
DELETE FROM Genero WHERE idGenero > 0 --aqui deleta um id

--atualizar dados de uma tabela
UPDATE Genero SET Nome = 'Comédia/Drama' WHERE idGenero = 4

--resetar uma identity
DBCC checkident('[Filme]', reseed, 0);

DELETE FROM Genero;

SELECT * FROM Genero;

INSERT INTO Filme (Nome, Sinopse, idGenero, Duracao)
VALUES ('Tropa de Elite', 'Tiro, porrada e bomba', 1, '120min'),
	   ('Avatar', 'Bicho azul gigante', 2, '120min'),
	   ('LaLa Land', 'Filme perfeito demais', 5, '120min'),
	   ('Sol da Meia-noite', 'meio cliche', 5, '120min');

SELECT * FROM Filme

DELETE FROM Filme;

--insere um campo na tabela
ALTER TABLE Filme 
ADD Duracao VARCHAR(255);

--inserir a duração

  --UPDATE Filme SET Duracao = '120 min'
  --WHERE idFilme = 1;

 

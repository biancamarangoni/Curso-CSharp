USE FILME
GO

INSERT INTO Genero (Nome)
VALUES ('A��o'), ('Fic��o'), ('Aventura'), ('Com�dia');
GO

--selecionar registro de uma tabela
SELECT idGenero, Nome FROM Genero;

--deletar registro de uma tabela
DELETE FROM Genero WHERE idGenero 4 --aqui '>' deleta de um numero em diante

--atualizar dados de uma tabela
UPDATE Genero SET Nome = 'Com�dia/Drama' WHERE idGenero = 4

--resetar um identity
DBCC checklist('[Genero]', reseed 0)

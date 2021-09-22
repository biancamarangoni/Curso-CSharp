USE FILME
GO

SELECT Filme.Nome, Filme.Sinopse, Genero.Nome AS Genero, Filme.Duracao
FROM Filme
INNER JOIN Genero
ON Filme.idGenero = Genero.idGenero;

--usando o ALIAS, abreviamos o nome da tabela, como por exe 'Filme.Nome' pode ser 'f.Nome'
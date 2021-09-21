using System;

namespace ExercMercearia.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public string Marca { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }

        public Produto(int _codigo, string _nomeProduto, double _preco, string _marca, string _cadastroPor, DateTime _dataCadastro){
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            Marca = _marca;
            CadastradoPor = _cadastroPor;
        }

    }
}
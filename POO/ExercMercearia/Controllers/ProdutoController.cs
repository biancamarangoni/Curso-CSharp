using System;
using System.Collections.Generic;
using ExercMercearia.Models;

namespace ExercMercearia.Controllers
{
    public class ProdutoController
    {
        private string _nomeProduto;

        public Produto CadastrarProduto(Funcionario porFuncionario)
        {
            Console.WriteLine("Digite um codigo: ");
            int Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto: ");
            string NomeProduto = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do produto: ");
            double Preco = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a marca do produto: ");
            string Marca = Console.ReadLine();

            DateTime Datacadastro = DateTime.Now;

            string cadastradoPor = porFuncionario.Nome;

            Produto produto = new Produto(Codigo, NomeProduto, Preco, Marca, cadastradoPor, Datacadastro);

            return produto;
        }
        public void ListarProdutos(List<Produto> lista){
            foreach (var item in lista)
            {
                Console.WriteLine($"Nome do produto: {item.NomeProduto}, preco do produto: {item.Preco:C2}, marca do produto: {item.Marca}. Cadastrado por: {item.CadastradoPor}, em: {item.DataCadastro}");   
            }//fim listar produtos
        }
          
          //método p buscar um produto 
        public Produto BuscarProduto(string produtoPesquisado, List<Produto> lista){
            Produto produtoRetornado = lista.Find(produto => produto.NomeProduto == _nomeProduto);
            return produtoRetornado;
        }
    }
}
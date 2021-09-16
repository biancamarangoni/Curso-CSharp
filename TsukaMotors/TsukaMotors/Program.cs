using System;
using System.Collections.Generic;
using TsukaMotors.Controllers;
using TsukaMotors.Models;

namespace TsukaMotors
{
    class Program
    {
        static void Main(string[] args)
        {

            //vamos criar um menu de opções
            List<Veiculo> listaDeVeiculos = new List<Veiculo>();
            VeiculoController veiculoController = new VeiculoController();
            string opcao;
            do
            {
                Console.WriteLine("[1] - Cadastrar Veículo");
                Console.WriteLine("[2] - Listar Veículos");
                Console.WriteLine("[3] - Pesquisar Veiculo");
                Console.WriteLine("[0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Aqui iremos cadastrar um veículo
                        Veiculo veiculoRetornado = veiculoController.CadastrarVeiculo();
                        listaDeVeiculos.Add(veiculoRetornado);
                        break;
                    case "2":
                        // Aqui vamos listar os veículos cadastrados
                        //aq temos que acessar a lista de veiculos e exibir cada item da lista
                        veiculoController.ListarVeiculos(listaDeVeiculos);
                        break;
                    case "3":
                        Console.WriteLine("Digite o chassi do veiculo: ");
                        string chassiPesquisado = Console.ReadLine();
                        Veiculo veiculoPesquisado = VeiculoController.BuscarVeiculo(chassiPesquisado, listaDeVeiculos);
                        Console.WriteLine($"Veiculo correspondente: {veiculoPesquisado.Modelo}");
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        break;
                    default:
                        Console.WriteLine("Errou!");
                        break;
                }
            } while (opcao != "0");


        }
    }
}

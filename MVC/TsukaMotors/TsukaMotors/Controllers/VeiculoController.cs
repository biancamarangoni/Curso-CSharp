using System;
using System.Collections.Generic;
using TsukaMotors.Models;

namespace TsukaMotors.Controllers
{
    public class VeiculoController
    {
        
        public List<Veiculo> listaVeiculo = new List<Veiculo>();
        public Veiculo CadastrarVeiculo(){
            Console.WriteLine("Digite o tipo do veículo");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite o modelo do veículo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do veículo");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o ano do veículo");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do chassi");
            string chassi = Console.ReadLine();

            Veiculo veiculo = new Veiculo(tipo, marca, modelo, ano, chassi);
            
            return veiculo;

        }// fim cadastrarVeiculo

        //método para listar os veiculos
        public void ListarVeiculos(List<Veiculo> lista){
            foreach (var item in lista)
            {
                Console.WriteLine($"Marca: {item.Marca} Modelo: {item.Modelo} Ano: {item.Ano} Tipo: {item.Tipo}");
            }
        }//fim listar veiculos

        //método p buscar um veiculo através do n° do chassi
        public Veiculo BuscarVeiculo(string chassiPesquisado, List<Veiculo> lista){
            Veiculo veiculoRetornado =  lista.Find(Veiculo => Veiculo.Chassi == chassiPesquisado);
            return veiculoRetornado;
        }

        //método para remover um elemento da lista (delete)
        public void RemoverVeiculo(string _chassi, List<Veiculo> lista){
            Veiculo veiculoRetornado = lista.Find(veiculo => veiculo.Chassi == _chassi);

            lista.Remove(veiculoRetornado);
        }

    }
}
using System;
using System.Collections.Generic;
using ExercMercearia.Models;

namespace ExercMercearia.Controllers
{
    public class FuncionarioController
    {
        public Funcionario CadastroFuncionario()
        {
            Console.WriteLine("Digite um codigo: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
            
            DateTime datacadastro = DateTime.Now;

            Funcionario cadastroFunci = new Funcionario (codigo, nome, email, senha, datacadastro);

            return cadastroFunci;
        }
        public void ListarFuncionarios(List<Funcionario> lista){
            foreach(var item in lista)
            {
                Console.WriteLine($"Nome: {item.Nome}, e-mail: {item.Email}, data de cadastro: {item.DataCadastro}");        
            }//fim listar funcionarios
        }
        public Funcionario AnalisarEmail(string _email, List<Funcionario> lista){
            Funcionario analisaremail = lista.Find(funcionario => funcionario.Email == _email);
            return analisaremail;  
        }
    }
}
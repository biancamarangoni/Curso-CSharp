using System;
using System.Collections.Generic;
using ExercMercearia.Controllers;
using ExercMercearia.Models;

namespace ExercMercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu de opções
            ProdutoController produtoController = new ProdutoController();
            FuncionarioController cadastrofuncionario = new FuncionarioController();
            List<Produto> listarProdutos = new List<Produto>();
            List<Funcionario> listarFuncionarios = new List<Funcionario>();

            string opcao;
            string escolha;
            do // funcionario
            {
                Console.WriteLine("[1] Cadastro de Funcionário");
                Console.WriteLine("[2] Listar Funcionários");
                Console.WriteLine("[3] Entrar no menu de cadastro de Produtos");
                Console.WriteLine("[0] Sair do Programa");
                escolha = Console.ReadLine();
                switch(escolha)
                {
                    case "1":
                    Funcionario cadastroFunci = cadastrofuncionario.CadastroFuncionario();
                    listarFuncionarios.Add(cadastroFunci);
                    Console.WriteLine("Usuário cadastrado com sucesso!");
                    break;
                    case "2":
                    cadastrofuncionario.ListarFuncionarios(listarFuncionarios);
                    break;
                    case "3":
                    Console.WriteLine("Funcionário já cadastrado? [sim] -- [não]");
                    string resposta = Console.ReadLine();
                    if(resposta == "sim")
                    {
                        Console.WriteLine("Digite o e-mail:");
                        string emailuser = Console.ReadLine();
                        
                        Console.WriteLine("Digite a senha:");
                        string senhauser = Console.ReadLine();
                        
                        Funcionario funcionariopesquisado = cadastrofuncionario.AnalisarEmail(emailuser, listarFuncionarios);
                        Funcionario senha = cadastrofuncionario.AnalisarEmail(senhauser, listarFuncionarios);
                        
                        if(funcionariopesquisado == null && senhauser == null)
                        {
                            Console.WriteLine("Usuário não cadastrado!");     
                        }
                        else if(senhauser != funcionariopesquisado.Senha)
                        {
                            Console.WriteLine($"Senha inválida!");    
                        }
                        Console.Clear();
                        Console.WriteLine("---------- Cadastro de produtos! ----------");

                        do //menu cadastro de produtos
                        {
                            Console.WriteLine("[1] - Cadastrar Produto");
                            Console.WriteLine("[2] - Listar Produtos");
                            Console.WriteLine("[3] - Buscar Produto");
                            Console.WriteLine("[0] - Voltar");
                            opcao = Console.ReadLine();
                            switch(opcao)
                            {
                                case "1":
                                    Produto produtoRetornado = produtoController.CadastrarProduto(funcionariopesquisado);
                                    listarProdutos.Add(produtoRetornado);
                                break;
                                case "2":
                                    produtoController.ListarProdutos(listarProdutos);
                                break;
                                case "3":
                                    Console.WriteLine("Digite o nome do produto que deseja buscar:");
                                    string produtoPesquisado = Console.ReadLine();
                                    Produto produtoretornado = produtoController.BuscarProduto(produtoPesquisado, listarProdutos);
                                    if(produtoretornado == null)
                                    {
                                        Console.WriteLine("Produto não encontrado!");
                                    }else{
                                        Console.WriteLine($"Produto retornado: {produtoretornado.Marca}"); 
                                    }
                                break;
                                case "0":
                                    Console.WriteLine("Obrigado por utilizar o programa. Até mais!"); 
                                break;
                                default:
                                    Console.WriteLine("ERRO");
                                break;        
                            }
                            
                        }while(opcao != "0");
                    }
                    else{
                        Console.Clear();
                        Console.WriteLine("É nescessário cadastrar um usuário!");
                    }
                    break;
                case "0":
                    Console.WriteLine("Obrigado por usar o programa!");
                break;
                default:
                    Console.WriteLine("Opção inválida!");
                break;
                }
                    
            }while(escolha != "0");
        }
    }
}

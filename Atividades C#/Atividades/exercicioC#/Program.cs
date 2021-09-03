using System;

namespace exercicioC_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string opcao, resposta;
            string[] nomes = new string[5];
            string[] origens = new string[5];
            string[] destinos = new string[5];
            string[] datas = new string[5];
            int contador = 0;

            Console.WriteLine("Digite a senha:");
            string senhaDigitada = Console.ReadLine();
            bool retornoDaFunçao = ValidarSenha(senhaDigitada);
            while (!retornoDaFunçao)
            {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Digite a senha novamente:");
                senhaDigitada = Console.ReadLine();
                retornoDaFunçao = ValidarSenha(senhaDigitada);
            }//fim while

            Console.WriteLine("--------------------------");
            Console.WriteLine("Bem vindo a Tsuka Air Lines");
            Console.WriteLine("--------------------------");

            do //inicio do
            {
            Console.WriteLine("-----Selecione uma opção-----");
            Console.WriteLine("[1] - Cadastrar Passagem");
            Console.WriteLine("[2] - Listar Passagens");
            Console.WriteLine("[3] - Buscar Passageiro");
            Console.WriteLine("[0] - Sair");
            opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de passagens");
                    CadastroDePassagens();
                break;
                case "2":
                    Console.WriteLine("Listar Passagens");
                    ListarPassagens();
                break;
                case "3":
                    Console.WriteLine("Buscar Passageiro");
                    Console.WriteLine("Digite o nome do passageiro: ");
                    string nome = Console.ReadLine();
                    ProcurarPorNome(nome);
                break;
                case "0":
                    Console.WriteLine("Obrigado por escolher a Tsuka Air Lines");
                    Console.WriteLine("Volte sempre!!!");
                break;
                default:
                    Console.WriteLine("Opção Inválida!");
                break;
            }//fim do switch 

            } while (opcao != "0"); //fim DO

                //funções
            bool ValidarSenha(string senha)
            {
                if(senha == "123456")
                {
                    return true;
                }else{
                    return false;
                }
            }//fim validar senhas

            void CadastroDePassagens(){
                
                do 
                {
                    if(contador < 5){

                        Console.WriteLine("Digite o nome do passageiro");
                            nomes[contador] = Console.ReadLine();
                        Console.WriteLine("Digite a Origem");
                            origens[contador] = Console.ReadLine();
                        Console.WriteLine("Digite o Destino");
                            destinos[contador] = Console.ReadLine();
                        Console.WriteLine("Digite a data da viagem");
                            datas[contador] = Console.ReadLine();
                        Console.WriteLine("Gostaria de cadastrar outra passagem?");
                            resposta = Console.ReadLine();
                        contador++;

                    }else{
                        Console.WriteLine("Limite excedido!");
                        break;
                    }
                }while(resposta == "sim");
            }//fim cadastro de passagens

            void ListarPassagens(){
                for (var i = 0; i < contador; i++)
                {
                    Console.WriteLine($"{nomes[i]} data: {datas[i]}");
                    Console.WriteLine($"origem {origens[i]} destino:{destinos[i]}");
                }
            }

            void ProcurarPorNome(string nome){
                for (var i = 0; i < 5; i++)
                {
                    if(nome == nomes[i]){
                    Console.WriteLine($"{nomes[i]} destino: {destinos[i]} na data: {datas[i]}");
                    }
                }
               
            }

        }//fim main
    }
}

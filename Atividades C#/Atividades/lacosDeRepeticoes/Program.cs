using System;

namespace lacosDeRepeticoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //While() e Do While()
            Console.WriteLine("Digite o nome de usuário");
            string usuario = Console.ReadLine();

            while( usuario != "dev")//se a condição for verdadeira ela entra no laço
            {
                //aqui fica o conteudo do laço
                Console.WriteLine("Usuário Inválido");
                Console.WriteLine("Digite novamente o usuário");
                usuario = Console.ReadLine();
            }
            
            string senha = "";
            string conta = "";
            // Do While - executa ao menos uma vez o laço
            int cont = 0;
            do
            {
                if(cont < 3)
                {
                    Console.WriteLine("Digite a senha:");
                    senha = Console.ReadLine();
                    cont = cont + 1;
                }
                else
                {
                    Console.WriteLine("Conta Bloqueada!");
                    conta = "bloqueada";
                    break;
                }
                   
            } while (senha != "dev@132");
            //contador dois
            if (conta == "bloqueada")
            {
                Console.WriteLine("Entre em contato com o Gerente!");
            }
            else
            {
                Console.WriteLine("Acesso liberado!");
            }

        }
    }
}

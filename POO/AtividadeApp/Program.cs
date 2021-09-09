using System;

namespace AtividadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular cell = new Celular();

            cell.modelo = "samsung";
            cell.cor = "preto";
            cell.tamanho = 15.3;
            cell.ligar = true;
            cell.fazerLigacao = "";
            cell.enviarMensagem = "";


            Console.WriteLine("bem vindo ao programa");

            Console.WriteLine("o que voce deseja fazer ?");

            int opcao, escolha;

            do
            {
                Console.WriteLine("1- ligar celular");
                Console.WriteLine("2- desligar celular");
                Console.WriteLine("3- enviar mensagem");
                Console.WriteLine("4- fazer ligação");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Celular ligado!");
                        escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Console.WriteLine("Escreva a mensagem que deseja enviar: ");
                            Console.ReadLine();
                            Console.WriteLine("Mensagem enviada com sucesso!");
                        }
                        else if (escolha == 2)
                        {
                            Console.WriteLine("Para quem voce deseja ligar ?");
                            Console.WriteLine("1 --- Pizzaria");
                            Console.WriteLine("2 --- Emergencia");
                            Console.WriteLine("3 --- Tsukamoto");
                            Console.ReadLine();
                            Console.WriteLine("Ligação efetuada com sucesso!");
                        }

                        break;
                    case 2:

                        break;
                    case 3:
                    if (escolha == 3)
                        {
                            Console.WriteLine("Escreva a mensagem que deseja enviar: ");
                            escolha = int.Parse(Console.ReadLine());
                            Console.WriteLine("Mensagem enviada com sucesso!");
                        }
                        break;
                    default:
                        Console.WriteLine("opção errada");
                        break;
                }

            } while (opcao != 2);


        }
    }
}

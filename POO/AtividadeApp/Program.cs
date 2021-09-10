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


            Console.WriteLine("Bem vindo ao programa!");

            Console.WriteLine("O que voce deseja fazer?");

            int opcao, escolha;

            do
            {
                Console.WriteLine("1 - Ligar celular");
                Console.WriteLine("2 - Desligar celular");
                Console.WriteLine("3 - Enviar mensagem");
                Console.WriteLine("4 - Fazer ligação");
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
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 2);


        }
    }
}

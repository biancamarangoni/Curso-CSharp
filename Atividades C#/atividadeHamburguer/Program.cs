using System;

namespace atividadeHamburguer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Hamburgueria Tsuka Monstro!");

            Console.WriteLine("Cardápio: 1"); 
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.Write("Escolha um número: ");
            int lanche = int.Parse(Console.ReadLine());

            switch (lanche)
            {
                case 1:
                    Console.WriteLine("Seu pedido é um Hamburguer");
                break;
                 case 2:
                    Console.WriteLine("Seu pedido é um Cheese Salada");
                break;
                 case 3:
                    Console.WriteLine("Seu pedido é um Cheese Bacon");
                break;
                 case 4:
                    Console.WriteLine("Seu pedido é um Cheese Burguer");
                break;
                default: 
                    Console.WriteLine("Opção inválida");
                break;
            }
        }
    }
}

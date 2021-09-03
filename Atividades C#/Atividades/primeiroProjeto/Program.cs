using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo à");

            Console.WriteLine("Escola SENAI de Informática");

            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();

            Console.WriteLine("Bem Vinda, "+nome);

            Console.WriteLine("Soma de dois números");

            Console.WriteLine("Digite o primeiro número");
            var primeiroNumero = Console.ReadLine();

            Console.WriteLine("Digite o segundo número");
            var segundoNumero = Console.ReadLine();

            Console.WriteLine(primeiroNumero+segundoNumero);

        }
    }
}

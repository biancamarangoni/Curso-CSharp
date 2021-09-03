using System;

namespace quartoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média Final");

            Console.WriteLine("Nota da Prova 1");
            double notaUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota da Prova 2");
            double notaDois = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota da Prova 3");
            double notaTres = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota do Trabalho");
            double notaTrabalho = double.Parse(Console.ReadLine());

            Console.WriteLine("Média Final: " + (notaUm + notaDois + notaTres + notaTrabalho) /4);

        }
    }
}

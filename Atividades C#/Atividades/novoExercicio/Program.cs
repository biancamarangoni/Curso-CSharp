using System;

namespace novoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int [10];

            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número");
                elementos[i] = int.Parse(Console.ReadLine());
            }//fim for
        }//fim main
    }
}

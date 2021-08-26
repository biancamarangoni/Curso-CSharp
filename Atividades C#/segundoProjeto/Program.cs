using System;

namespace segundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //o código deve começar dentro do main 

            Console.WriteLine("Soma de dois números inteiros"); //writeline escreve no console
            Console.WriteLine("Digite o primeiro número");
            int numeroUm = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número");
            int numeroDois = int.Parse(Console.ReadLine()); //readline lê a linha

            //Processamento

            int soma = numeroUm + numeroDois; 
            int multiplicacao = numeroUm * numeroDois; 

            //Saída

            Console.WriteLine("A soma dos valores = "+soma); //o +soma serve pra fazer soma dos valores inseridos
            Console.WriteLine("A soma dos valores = "+multiplicacao); //multiplicação * 


            
        }
    }
}

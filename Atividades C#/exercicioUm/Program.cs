using System;

namespace exercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
                      //EXEMPLO//
            /* double valor = 250.00; // valor original
             double percentual = 8.0 / 100.0; // 8%
            double valor_final = valor - (percentual * valor) */

            Console.WriteLine("Aumento de Salário");

            Console.WriteLine("Digite seu salário atual: ");
            double salario = double.Parse(Console.ReadLine());

            double valorFinal = salario + (salario * 0.3);


            if(salario>500){
                Console.WriteLine("Você não possuí reajuste de salário.");
            }else{
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Com o reajuste de 30%, seu salário é igual a: "+valorFinal);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
        }
    }
}

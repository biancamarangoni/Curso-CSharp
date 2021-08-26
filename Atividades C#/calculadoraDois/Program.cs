using System;

namespace calculadoraDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja fazer (+ - * /)?");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;
            bool validador = true;

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                break;
                case "-":
                    resultado = num1 - num2;
                break;
                case "*":
                    resultado = num1 * num2;
                break;
                case "/":
                    resultado = num1 / num2;
                break;
                default:
                    Console.WriteLine("Operação inválida");
                    validador = false;
                break;
            }
            if(validador == true){
                Console.WriteLine("O resultado é: "+resultado);
            }
            


        }
    }
}

using System;

namespace condicionaisDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de dois digitos");

            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            int resposta = int.Parse(Console.ReadLine());

            double resultado = 0;
            //bool pode ser true = 1 ou false = 0
            bool validacao = true;

            if(resposta == 1){
                resultado = num1 + num2;
            }else if(resposta == 2){
                resultado = num1 - num2;
            }else if(resposta == 3){
                resultado = num1 * num2;
            }else if(resposta == 4){
                resultado = num1 / num2;
            }else{
                Console.WriteLine("Opção inválida!");
                validacao = false;
            }
            if(validacao == true){
               Console.WriteLine("O resultado é: "+resultado);
            }
        }
    }
}

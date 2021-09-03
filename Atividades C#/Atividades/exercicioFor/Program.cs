using System;

namespace exercicioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada
            Console.WriteLine("Digite um número");
            int[] numero = new int [6];
            //int contador = 0;
            int[] numPar = new int [6];//array
            //int soma = 0;

            for(var i = 0; i < 6; i++)
            { //processamento
                Console.WriteLine($"Digite o {i + 1}  número.");
                numero[i] = int.Parse(Console.ReadLine());
                //if ((numero[i]%2) == 0);
                //{
                   // numPar[contador] = numero[i];
                   // contador++;
               //}   
            } 
            int qtdPar = 0;
            int qtdImpar =0;
            foreach (var item in numero)
            {
                if(item % 2 ==0)
                {
                    qtdPar++;
                }
                else
                {
                    qtdImpar++;
                }
            }
            //saída
            Console.WriteLine($"Os números pares são: {qtdPar} ");
            Console.WriteLine($"Os números impares são: {qtdImpar}");
            //for (int i = 0; i <contador;i++)
            //{
               // Console.Write($"{numPar[i]},");
            //}
        }
    }
}

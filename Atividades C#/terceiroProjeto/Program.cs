using System;

namespace terceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());

            //Processamento
            
            Console.WriteLine(num+" x 0 = "+num*0);
            Console.WriteLine(num+" x 1 = "+num*1);
            Console.WriteLine(num+" x 2 = "+num*2);
            Console.WriteLine(num+" x 3 = "+num*3);
            Console.WriteLine(num+" x 4 = "+num*4);
            Console.WriteLine(num+" x 5 = "+num*5);    //a variável (no caso o num) é multiplicada por um valor fixo
            Console.WriteLine(num+" x 6 = "+num*6);    
            Console.WriteLine(num+" x 7 = "+num*7);
            Console.WriteLine(num+" x 8 = "+num*8);
            Console.WriteLine(num+" x 9 = "+num*9);
            Console.WriteLine(num+" x 10 = "+num*10);
            
            //Saída
            
        
        }
    }
}

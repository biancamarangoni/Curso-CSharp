using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categoria Natação");

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

          
            if(idade >=18){
                Console.WriteLine("Categoria: Sênior");
            }else if(idade >=14){
                Console.WriteLine("Categoria: Juvenil B");
            }else if(idade >=11){
                Console.WriteLine("Categoria: Juvenil A");
            }else if(idade >=8){
                Console.WriteLine("Categoria: Infantil B");
            }else if(idade >=5){
                Console.WriteLine("Categoria: Infantil A");
            }else{
                Console.WriteLine("Idade insuficiente");
            }
        }
    }
}

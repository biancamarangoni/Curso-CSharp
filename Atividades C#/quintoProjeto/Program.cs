using System;

namespace quintoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int anoNasc = int.Parse(Console.ReadLine());
             
            Console.WriteLine("Ano atual");
            int anoAtual = int.Parse(Console.ReadLine());

            int idade = (anoAtual - anoNasc);

            Console.WriteLine("Sua idade é " + idade + " anos");
            
            Console.WriteLine("E sua sua idade em semanas é " + (idade *12) *4 + ", bocó");

            /*para calcular a idade em semanas, foi criada uma variável
            que calcula o ano de nascimento e o ano atual*/ 

            if(idade>=18){
                //se verdadeiro - true
               // Console.WriteLine("Liberado!!! Bora.");
               Console.WriteLine("Possui ingresso (Sim ou Não)?");
               string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Acesso liberado!");
                }else{
                    Console.WriteLine("Vá até a bilheteria e adquira o ingresso!");
                }
            }else{
                //se falso - false
                Console.WriteLine("Acesso negado!");
            }
            /*if é o "se" e else é o "então"*/
        }
    }
}

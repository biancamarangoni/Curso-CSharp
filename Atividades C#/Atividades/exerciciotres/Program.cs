using System;

namespace exerciciotres
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mediasTemp = new double[12]; //variaveis criadas
            string[] mesAno = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto","Setembro", "Outubro", "Novembro", "Dezembro"};
            string mesMaior = "", mesMenor = "";
            for (var i = 0; i < 12; i++)
            {
                Console.WriteLine($"Digite a média de temperatura de cada mês do ano: {i + 1}º mês");
                mediasTemp[i] = double.Parse(Console.ReadLine());
            }// fim do for

            double maiorTemp = mediasTemp[0];
            double menorTempo = mediasTemp[0];
            
            for (var i = 0; i < 12; i++)
            {
                if(maiorTemp < mediasTemp[i]){
                    maiorTemp = mediasTemp[i];
                    mesMaior = mesAno[i];    
                }
                if(menorTempo > mediasTemp[i]){
                    menorTempo = mediasTemp[i];
                    mesMenor = mesAno[i];
                }
                
            }//fim do foreach
            Console.WriteLine($"A maior temperatura = {maiorTemp}°C, {mesMaior}");
            Console.WriteLine($"A menor temperatura = {menorTempo}°C, {mesMenor}");
        }
    }
}

using System;
using DebCred.Models;

namespace DebCred
{
    class Program
    {
        private static double valor;

        static void Main(string[] args)
        {
            //criamos uma instância de Débito
            Debito cartaoBianca = new Debito();
            cartaoBianca.titular = "Bianca Marangoni";
            cartaoBianca.DefinirNumero("4583 6943 7103 1290");
            cartaoBianca.DefinirSenha("182505");
            cartaoBianca.Depositar(5000);

            Debito cartaoTsuka = new Debito();
            cartaoTsuka.titular = "Carlos Tsuka";
            cartaoTsuka.DefinirNumero("7626 9410 3010 7410");
            cartaoTsuka.DefinirSenha("123456");
            cartaoTsuka.Depositar(3000);

            //exibindo dados do projeto

            Console.WriteLine($"Cartão - {cartaoBianca.titular}");
            Console.WriteLine($"n° {cartaoBianca.ExibirNumero()}");
            Console.WriteLine($"O saldo é de {cartaoBianca.ExibirSaldo()}");

            Console.WriteLine($"Cartão - {cartaoTsuka.titular}");
            Console.WriteLine($"n° {cartaoTsuka.ExibirNumero()}");
            Console.WriteLine($"O saldo é de {cartaoTsuka.ExibirSaldo()}");

            //fazer transferência

            cartaoBianca.Transferir("182505", 1050, cartaoTsuka);

            //Exibir dados da transferência 

            Console.WriteLine("Transferência efetuada!");
            Console.WriteLine($"Conta - {cartaoBianca.titular} - Saldo Atual = {cartaoBianca.ExibirSaldo()}");
            Console.WriteLine($"Conta - {cartaoTsuka.titular} - Saldo Atual = {cartaoTsuka.ExibirSaldo()}");
        
            //instância Crédito
            Credito cartaoBiancaCred = new Credito();
            cartaoBiancaCred.titular = "Bianca Marangoni";
            cartaoBiancaCred.Limite(15000);
            cartaoBiancaCred.Comprar(8650);
            cartaoBiancaCred.PagarFatura();

            Credito cartaoTsukaCred = new Credito();
            cartaoTsukaCred.titular = "Carlos Tsuka";
            cartaoTsukaCred.Limite(9000);
            cartaoTsukaCred.Comprar(4595);
            cartaoTsukaCred.PagarFatura();
            
        }
    }
}

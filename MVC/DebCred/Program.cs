using System;
using DebCred.Models;

namespace DebCred
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criamos uma instância de Debito
            Debito cartaoBianca = new Debito(); 
            cartaoBianca.titular = "Bianca Marangoni";
            cartaoBianca.DefinirNumero("1234 1234 1234 1234");
            cartaoBianca.DefinirSenha("1234");
            cartaoBianca.Depositar(5000);
            
            Debito cartaoTsukamoto = new Debito(); 
            cartaoTsukamoto.titular = "Carlos Tsukamoto";
            cartaoTsukamoto.DefinirNumero("4321 4321 4321 4321");
            cartaoTsukamoto.DefinirSenha("4321");
            cartaoTsukamoto.Depositar(100);

            //Exibindo dados dos objetos
            Console.WriteLine($"Cartao - {cartaoBianca.titular}");
            Console.WriteLine($"nº {cartaoBianca.ExibirNumero()}");
            Console.WriteLine($"Saldo - {cartaoBianca.ExibirSaldo()}");

            Console.WriteLine($"Cartão - {cartaoTsukamoto.titular}");
            Console.WriteLine($"nº {cartaoTsukamoto.ExibirNumero()}");
            Console.WriteLine($"Saldo - {cartaoTsukamoto.ExibirSaldo()}");

            // Fazer trasferência

            cartaoBianca.Transferir("12345", 3000, cartaoTsukamoto);

            //Exibir os dados depois da transferência

          
            Console.WriteLine($"Conta - {cartaoBianca.titular} - Saldo Atual = {cartaoBianca.ExibirSaldo()}");
            Console.WriteLine($"Conta - {cartaoTsukamoto.titular} - Saldo Atual = {cartaoTsukamoto.ExibirSaldo()}");
            

            //Cartão de crédito

            Console.ForegroundColor = ConsoleColor.Cyan;

            Credito cartaoCredTiago = new Credito();

            cartaoCredTiago.titular = "Tiago Uehara";
            cartaoCredTiago.DefinirNumero("5656 5454 4343 3232");
            cartaoCredTiago.DefinirSenha("asdf");
            cartaoCredTiago.DefinirLimite(10000);

            //Exbir dados da conta

            Console.WriteLine($"Conta - {cartaoCredTiago.titular}");
            Console.WriteLine($"Número - {cartaoCredTiago.ExibirNumero()}");
            Console.WriteLine($"Saldo Disponível = {cartaoCredTiago.ExibirSaldoDisponivel()}");

            //Fazer compra

            cartaoCredTiago.Comprar("asdf", 4500);

            Console.WriteLine("Compra efetuada");
            Console.WriteLine($"Saldo Disponível = {cartaoCredTiago.ExibirSaldoDisponivel()}");



            // Pagando Fatura

            cartaoCredTiago.PagarFatura(5000);
            Console.WriteLine("Pagamento efeuado");
            Console.WriteLine($"Saldo Disponível = {cartaoCredTiago.ExibirSaldoDisponivel()}");



          Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


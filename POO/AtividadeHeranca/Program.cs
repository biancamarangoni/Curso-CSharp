using System;
using AtividadeHeranca.Models;

namespace AtividadeHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Debito cartaoDebitoBianca = new Debito();

            cartaoDebitoBianca.titular = "Bianca Marangoni";

            cartaoDebitoBianca.DefinirNumero("1825 4935 4723 8910");

            cartaoDebitoBianca.Depositar(4500);

            cartaoDebitoBianca.ExibirSaldo();

            
        }
    }
}

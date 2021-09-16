using System;

namespace DebCred.Models
{
    public class Credito : Cartao
    {
        private double limite; //10000
        private double limiteDisponivel; ///?

        private string senha;

        public void DefinirSenha(string novaSenha)
        {
            this.senha = novaSenha;
        }
        public void DefinirNumero(string novoNumero)
        {
            this.numero = novoNumero;
        }
        public string ExibirNumero()
        {
            return this.numero;
        }
        public void DefinirLimite(double novoLimite)
        {
            this.limite = novoLimite;
            this.limiteDisponivel = this.limite;
        }

        //criar um método para Comprar

        public void Comprar(string senhaDigitada, double valorDaCompra)
        {
            if (senhaDigitada == this.senha)
            {
                // 10000                    3000
                if (this.limiteDisponivel >= valorDaCompra)
                {
                    // 7000                         10000         -   3000
                    this.limiteDisponivel = this.limiteDisponivel - valorDaCompra;
                }
                else
                {
                    Console.WriteLine("Limite insuficiente");
                }
            }else{
                Console.WriteLine("Senha inválida!");
            }//fim validação senha
        }

        public double ExibirSaldoDisponivel(){
            return this.limiteDisponivel;
        }

        public void PagarFatura(double valor){
            //quanto tenho que pagar?
            //                  10000   -     5500
            double fatura = this.limite - this.limiteDisponivel;

            if(valor <= fatura){
                this.limiteDisponivel = this.limiteDisponivel + valor; 
            }else{
                Console.WriteLine("Valor acima do custo de sua fatura");
            }
        }


    }
}
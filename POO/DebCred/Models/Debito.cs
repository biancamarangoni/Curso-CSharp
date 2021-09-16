using System;

namespace DebCred.Models
{
    public class Debito : Cartao
    {
        //atributo
        private double saldo;

        private string senha;

        //métodos
        public void DefinirSenha(string novaSenha){
            this.senha = novaSenha;
        }
        public string ExibirNumero(){
            return this.numero;
        }
        public void DefinirNumero(string numeroDigitado){
            this.numero = numeroDigitado;
        }

        //p/ transferir é necessário a senha, valor e a conta de destino
        public void Transferir(string senhaDigitada, double valorDaTransf, Debito contaDestino){
            if(senhaDigitada == this.senha){
                //faz a transferencia
                if(this.saldo >= valorDaTransf){
                    this.saldo = this.saldo - valorDaTransf;
                    contaDestino.saldo = contaDestino.saldo + valorDaTransf;
                }else{
                    Console.WriteLine("Saldo insuficiente!");
                }
            }else{
                Console.WriteLine("Senha inválida!");
            }
        }
        public void Depositar(double valor){
            this.saldo = this.saldo + valor;
        }

        //método p/ exibir
        public double ExibirSaldo(){
            return this.saldo;
        }
        
    }
}
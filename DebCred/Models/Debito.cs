using System;

namespace DebCred.Models
{
    public class Debito : Cartao
    {
        //atributo
        private double saldo;

        private string senha;

        public void DefinirSenha(string novaSenha){
            this.senha = novaSenha;
        }
        
        //métodos
        public string ExibirNumero(){
            return this.numero;
        }
        public void DefinirNumero(string numeroDigitado){
            this.numero = numeroDigitado;
        }

        //Para trasferir é necessário a senha, valor e a conta de destino

        //                           12345
        public void Transferir(string senhaDigitada, double valorDaTransferencia, Debito contaDestino){
            if(senhaDigitada == this.senha){
                //Vamos fazer a trasferência
                if(this.saldo >= valorDaTransferencia){
                    this.saldo = this.saldo - valorDaTransferencia;
                    contaDestino.saldo = contaDestino.saldo + valorDaTransferencia;
                 Console.WriteLine("Trasfência efetuada");
                }else{
                    Console.WriteLine("Saldo insuficiênte");
                }
            }else{
                Console.WriteLine("Senha inválida!");
            }
        }

        //criar um método para depositar dinheiro na conta
        //                          1000
        public void Depositar(double valor){
           
            this.saldo = this.saldo + valor; 
        }

        //Método para Exibir

        public double ExibirSaldo(){
            return this.saldo;
        }
        
    }
}
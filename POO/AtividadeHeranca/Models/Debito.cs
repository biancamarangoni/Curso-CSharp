namespace AtividadeHeranca.Models
{
    public class Debito : Cartao
    {
        public double saldo;
        public void Transferir(){

        }
         public void Depositar(double valor){
            this.saldo = this.saldo + valor;
        }

        public void ExibirSaldo(){
            System.Console.WriteLine($"O saldo do/a {this.numero} é de {this.saldo}");
        }
        public void DefinirNumero(string numeroDoCartao){
            this.numero = numeroDoCartao;
        }

    }
}
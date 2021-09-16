namespace DebCred.Models
{
    public class Credito : Cartao
    {
        //atributos
        private double limite;
        private double limiteDisponivel;
        private string senha;
        private double valorCompra;

        //métodos
        public void Limite(int valorLimite)
        {
            this.limite = valorLimite;
        }
        public void Comprar(int valorCompra)
        {
            this.limiteDisponivel = valorCompra;
        }
        public void PagarFatura(){
            this.limite = this.limite - valorCompra;
        }
    }
}
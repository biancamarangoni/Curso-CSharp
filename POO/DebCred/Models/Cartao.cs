namespace DebCred.Models
{
    public class Cartao
    {
        // atributos
        public string titular;  //todas as classes tem acesso
        protected string numero; //somente classes filhas tem acesso
        private string token;  //somente a própria classe tem acesso

        //Métodos
        public void Pagar(){

        }
        public string ValidarToken(){
            return this.token;
        }
    }
}
namespace DebCred.Models
{
    public class Cartao
    {
        //atributos
        public string titular; // todas classes tem acesso
        protected string numero;// Somente classes filhas tem acesso
        private string token; // Somente a própria classe tem acesso

        //Métodos
        public void Pagar(){

        }
        public string ValidarToken(){
            return this.token;
        }


    }
}
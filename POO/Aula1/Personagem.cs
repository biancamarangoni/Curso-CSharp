namespace Aula1
{
    public class Personagem
    {
        public string nome;
        
        public int idade;

        public string armadura;

        public string iA;

        private int vida = 100;

        public int soco;

        public int chute;

        public void ReceberAtaque(int ataque){
            this.vida = this.vida - ataque;
        }
             public int ExibirVida(){
                return vida;
            }
     }
}

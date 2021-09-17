namespace TsukaMotors.Models
{
    public class Veiculo
    {
        // // public string Tipo { get; set; } // Conseguimos acessar o atributo através do get e set
        // private string modelo;
        // //Set = Definir
        // public void SetModelo(string modeloDigitado){
        //     this.modelo = modeloDigitado;
        // }  
        // //Get = Pegar
        // public string GetModelo(){
        //     return this.modelo;
        // }
        // private string marca;
        // public string Marca
        // {
        //     get { return marca; }
        //     set { marca = value; }
        // }

        //Criamos os atributos utilizando Get e Set

        public string Tipo { get; set; }
        public string Marca { get; set; }

        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Chassi { get; set; }

        public Veiculo(string _tipo, string _marca, string _modelo, int _ano, string _chassi){
            Tipo = _tipo;
            Marca = _marca;
            Modelo = _modelo;
            Ano = _ano;
            Chassi = _chassi;
        }



    }
}
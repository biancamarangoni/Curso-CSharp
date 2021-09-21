using System;

namespace ExercMercearia.Models
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Funcionario(int _codigo, string _nome, string _email, string _senha, DateTime _dataCadastro){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = _dataCadastro;
        }

        internal Funcionario CadastroFuncionario()
        {
            throw new NotImplementedException();
        }
    }
}
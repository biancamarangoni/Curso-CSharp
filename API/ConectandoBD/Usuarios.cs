using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectandoBD
{
    class Usuarios
    {
        public int Id { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Senha { get; }

        //construtor para cadastro
        public Usuarios(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public Usuarios(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }


    }
}

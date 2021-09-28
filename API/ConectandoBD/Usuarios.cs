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

        public Usuarios(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

    }
}

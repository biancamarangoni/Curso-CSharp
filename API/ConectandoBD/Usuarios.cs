﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectandoBD
{
    class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuarios()
        {

        }

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

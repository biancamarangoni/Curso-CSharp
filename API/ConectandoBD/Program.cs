using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConectandoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            //var usuario = new Usuarios("Marcelo", "marcelo@gmail.com", "12345");
            CadastrarUsuario(InserirNaLista());
        }//fim main

        static void TestarConexao()
        {
            try
            {
                //tenta executar oq tem dentro
                var conn = Conexao.GetConnect(); //aqui retorna o link da conexão

                conn.Open();
                Console.WriteLine("Abriu a porta da esperança");
                conn.Close();
                Console.WriteLine("Fechou a porta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensagem de erro: " + ex.Message);
            }
        }//fim teste de conexao

        //método p/ inserir dados em uma lista

        static List<Usuarios> InserirNaLista()
        {
            //lista p receber usuarios
            List<Usuarios> listaUsuarios = new List<Usuarios>();

            //criando objetos usuarios
            var u1 = new Usuarios("Carlos", "tsuka@gmail.com", "1234");
            var u2 = new Usuarios("Ulisses", "ulisses@gmail.com", "4567");
            var u3 = new Usuarios("Leona", "leona@gmail.com", "7890");

            listaUsuarios.Add(u1);
            listaUsuarios.Add(u2);
            listaUsuarios.Add(u3);

            return listaUsuarios;
        }

        //enviar os dados da lista p/ o banco de dados -- cadastrar um usuario no BD
        static void CadastrarUsuario(Usuarios usuario)
        {

            var conn = Conexao.GetConnect();
            conn.Open();

            //criar a query

            var query = "insert into Usuarios (nomeUsuario, emailUsuario, senhaUsuario) values (@nome, @email, @senha)";
            var command = new SqlCommand(query, conn); //comando apenas solicitado
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = usuario.Nome;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = usuario.Email;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuario.Senha;
            //finalizando preenchimento da query 
            command.ExecuteNonQuery();

            conn.Close();
        }//fim cadastrar usuario

        static void CadastrarUsuario(List<Usuarios> listaUsuarios)
        {
            try
            {
                var conn = Conexao.GetConnect();
                conn.Open();

                foreach(var usuario in listaUsuarios)
                {
                    var query = "insert into Usuarios (nomeUsuario, emailUsuario, senhaUsuario) values (@nome, @email, @senha)";
                    var command = new SqlCommand(query, conn); //comando apenas solicitado
                    command.Parameters.Add("@nome", SqlDbType.VarChar).Value = usuario.Nome;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = usuario.Email;
                    command.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuario.Senha;
                    //finalizando preenchimento da query 
                    command.ExecuteNonQuery();
                }//fim foreach
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}

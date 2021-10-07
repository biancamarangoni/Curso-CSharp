using MVCRazorCRUD.Context;
using MVCRazorCRUD.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazorCRUD.Models
{
    public class Professor : UsuarioBase, IProfessor
    {
        public string Cargo { get; set; }

        public void AtualizarProf(Professor professor)
        {
            var connection = Conexao.GetConnect();
            connection.Open();
            var query = "update Professor set nomeProfessor = @nome, emailProfessor = @email, enderecoProfessor = @endereco, telefoneProfessor = @telefone, cargoProfessor = @cargo where idProfessor = @id";
            var command = new SqlCommand(query, connection);

            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = professor.Nome;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = professor.Email;
            command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = professor.Endereco;
            command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = professor.Telefone;
            command.Parameters.Add("@cargo", SqlDbType.VarChar).Value = professor.Cargo;
            command.Parameters.Add("@id", SqlDbType.Int).Value = professor.Id;
            command.ExecuteNonQuery();
        }

        public List<Professor> BuscarPorId(int id)
        {
            var connection = Conexao.GetConnect();
            connection.Open();

            var query = "select * from Professores where idProfessor = @id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            var dataSet = new DataSet();
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            var rows = dataSet.Tables[0].Rows;

            List<Professor> listaProf = new List<Professor>();

            foreach (DataRow item in rows)
            {
                var colunas = item.ItemArray;

                Professor professor = new Professor();

                professor.Id = int.Parse(colunas[0].ToString());
                professor.Nome = colunas[1].ToString();
                professor.Email = colunas[2].ToString();
                professor.Endereco = colunas[3].ToString();
                professor.Telefone = colunas[4].ToString();
                professor.Cargo = colunas[5].ToString();
                listaProf.Add(professor);
            }
            connection.Close();
            return listaProf;
        }
        public Professor CadastrarProf(Professor professor)
        {
            try
            {
                var connection = Conexao.GetConnect();
                connection.Open();
                var query = "insert into Professores (nomeProfessor, emailProfessor, enderecoProfessor, telefoneProfessor, cargoProfessor) values (@nome, @email, @end, @tel, @esc)";

                var command = new SqlCommand(query, connection);

                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = professor.Nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = professor.Email;
                command.Parameters.Add("@end", SqlDbType.VarChar).Value = professor.Endereco;
                command.Parameters.Add("@tel", SqlDbType.VarChar).Value = professor.Telefone;
                command.Parameters.Add("@esc", SqlDbType.VarChar).Value = professor.Cargo;

                command.ExecuteNonQuery();

                connection.Close();
                return professor;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Professor> ListarProf()
        {
            try
            {
                var connection = Conexao.GetConnect();
                connection.Open();
                //query
                var query = "select * from Professores";
                var command = new SqlCommand(query, connection);
                var dataSet = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                var rows = dataSet.Tables[0].Rows;

                List<Professor> listaDeProf = new List<Professor>();

                foreach (DataRow item in rows)
                {
                    Professor professor = new Professor();
                    var colunas = item.ItemArray;
                    professor.Id = int.Parse(colunas[0].ToString());
                    professor.Nome = colunas[1].ToString();
                    professor.Email = colunas[2].ToString();
                    professor.Endereco = colunas[3].ToString();
                    professor.Telefone = colunas[4].ToString();
                    professor.Cargo = colunas[5].ToString();

                    listaDeProf.Add(professor);
                }
                connection.Close();
                return listaDeProf;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoverProf(int id)
        {
            var connection = Conexao.GetConnect();
            connection.Open();

            var query = "delete from Professores where idProfessor = @id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            //aqui a query é executada no banco
            command.ExecuteNonQuery();
        }
    }
}



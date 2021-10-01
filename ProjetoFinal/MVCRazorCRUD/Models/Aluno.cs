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
    public class Aluno : UsuarioBase , IAluno 
    {
        public string Escolaridade { get; set; }

        public Aluno AlterarAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Aluno CadastrarAluno(Aluno aluno)
        {
            try
            {
                var connection = Conexao.GetConnect();
                connection.Open();
                var query = "insert into Alunos (nomeAluno, emailAluno, enderecoAluno, telefoneAluno, escolaridadeAluno) values (@nome, @email, @end, @tel, @esc)";

                var command = new SqlCommand(query, connection);

                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = aluno.Nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
                command.Parameters.Add("@end", SqlDbType.VarChar).Value = aluno.Endereco;
                command.Parameters.Add("@tel", SqlDbType.VarChar).Value = aluno.Telefone;
                command.Parameters.Add("@esc", SqlDbType.VarChar).Value = aluno.Escolaridade;

                command.ExecuteNonQuery();

                connection.Close();
                return aluno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Aluno> ListarAluno()
        {
            throw new NotImplementedException();
        }

        public Aluno RemoverAluno(int id)
        {
            throw new NotImplementedException();
        }
    }
}

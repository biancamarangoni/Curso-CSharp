using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ConectandoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            //var usuario = new Usuarios("Ana", "ana@gmail.com", "135");
            //CadastrarUsuario(usuario);
            //List<Usuarios> listaRetornada = ListarUsuarios();
            //ExibirListaDeUsuarios(listaRetornada);

            string opcao, nome, email, senha;
            int id;
            do
            {
                Console.WriteLine("Selecione a opção desejada:");
                Console.WriteLine("[1] - Cadastrar Usuário");
                Console.WriteLine("[2] - Listar");
                Console.WriteLine("[3] - Buscar por Id");
                Console.WriteLine("[4] - Atualizar Usuario");
                Console.WriteLine("[5] - Remover Usuario");
                Console.WriteLine("[0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do usuário");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o email do usuário");
                        email = Console.ReadLine();
                        Console.WriteLine("Digite a senha do usuário");
                        senha = Console.ReadLine();
                        var usuario = new Usuarios(nome, email, senha);
                        CadastrarUsuario(usuario);
                        break;
                    case "2":
                        ExibirListaDeUsuarios(ListarUsuarios());
                        break;
                    case "3":
                        Console.WriteLine("Digite o Id do usuário");
                        id = int.Parse(Console.ReadLine());
                        ExibirUsuario(PesquisaPorId(id));
                        break;
                    case "4":
                        Console.WriteLine("Digite o Id do usuario que deseja atualizar");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o e-mail: ");
                        email = Console.ReadLine();
                        
                        ExibirUsuario(AtualizarUsuario(id, nome, email));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Digite o Id do usuário para remover");
                        RemoverUsuario(int.Parse(Console.ReadLine()));
                        Console.ReadKey(); 
                        break;
                }
            } while (opcao != "0");
        }//fim main

        static Usuarios PesquisaPorId(int id)
        {
            //var listaDeUsuarios = ListarUsuarios();
            //var usuarioRetornado = listaDeUsuarios.FirstOrDefault(usuario => usuario.Id == id);
            //return usuarioRetornado;

            try
            {
                //estabelecendo a conexao
                var conn = Conexao.GetConnect();
                conn.Open();

                //definindo o comando SQL
                var query = "select * from Usuarios where idUsuario = @id";

                var command = new SqlCommand(query, conn);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                //criando o Dataset
                var dataSet = new DataSet(); //nesse momento está vazio
                var adapter = new SqlDataAdapter(command);//aqui já tenho os dados do banco
                adapter.Fill(dataSet);//inserimos os dados dentro do dataSet

                var rows = dataSet.Tables[0].Rows;

                Usuarios usuario = new Usuarios();
                //agr vamos transferir os dados do dataSet p/ um obj
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    int idUsuario = int.Parse(colunas[0].ToString());
                    string nome = colunas[1].ToString();
                    string email = colunas[2].ToString();
                    string senha = colunas[3].ToString();

                    usuario = new Usuarios(idUsuario, nome, email, senha);
                }

                conn.Close();
                return usuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops! Algo de errado não está certo: " + ex.Message);
                throw;
            }
            
        }

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

        //atualizar usuario
        static Usuarios AtualizarUsuario(int id, string nome, string email)
        {

            try
            {
                //estabelecendo a conexao
                var conn = Conexao.GetConnect();
                conn.Open();

                //definindo o comando SQL
                var query = "update Usuarios set nomeUsuario = @nome, emailUsuario = @email where idUsuario = @id";

                var command = new SqlCommand(query, conn);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                command.ExecuteNonQuery();

                conn.Close();
                return PesquisaPorId(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops! Algo de errado não está certo: " + ex.Message);
                throw;
            }

        }

        //remover usuario
        static void RemoverUsuario(int id)
        {
            var conn = Conexao.GetConnect();
            conn.Open();

            var query = "delete from Usuarios where idUsuario = @id";
            var command = new SqlCommand(query, conn);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            Usuarios usuario = PesquisaPorId(id);
            command.ExecuteNonQuery();
            
            Console.WriteLine($"Usuario {usuario.Nome} removido com sucesso!");

        }


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

                foreach (var usuario in listaUsuarios)
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
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }//fim cadastro usuario
        }
            //criar método para buscar os dados no BD
            static List<Usuarios> ListarUsuarios()
            {
                try
                {
                    List<Usuarios> listaDeUsuarios = new List<Usuarios>();
                    var connection = Conexao.GetConnect();
                    connection.Open();

                    //comando que será executado no SQL
                    var query = "select idUsuario, nomeUsuario, emailUsuario, senhaUsuario from Usuarios";

                    var command = new SqlCommand(query, connection);
                    var dataSet = new DataSet();
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet);

                    //aqui fica a lista de usuarios do banco de dados
                    var rows = dataSet.Tables[0].Rows;

                    //inserir cada usuario da lista rows dentro de uma lista de usuarios List<Usuarios>
                    foreach (DataRow item in rows)
                    {
                        var colunas = item.ItemArray;
                        int id = int.Parse(colunas[0].ToString());
                        string nome = colunas[1].ToString();
                        string email = colunas[2].ToString();
                        string senha = colunas[3].ToString();

                        //construir um objeto usuario com os dados acima
                        Usuarios usuario = new Usuarios(id, nome, email, senha);

                        //inserir o usuario na lista 
                        listaDeUsuarios.Add(usuario);
                    }//fim foreach

                    connection.Close();
                    return listaDeUsuarios;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ops... Encontramos um erro: " + ex.Message);
                    throw;
                }
            }//fim listar usuarios

            //metodo para exibir os dados de uma lista de usuarios

            static void ExibirListaDeUsuarios(List<Usuarios> listaUsuarios)
            {
                Console.WriteLine("Usuários cadastrados");
                foreach (var item in listaUsuarios)
                {
                    Console.WriteLine($"Id: {item.Id} Nome: {item.Nome} Email: {item.Email} Senha: {item.Senha}");
                }
            }

            static void ExibirUsuario(Usuarios usuario)
            {
                Console.WriteLine($"Id: {usuario.Id} Nome: {usuario.Nome} Email: {usuario.Email} Senha: {usuario.Senha}");
            }
        }    
}

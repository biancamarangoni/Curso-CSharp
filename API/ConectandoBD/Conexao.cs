using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectandoBD
{
    class Conexao
    {
        //string que acessa ao banco de dados
        private static string ConStr = @"Data Source=Localhost\servidortarde;Initial Catalog=BancoDeDados;Integrated Security=True";

        //método que conecta a uma base de dados
        public static SqlConnection GetConnect()
        {
            var conn = new SqlConnection(ConStr);

            return conn;
        }
    }
}

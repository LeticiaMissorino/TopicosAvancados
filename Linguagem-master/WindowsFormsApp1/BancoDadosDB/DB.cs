using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace BancoDadosDB
{
    public class DB: IDisposable
    {
        private SqlConnection conexao; //responsável por fazer conexão com o banco

        public DB()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSQLServer"].ConnectionString); //vai procurar no arquivo  pp. config do proejto windows form 
            conexao.Open();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string query)
        {
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoRetorno(string query)
        {
            var cmd = new SqlCommand(query, conexao);
            return cmd.ExecuteReader();
        }
    }
}

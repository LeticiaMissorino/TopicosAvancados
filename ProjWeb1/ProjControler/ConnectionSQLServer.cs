using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjControler
{
    public class ConnectionSQLServer
    {
        SqlConnection con;
        public SqlConnection getConnectionSQLServer() {

            string conexao = ConfigurationManager.ConnectionStrings["ConexaoSQLServer"].ConnectionString;
            con = new SqlConnection();
            con.ConnectionString = conexao;

            return con;
        }


    }
}

using ProjModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjControler
{
    public class ControllerMensagem
    {
        ConnectionSQLServer conexao;
        SqlConnection con;
        public ControllerMensagem()
        {
            con = new  SqlConnection();
            con = conexao.getConnectionSQLServer();

        }
        public bool Insert(Mensagem msg) {
            bool status = false;

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DBO.PR_INSERIR_MENSAGEM";
            cmd.Parameters.Add(new SqlParameter("@DESCRICAO",msg.descricao));

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();


            return true;
        }

    }
}

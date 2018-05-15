using ProjModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjController
{
    public class ControllerMonitoramento
    {
        SqlConnection con;

        public ControllerMonitoramento()
        {
            con = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLSERVER"].
                ConnectionString);
            //con.Open();
        }

        public bool Insert(Monitoramento moni)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DBO.upInserirMonitoramento";
            cmd.Parameters.Add(new SqlParameter ("@descricao", moni.descricao) );
            cmd.Parameters.Add(new SqlParameter("@qtdeCamera", moni.qtdeCamera));
            cmd.Parameters.Add(new SqlParameter("@nomeCliente", moni.nomeCliente));
            cmd.Parameters.Add(new SqlParameter("@valorPacote", moni.valorPacote));
            cmd.Parameters.Add(new SqlParameter("@isFidelidade", moni.isFidelidade));
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public void Listar(){

        }

    }
}

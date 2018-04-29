using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBanco
{
    public  class CargoDB
    {
        private DB db;

        public bool insert(Cargo cargo)
        {
            try
            {
                string sql = "INSERT INTO Cargo (DESCRICAO)" +
                         " VALUES ('" + cargo.Descricao + "')";
                using (db = new DB())
                {
                    db.ExecutaComando(sql);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Cargo> ListarCargo()
        {
            using (db = new DB()) 
            {
                var sql = "SELECT id, descricao FROM Cargo";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Cargo> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listTipo = new List<Cargo>();

            while (retorno.Read())
            {
                var item = new Cargo()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["descricao"].ToString(),
                };

                listTipo.Add(item);
            }
            return listTipo;
        }


    }
}

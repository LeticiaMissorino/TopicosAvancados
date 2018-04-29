using System;
using Controle;
using Entidade;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controle2
{
    public class NivelDB
    {
        private DB db;

        public bool insert(Nivel nivel)
        {
            try
            {
                string sql = "INSERT INTO nivel (DESCRICAO)" +
                         " VALUES ('" + nivel.Descricao + "')";
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

        public List<Nivel> ListarNivel()
        {
            using (db = new DB()) 
            {
                var sql = "SELECT id, descricao FROM nivel";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Nivel> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listNivel = new List<Nivel>();

            while (retorno.Read())
            {
                var item = new Nivel()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["descricao"].ToString(),
                };

                listNivel.Add(item);
            }
            return listNivel;
        }
    }
}

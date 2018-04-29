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
    public class ProblemaDB
    {

        private DB db;

        public bool insert(Problema problema)
        {
            try
            {
                string sql = "INSERT INTO Problema (descricao, tipo, nivelDificudade, dataCriacao)" +
                         " VALUES ('" + problema.Descricao + "', " + "" + problema.Tipo.Id + "" + ", " + "" + problema.NivelDificuldade.Id + "" + ", " + "'" + problema.DataCriacao + "'" + " )";
                using (db = new DB())
                {
                    db.ExecutaComando(sql);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public List<Problema> ListarProblema()
        {
            using (db = new DB())
            {
                var sql = "SELECT Problema.id, Problema.descricao, tipo.descricao as tipo , nivel.descricao as nivel, dataCriacao FROM Problema inner join tipo on tipo.id = Problema.id inner join Nivel on Nivel.id = Problema.nivelDificudade";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Problema> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listProblema = new List<Problema>();

            while (retorno.Read())
            {
                var item = new Problema()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["descricao"].ToString(),
                    Tipo = new Tipo()
                    {
                       // Id = Convert.ToInt32(retorno["idTipo"]),
                        Descricao = retorno["tipo"].ToString()
                    },
                    NivelDificuldade = new Nivel()
                    {
                        //Id = Convert.ToInt32(retorno["idnivel"]),
                        Descricao = retorno["nivel"].ToString()

                    },
                    DataCriacao = Convert.ToDateTime(retorno["dataCriacao"]),
                };

                listProblema.Add(item);
            }
            return listProblema;
        }
    }
}

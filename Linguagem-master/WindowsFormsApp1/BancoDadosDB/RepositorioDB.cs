using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosDB
{
   public class RepositorioDB
    {
        private DB db;

        public bool insert(Repositorio resp )
        {
            try
            {
                string sql = "INSERT INTO repositorio (nome, idLinguagem, dt)" +
                         " VALUES ('" + resp.nome + "', " + "" +  "" + resp.ling.id + "" + ", " + "'" + resp.dt + "'" + " )";
                using (db = new DB())
                {
                    db.ExecutarComando(sql);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public List<Repositorio> ListarResp()
        {
            using (db = new DB())
            {
                var sql = "select (LINGUAGEM.nome + '-' + CONVERT(vARCHAR(10),LINGUAGEM.pontuacao)) AS linguagem , Repositorio.id, Repositorio.nome, Repositorio.dt from LINGUAGEM inner join Repositorio on Repositorio.idLinguagem = LINGUAGEM.id ";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Repositorio> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listResp = new List<Repositorio>();

            while (retorno.Read())
            {
                var item = new Repositorio()
                {
                    id = Convert.ToInt32(retorno["id"]),
                    nome = retorno["nome"].ToString(),
                    ling = new Linguagem()
                    {
                        nome = retorno["linguagem"].ToString()
                    },
                    dt = Convert.ToDateTime(retorno["dt"]),
                };

                listResp.Add(item);
            }
            return listResp;
        }
    }
}

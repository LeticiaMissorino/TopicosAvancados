using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDadosDB
{
    public class LinguagemDB
    {
        private DB db;
        public bool Insert(Linguagem linguagem)
        {
            try
            {
                string sql = "INSERT INTO Linguagem (NOME, PONTUACAO) VALUES ('" + linguagem.nome + "' "+ ",'" + linguagem.pontuacao + "' )";

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

        public List<Linguagem> ListarTipo()
        {
            using (db = new DB())// Instancia a classe DB delimitando o inicio e fim
                                 // Inicio construtor da classe e abre conexão com o banco
                                 // A base de dados 
                                 // Fim Chama o metodo Dispose()
                                 //da interface IDisposable e fecha conexão com o banco de dados.
            {
                var sql = "SELECT id, NOME, PONTUACAO FROM LINGUAGEM";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);

            }
        }

        private List<Linguagem> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listMensagem = new List<Linguagem>();

            while (retorno.Read())
            {
                var item = new Linguagem()
                {
                    id =  Convert.ToInt32( retorno["id"].ToString()),
                    nome = retorno["Nome"].ToString(),
                    pontuacao =  Convert.ToInt32(retorno["Pontuacao"].ToString()),
                };
                listMensagem.Add(item);
            }
            return listMensagem;
        }
    }
}



using System;
using System.Collections.Generic;
using Entidade;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControleBanco
{
    public class FabricanteDB
    {
        private DB db;

        public bool insert(Fabricante Fabricante)
        {
            try
            {
                string sql = "INSERT INTO Fabricante (DESCRICAO, cargo)" +
                         " VALUES ('" + Fabricante.Descricao + "', "+ "" + Fabricante.cargo + ")";
                using (db = new DB())
                {
                    db.ExecutaComando(sql);
                }
            }
            catch (Exception e )
            {
                return false;
            }
            return true;
        }

        public List<Fabricante> ListarFabricante()
        {
            using (db = new DB())
            {
                var sql = "SELECT fabricante.id, Fabricante.descricao, Cargo.id , cargo.descricao as cargo  FROM Fabricante inner join Cargo on cargo.id = Fabricante.id";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Fabricante> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {
            var listFabricante = new List<Fabricante>();

            while (retorno.Read())
            {
                var item = new Fabricante()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["descricao"].ToString(),
                    cargo = new Cargo() { Descricao = retorno["cargo"].ToString() } ,
                };

                listFabricante.Add(item);
            }
            return listFabricante;
        }

    }
}

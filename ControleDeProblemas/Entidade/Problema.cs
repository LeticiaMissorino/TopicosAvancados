using System;

namespace Entidade
{
    public class Problema
    {

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public Tipo Tipo { get; set; }
        public Nivel NivelDificuldade { get; set; }

        #endregion Propriedades

        #region Métodos


        #endregion

    }
}

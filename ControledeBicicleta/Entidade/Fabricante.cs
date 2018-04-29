using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
   public  class Fabricante
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Cargo cargo { get; set; }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}

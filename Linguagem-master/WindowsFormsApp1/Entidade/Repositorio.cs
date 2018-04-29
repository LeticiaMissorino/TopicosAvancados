using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Repositorio
    {
        public int id { get; set; }
        public String nome { get; set; }
        public Linguagem ling { get; set; }
        public DateTime dt { get; set; }

    }
}

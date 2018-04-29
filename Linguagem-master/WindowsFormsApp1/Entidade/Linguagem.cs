using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Linguagem
    {
        public int id { get; set; }
        public String nome { get; set; }
        public int pontuacao { get; set; }

        public override string ToString()
        {
            return this.nome + "-" + this.pontuacao;
        }
    }
}

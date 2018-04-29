using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Bicicleta
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public Fabricante fabricante { get; set; }
        public DateTime dtFabricacao { get; set; }


    }
}

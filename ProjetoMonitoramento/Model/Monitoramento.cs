using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Monitoramento
    {
        public string descricao { get; set; }
        public int qtdeCamera { get; set; }
        public string nomeCliente { get; set; }
        public decimal valorPacote { get; set; }
        public bool isFidelidade { get; set; }
        public int pacote { get; set; }

    }
}

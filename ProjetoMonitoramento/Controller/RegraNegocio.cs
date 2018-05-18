using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RegraNegocio
    {

        public decimal CalculoValor(decimal valor, int qtde, bool fidelidade)
        {

            if (qtde >= 1 && qtde <= 2)
                if (fidelidade == true)
                    valor = valor - (0.1m * valor);
                else
                    valor = valor - (0.5m * valor);
            else if (qtde >= 3 && qtde <= 4)
                if (fidelidade == true)
                    valor = valor - (0.2m * valor);
                else
                    valor = valor - (0.1m * valor);
            else if (qtde >= 5)
                if (fidelidade == true)
                    valor = valor -( 0.3m * valor);
                else
                    valor = valor - (0.15m * valor);
            return valor;

        }

        public int Pacote(int qtde, bool fidelidade)
        {
            int pacote = 0;
            if (qtde >= 1 && qtde <= 2)
                if (fidelidade == true)
                    pacote = 4;
                else
                    pacote = 1;
            else if (qtde >= 3 && qtde <= 4)
                if (fidelidade == true)
                    pacote = 5;
                else
                    pacote = 2;
            else if (qtde >= 5)
                if (fidelidade == true)
                    pacote = 6;
                else
                    pacote = 3;
            return pacote;

        }

    }
}

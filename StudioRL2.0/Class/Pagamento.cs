using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioRL2._0.Class
{
    class Pagamento
    {
        public int atualizarValorRestante(int valorAberto, int valorPago)
        {
            int valorRestante = 0;

            valorRestante = valorAberto - valorPago;

            return valorRestante;
        }
    }
}

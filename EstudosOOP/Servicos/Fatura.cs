using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Servicos
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }        

        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return $"Pagamento Básico: {PagamentoBasico.ToString("F2",CultureInfo.InvariantCulture)}" +
                $"\nTaxa: {Taxa.ToString("F2",CultureInfo.InvariantCulture)}" +
                $"\nPagamento Total: {PagamentoTotal.ToString("F2",CultureInfo.InvariantCulture)}";     
        }
    }
}

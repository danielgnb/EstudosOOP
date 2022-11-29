using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Servicos
{
    internal class AluguelCarros
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelCarros(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }
    }
}

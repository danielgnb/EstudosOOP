using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Servicos
{
    internal class ServicoAluguel
    {
        public double PrecoPorHora { get; set; }
        public double PrecoPorDia { get; set; }
        private ITaxaServico _taxaServico;

        public ServicoAluguel(double precoPorHora, double precoPorDia, ITaxaServico _taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            this._taxaServico = _taxaServico;
        }

        public void ProcessarFatura(AluguelCarros aluguelCarros)
        {
            TimeSpan duracao = aluguelCarros.Fim.Subtract(aluguelCarros.Inicio);

            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaServico.Tax(pagamentoBasico);

            aluguelCarros.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}

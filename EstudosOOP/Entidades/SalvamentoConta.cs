using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades
{
    internal sealed class SalvamentoConta : Conta
    {
        public double TaxaJuros { get; set; }

        public SalvamentoConta()
        {

        }

        public SalvamentoConta(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular,saldo)
        {
            this.TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public sealed override void Saque(double quantia) //O método Saque da classe pai foi sobrescrito e selado.
        {
            //É possível também utilizar o código já escrito na classe pai com o base.NomeDoMétodo();
            //base.Saque(quantia);            
            Saldo -= quantia;
        }
    }  
}

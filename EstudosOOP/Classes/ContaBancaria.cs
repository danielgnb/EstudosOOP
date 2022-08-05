using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double ValorDepositoInicial { get; set; }
        public double Saldo { get; private set; }     

        public ContaBancaria() { }
        public ContaBancaria(int numConta, string titular)
        {
            NumeroConta = numConta;
            TitularConta = titular;
        }

        public void AtualizarDadosConta(double depositoInicial)
        {
            Saldo += depositoInicial;
        }

        public double Saque(double saque)
        {
            return this.Saldo = (this.Saldo - saque) - 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {TitularConta}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

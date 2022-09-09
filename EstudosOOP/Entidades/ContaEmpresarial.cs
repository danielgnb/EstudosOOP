using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosOOP.Entidades;

namespace EstudosOOP.Entidades
{
    internal class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial()
        {

        }

        // Construtor criado utilizando as propriedades da classe Herdada pelo uso do : base()
        public ContaEmpresarial(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero,titular,saldo)
        { 
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if(quantia <= LimiteEmprestimo)
            Saldo += quantia;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Número da conta: {this.Numero}");
            sb.AppendLine($"Titular da conta: {this.Titular}");
            sb.AppendLine($"Saldo da conta: {this.Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
            sb.Append($"Limite de empréstimo: {LimiteEmprestimo.ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}

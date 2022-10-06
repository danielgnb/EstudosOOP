using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades
{
    internal abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; } = string.Empty;
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double quantia) // Colocando esse virtual, podemos sobrescrever esse método em outras classes filho.
        {
            Saldo -= quantia + 5.00;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}

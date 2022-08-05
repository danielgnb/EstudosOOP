using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP
{
    internal static class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ConverterParaReal(double real, double cotacao)
        {
            double valorConvertido;

            valorConvertido = real * cotacao;
            return valorConvertido + valorConvertido * Iof/100.0;
        }
    }
}

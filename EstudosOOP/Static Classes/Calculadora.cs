using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Static_Classes
{
    internal static class Calculadora
    {
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }

        public static void Triplicar(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}

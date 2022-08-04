using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * Largura + Altura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * 2 + Altura * 2);
        }
    }
}

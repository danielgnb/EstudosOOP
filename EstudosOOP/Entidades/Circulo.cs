using EstudosOOP.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades
{
    internal class Circulo : Figura
    {
        public double Raio { get; set; }
        public Circulo(double Raio, Cor cor) : base(cor)
        {
            this.Raio = Raio;
        }

        public override double Area()
        {
            return Raio * Raio * Math.PI;
        }
    }
}

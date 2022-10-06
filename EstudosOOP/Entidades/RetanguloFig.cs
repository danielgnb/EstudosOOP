using EstudosOOP.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades
{
    internal class RetanguloFig : Figura
    {      
        public double Largura { get; set; }
        public double Altura { get; set; }
        public RetanguloFig(double largura, double altura, Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;    
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}

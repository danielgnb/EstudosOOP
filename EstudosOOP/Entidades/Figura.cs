using EstudosOOP.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades
{
    internal abstract class Figura
    {
        public Cor Cor { get; set; }

        protected Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}

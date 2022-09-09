using EstudosOOP.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades
{    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return $"ID={Id}, Momento:{Momento}, Status={Status}"; 
        }
    }    
}

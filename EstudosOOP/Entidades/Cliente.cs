using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Cliente))
            {
                return false;
            }
            Cliente c = obj as Cliente;
            return Email.Equals(c.Email);    
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();  
        }
    }
}

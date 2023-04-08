using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Classes
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tier { get; set; }

        public Categoria(int id, string name, int tier)
        {
            Id = id;
            Nome = name;
            Tier = tier;
        }

        public Categoria() { }

        public override string ToString()
        {
            return $"ID:{Id}, Nome:{Nome}, Tier:{Tier}";
        }
    }
}

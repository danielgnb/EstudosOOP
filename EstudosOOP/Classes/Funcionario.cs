using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP
{
    internal class Funcionario
    {
        public string Nome;
        public int Idade;

        public Funcionario(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public Funcionario()
        {

        }
    }
}

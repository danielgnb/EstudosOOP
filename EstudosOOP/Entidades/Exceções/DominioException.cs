using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades.Exceções
{
    internal class DominioException : ApplicationException
    {
        public DominioException(string mensagem) : base(mensagem) { }

        /*
         * A subclasse DominioException está herdando a superclasse ApplicationException para utilizar dos seus componentes.
         */ 
    }
}

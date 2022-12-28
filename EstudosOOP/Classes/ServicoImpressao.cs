using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Classes
{
    internal class ServicoImpressao<T>
    {
        /* Classe parametrizada por tipo <T> fazendo com que ela aceite diferentes tipagens sem perder perfomance e utilizando reuso */

        private T[] _valores = new T[10];
        private int _contador = 0;

        public void AdicionarValor(T valor)
        {
            if (_contador == 10)
            {
                throw new InvalidOperationException("O vetor já está cheio!");
            }
            _valores[_contador] = valor;
            _contador ++;
        }

        public T Primeiro()
        {
            if (_contador == 0)
            {
                throw new InvalidOperationException("O vetor está vazio!");
            }
            return _valores[0];
        }

        public void Imprimir()
        {
            Console.Write("[");
            for (int i = 0; i < _contador - 1; i++)
            {
                Console.Write(_valores[i] + ", ");
            }
            if (_contador > 0)
            {
                Console.Write(_valores[_contador - 1]);
            }
            Console.WriteLine("]");
        }
    }
}

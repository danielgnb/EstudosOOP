using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Entidades.Enums
{
    internal enum PedidoStatus : int
    {
        PagamentoPendente,
        Processando,
        Enviado,
        Entregue
    }
}

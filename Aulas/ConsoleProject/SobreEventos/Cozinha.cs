using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEventos
{
    internal class Cozinha
    {
        public delegate void TabletGarcomEventHandler(object fonte, EventArgsPedidoPronto e);   // Irá delegar os métodos
        public event TabletGarcomEventHandler MsgPedidoProntoEvento;                            // Responsável pelos eventos.
        public void EnviaMsgPedidoPronto(UInt32 numPedido)
        {
            if (MsgPedidoProntoEvento != null)
            {
                EventArgsPedidoPronto e = new EventArgsPedidoPronto(numPedido);
                MsgPedidoProntoEvento(this, e);
            }
        }
    }
}

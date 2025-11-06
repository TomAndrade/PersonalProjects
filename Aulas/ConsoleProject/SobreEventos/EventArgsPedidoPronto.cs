using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEventos
{
    internal class EventArgsPedidoPronto : EventArgs
    {
        private UInt32 numPedido;
        public UInt32 NumPedido { get => numPedido; }

        public EventArgsPedidoPronto(uint numPedido)
        {
            this.numPedido = numPedido;
        }
    }
}

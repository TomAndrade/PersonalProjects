using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEventos
{
    internal class TabletGarcom
    {
        private string nome;
        public void MostraMsgPedidoProntoCozinha(object fonte, EventArgsPedidoPronto e) // Este método será chamado quando o método EnviaMsgPedidoPronto() for chamado.
        {
            Console.WriteLine($"{nome}, o pedido {e.NumPedido} está pronto na cozinha.");
        }

        public TabletGarcom(string nome, Cozinha cozinha)
        {
            this.nome = nome;
            cozinha.MsgPedidoProntoEvento += MostraMsgPedidoProntoCozinha; // Cadastrará o método em questão toda vez que um garçom for criado.
        }
    }
}

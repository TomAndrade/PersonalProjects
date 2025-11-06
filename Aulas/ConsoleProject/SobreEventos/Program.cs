using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEventos
{
    internal class Program
    {
        static Random random = new Random();
        static int numPedidos = 0;
        static void Main(string[] args)
        {
            Cozinha hamburgueria = new Cozinha();
            Cozinha comidaJaponesa = new Cozinha();

            TabletGarcom tabletFulano = new TabletGarcom("Fulano",hamburgueria);
            TabletGarcom tabletCiclano = new TabletGarcom("Ciclano",hamburgueria);
            TabletGarcom tabletBeltrano = new TabletGarcom("Beltrano",hamburgueria);
            TabletGarcom tabletFonseca = new TabletGarcom("Fonseca",comidaJaponesa);
            TabletGarcom tabletSilva = new TabletGarcom("Silva",comidaJaponesa);
            TabletGarcom tabletMizuki = new TabletGarcom("Mizuki",comidaJaponesa);

            Cozinha[] cozinhas = {hamburgueria,comidaJaponesa};

            for (int i = 0; i < cozinhas.Length; i++)
            {
                for (int j = 0; j< random.Next(2, 10); j++)
                {
                    cozinhas[i].EnviaMsgPedidoPronto((UInt32)random.Next(1,999));
                    numPedidos++;
                }
            }
            Console.WriteLine($"Número de pedidos realizados: {numPedidos}");
        }
    }
}

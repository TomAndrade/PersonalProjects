using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreHerancas
{
    internal class Aviao: Veiculo
    {
        private UInt32 altitude;

        public Aviao(uint numRodas, uint numPortas) : base(numRodas, numPortas)
        {
            altitude = 0;
        }

        public uint Altitude
        {
            get { return altitude; }
        }

        public void Decolar(uint velocidade, uint alt)
        {
            if (EstaLigado)
            {
                Console.WriteLine("Decolando...");
                altitude = alt;
                Velocidade = velocidade;
                Console.WriteLine("Velocidade atual do avião: "+Velocidade);
                Console.WriteLine("Altitude atual do avião: "+altitude);

            }
            else { Console.WriteLine("Avião desligado."); }
        }

        public void Pousar()
        {
            Console.WriteLine("Pousando...");
            altitude = 0;
            Velocidade = 0;
            Console.WriteLine("Velocidade atual do avião: "+Velocidade);
            Console.WriteLine("Altitude atual do avião: "+altitude);

        }

    }
}

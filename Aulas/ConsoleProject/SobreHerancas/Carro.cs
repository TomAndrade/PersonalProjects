using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreHerancas
{
    internal class Carro: Veiculo
    {
        public void Acelerar(UInt32 velocidade)
        {
            if (EstaLigado)
            {
                Console.WriteLine("Acelerando...");
                Velocidade = velocidade;
                Console.WriteLine("Velocidade do carro atual: " + Velocidade);
            }
            else { Console.WriteLine("Carro desligado."); }
        }
        public void Frear()
        {
            Console.WriteLine("Freando...");
            Velocidade = 0;
            Console.WriteLine("Velocidade atual: " + Velocidade);
        }
        public Carro(uint numRodas, uint numPortas): base(numRodas, numPortas) // O atual número de rodas e portas será o padrão para esta classe.
        {

        }
    }
}

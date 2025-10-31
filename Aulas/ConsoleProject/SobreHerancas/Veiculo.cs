using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreHerancas
{
    internal class Veiculo
    {
        private UInt32 numRodas;
        private UInt32 numPortas;
        private UInt32 velocidade;
        private bool estaLigado;

        public uint NumRodas { get => numRodas; }
        public uint NumPortas { get => numPortas; }
        public uint Velocidade { get => velocidade; set => velocidade = value; }
        public bool EstaLigado { get => estaLigado; set => estaLigado = value; }

        public void Ligar()
        {
            Console.WriteLine("Ligado.");
            estaLigado = true;
        }
        public void Desigar()
        {
            Console.WriteLine("Desligado.");
        }

        public Veiculo(uint numRodas, uint numPortas)
        {
            this.numRodas = numRodas;
            this.numPortas = numPortas;
            velocidade = 0;
            estaLigado = false;
        }
    }
}

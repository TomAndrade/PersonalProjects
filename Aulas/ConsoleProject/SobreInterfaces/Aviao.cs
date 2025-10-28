using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreInterfaces
{
    internal class Aviao: IVeiculo
    {
        public void Ligar()
        {
            Console.WriteLine("Avião ligado");
        }
        public void Desligar()
        {
            Console.WriteLine("Avião desligado");

        }
        public void AbrirPorta()
        {
            Console.WriteLine("Porta do avião aberta");

        }
        public void FecharPorta()
        {
            Console.WriteLine("Porta do avião fechada");

        }
        public void Decolar()
        {
            Console.WriteLine("Decolando...");
        }
    }
}

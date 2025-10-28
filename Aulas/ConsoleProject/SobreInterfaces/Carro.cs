using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreInterfaces
{
    public class Carro: IVeiculo
    {
        public void Ligar()
        {
            Console.WriteLine("Carro ligado");
        }
        public void Desligar()
        {
            Console.WriteLine("Carro desligado");

        }
        public void AbrirPorta()
        {
            Console.WriteLine("Porta do carro aberta");

        }
        public void FecharPorta()
        {
            Console.WriteLine("Porta do carro fechada");

        }
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.Ligar();
            meuCarro.AbrirPorta();
            meuCarro.FecharPorta();
            meuCarro.Desligar();
            Aviao meuAviao = new Aviao();
            meuAviao.Ligar();
            meuAviao.AbrirPorta();
            meuAviao.FecharPorta();
            meuAviao.Desligar();
        }
    }
}

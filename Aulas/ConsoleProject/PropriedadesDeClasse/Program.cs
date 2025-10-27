using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesDeClasse
{
    public class Carro
    {
        private string marca;
        private double velocidade = 0;
        private bool estaLigado = false;

        public bool EstaLigado
        {
            get { return estaLigado; }
            set { if (velocidade == 0) estaLigado = value; else return; }
        }
        public double Velocidade
        {
            get { return velocidade; }
            set { if (estaLigado) velocidade = value; else return; }
        }
        public UInt32 NumPortas
        {
            // Uma propriedade vazia, sem atributos.
            get; set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

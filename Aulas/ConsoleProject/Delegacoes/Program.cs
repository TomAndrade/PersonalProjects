using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacoes
{
    internal class Program
    {
        public delegate double MinhasDelegacoes(double x, double y);
        public static double ExemploSoma(double x, double y){ double retorno = x + y; Console.WriteLine("Somando..."+retorno); return retorno;}
        public static double ExemploMulti(double x, double y)
        { 
            double retorno = x * y; 
            Console.WriteLine("Multiplicando..." + retorno); 
            return retorno;
        }
        public static double ExemploSubtrai(double x, double y){ double retorno = x - y; Console.WriteLine("Subtraindo..."+retorno); return retorno;}
        public static double ExemploDivide(double x, double y){ double retorno = x / y; Console.WriteLine("Dividindo..."+retorno); return retorno;}

        // Um método que recebe como parâmetro um delegate...
        public static void ExecutaOperacao(MinhasDelegacoes delegacoes)
        {
            delegacoes(50,10);
        }

        static void Main(string[] args)
        {
            MinhasDelegacoes operacoes;
            operacoes = ExemploSoma;
            operacoes += ExemploSubtrai;
            operacoes += ExemploMulti;
            operacoes += ExemploDivide;
            double resultadoDelegado = operacoes(100,210);
            Console.WriteLine("Exemplo de delegação para vários métodos : "+ resultadoDelegado);

            ExecutaOperacao(ExemploMulti);
        }
    }
}

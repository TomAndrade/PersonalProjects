using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UsandoDLLNativa
{
    internal class MoldeDLLNativa
    {
        // Use a palavra reservada "extern" para avisar à IDE que esta função está sendo implementada de outro lugar.
        // Como é do tipo extern, precisa especificar de onde vem.
        [DllImport(@"D:\CS\Aulas\ConsoleProject\ImportandoDLL\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Soma(double a, double b);

        [DllImport(@"D:\CS\Aulas\ConsoleProject\ImportandoDLL\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Media(double[] a, int quantidade);

        [DllImport(@"D:\CS\Aulas\ConsoleProject\ImportandoDLL\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecebeVetor([In, Out] int[] Vetor, int Tamanho);  //In e Out significa que o valor do parâmetro é de entrada e de saída.
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado = MoldeDLLNativa.Soma(1,2);
            double[] valMedia = {1,2,3,4,5};
            double resultadoMedia = MoldeDLLNativa.Media(valMedia,valMedia.Length);
            int[] vetor1 = new int[3];
            MoldeDLLNativa.RecebeVetor(vetor1,vetor1.Length);
            Console.WriteLine("Resultado da soma: "+resultado);
            Console.WriteLine("Resultado da média: "+resultadoMedia);
            if (vetor1[0] == 0 && vetor1[1] == 1 && vetor1[2] == 2)
            {
                Console.WriteLine("Vetor inserido corretamente.");
            }
            else
            {
                Console.WriteLine("Vetor não inserido corretamente.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeNumberException
{
    internal class Program
    {
        static void VerificaNum(int num)
        {
            if (num < 0)
            {
                throw new NumNegativoExcecao(num);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                VerificaNum(numero);
                Console.WriteLine($"Número {numero} é positivo.");

            }catch(NumNegativoExcecao e)
            {
                Console.WriteLine("Exceção específica: "+e.Message);
            }
            finally
            {
                Console.WriteLine("Encerrando...");
            }
        }
    }
}

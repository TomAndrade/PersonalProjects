using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string numFatorial;

            while (true)
            {
                Console.Write("Digite o fatorial - Digite 's' para sair: ");
                numFatorial = Console.ReadLine();

                if (numFatorial.Equals("s") || numFatorial.Equals("S"))
                {
                    break;
                }
                else
                {
                    try
                    {
                        int valor = Convert.ToInt32(numFatorial);
                        if (valor == 0)
                        {
                            Console.WriteLine("0! = 1");
                        }
                        else if (valor < 0)
                        {
                            Console.WriteLine("Valor não pode ser negativo.");
                        }
                        else
                        {
                            int resultado = 1;
                            Console.Write(valor + "!: ");
                            for (int i = valor; i >= 0; i--)
                            {
                                resultado *= i;
                                if (i == 1)
                                {
                                    Console.Write(i + " = " + resultado);
                                    Console.WriteLine("\r\nFeito");
                                    break;
                                }
                                Console.Write(i + " x ");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Inválido: "+e.Message);
                    }
                }
            }
        }
    }
}

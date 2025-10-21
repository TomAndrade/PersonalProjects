using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Loginz\r\nUser:");
            string username = Console.ReadLine();
            Console.Write("\r\nPassword: ");
            string password = "";

            // Uma boa prática de assegurar a senha do usuário é separando cada caractere 
            while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)  // Se a tecla pressionada for igual a tecla Enter...
                {
                    break;
                }
                else
                {
                    password += tecla.KeyChar;
                }
            }
        }
    }
}

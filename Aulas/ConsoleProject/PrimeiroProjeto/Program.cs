using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AULA 7 - tipos e conversões
            // Nesta ordem: ano, mês, dia, hora, min, seg;
            DateTime dataNasc = new DateTime(1993,2,10,10,0,0);
            //Console.WriteLine(dataNasc.Year);

            // AULA 8 - Ler linhas
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Olá, "+Nome);

            Console.Write("Idade: ");
            string Idade = Console.ReadLine();
            Console.WriteLine(Idade);

            Console.Write("Pressione uma tecla: ");
            char teclaPressionada = Console.ReadKey(true).KeyChar;
            string teclaPressionadaString = Console.ReadKey(true).KeyChar.ToString();
            Console.WriteLine("\r\nTecla que foi pressionada: "+teclaPressionada);

            // AULA 11

            Console.ReadKey();

        }
    }
}

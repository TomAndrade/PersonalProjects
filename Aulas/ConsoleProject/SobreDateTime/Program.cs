using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime UmaData = new DateTime(2024, 10, 02);
            DateTime DataHora = new DateTime(2025, 1, 1, 11, 59, 59);
            string conversor = DateTime.Now.DayOfWeek.ToString();

            Console.WriteLine("Ano: " + UmaData.Year);
            Console.WriteLine("Mês: " + UmaData.Month);
            Console.WriteLine("Dia: " + UmaData.Day);

            Console.WriteLine("Hora: " + DataHora.Hour);
            Console.WriteLine("Minuto: " + DataHora.Minute);
            Console.WriteLine("Segundo: " + DataHora.Second);

            switch (conversor)
            {
                case "Sunday":  Console.WriteLine("Domingo"); break;
                case "Monday": Console.WriteLine("Segunda"); break;
                case "Tuesday": Console.WriteLine("Terça"); break;
                case "Wednsday": Console.WriteLine("Quarta"); break;
                case "Thursday": Console.WriteLine("Quinta"); break;
                case "Friday": Console.WriteLine("Sexta"); break;
                case "Saturday": Console.WriteLine("Sábado"); break;
                default:
                    Console.WriteLine("Não definido."); break;
            }

            // Formatando a data com o método ToString;
            Console.WriteLine(DataHora.ToString("MM/yyyy"));
            // O TimeSpan serve para adicionar intervalos de tempo para objetos do tipo DateTime. É possível usar tanto o método Add (adicionar) quanto o Subtract (subtrair).
            // Neste caso, a atribuição está sendo feita de forma direta;
            DataHora += new TimeSpan(1, 59, 58);

            Console.WriteLine(DataHora.ToString("HH:mm:ss"));

            Console.ReadKey();
        }
    }
}

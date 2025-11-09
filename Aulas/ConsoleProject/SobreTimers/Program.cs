using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SobreTimers
{
    internal class Program
    {
        static void TimerTick(object enviador, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }
        static void Main(string[] args)
        {
            Timer timer = new Timer(1000);  // Cria o timer
            timer.AutoReset = true;         // Reseta o timer indefinidamente
            timer.Elapsed += TimerTick;     // Cadastra o evento do timer
            timer.Start();                  // Inicia o timer

            Console.WriteLine("Iniciou");
            timer.Stop();                   // Para o timer
        }
    }
}

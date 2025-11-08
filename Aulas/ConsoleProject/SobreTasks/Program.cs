using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SobreTasks
{
    internal class Program
    {
        static void ImprimeMsg(int contagem)
        {
            for (int i = contagem; i < 10; i++)
            {
                Console.WriteLine($"Uma tarefa: {i}");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            // A diferença entre as tasks e threads é que as tasks são temporárias e as threads precisam ser fechadas.
            // Use Wait() para definir o tempo de espera de uma task.
            Task tarefaImprimieMsg = Task.Run(() => ImprimeMsg(5));
            if (tarefaImprimieMsg.Wait(5000) == false)
            {
                Console.WriteLine("Tarefa não finalizada.");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread Main: {i}");
                Thread.Sleep(500);
            }
        }
    }
}

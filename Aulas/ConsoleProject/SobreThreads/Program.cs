using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SobreThreads
{
    internal class ParamThread
    {
        public static int InicioContador {  get; set; }
        public static string Nome {  get; set; }

        public ParamThread(int contador,string nome)
        {
            InicioContador = contador;
            Nome = nome;
        }
    }
    internal class Program
    {
        // Para que uma thread seja executada devidamente, é necessário criar uma variável do tipo Thread
        // Use Abrot() para interromper uma thread através de uma exceção.
        // Você pode usar tanto o lock, quanto o Priority ou o Mutex para resolver problemas de concorrência.
        // Assim como o lock, o Mutex deve ser aplicado para todas as threads.
        // Para usar thread com mais de um parâmetro, é necessário criar uma classe que vai conter o que será passado como parâmetro de entrada.
        static Thread t1;
        static Thread t2;
        static Thread t3;
        static Thread t4;
        static Thread tComParam;        // O parâmetro de uma thread parametrizada precisa ser inserido em Start();
        static int temporizador1 = 0;   // Se duas threads usarem a mesma variável, o valor dela sempre será adicionado por ambas...
        static int temporizador2 = 0;   // Ou seja, para que estejam em sincronia, cada thread deve ter seu próprio temporizador.
        static int temporizador3 = 0;   
        static object travar;           // Use um objeto qualquer para criar um lock.
        //static Mutex mutador;           // Use o mutex como alternativa para organizar threads.

        public static void UmaThreadComParametro(object contagem)
        {
            int contador = (int)contagem;
            if (contador == 0)
            {
                Console.WriteLine("Valor passado foi 0. Mudando para 1...");
                contador = 1;
            }
            do
            {
                Console.WriteLine($"{contador} unidades.");
                Thread.Sleep(500);
                contador--;
            } while (contador > 0);
        }
        public static void UmaThreadComParametro2(object paramThread)
        {
            ParamThread paramDaThread = (ParamThread)paramThread;
            int contador = ParamThread.InicioContador;
            Console.WriteLine(ParamThread.Nome);
            if (contador == 0)
            {
                Console.WriteLine("Valor passado foi 0. Mudando para 1...");
                contador = 1;
            }
            do
            {
                Console.WriteLine($"{contador} unidades.");
                Thread.Sleep(500);
                contador--;
            } while (contador > 0);
        }
        static void UmaThread1()
        {
            try
            {
                while (temporizador1 <= 10)
                {
                    Console.WriteLine($"THREAD 1: {temporizador1} segundos decorridos.");
                    Thread.Sleep(1000);
                    temporizador1++;
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine($"{t1.Name}interrompida inesperadamente: {e.Message}");
            }
            temporizador1 = 0;
        }
        static void UmaThread2()
        {
            try
            {
                while (temporizador2 <= 10)
                {
                    Console.WriteLine($"THREAD 2: {temporizador2} segundos decorridos.");
                    Thread.Sleep(1000);
                    temporizador2++;
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine($"{t2.Name} interrompida inesperadamente: {e.Message}");
            }
            temporizador2 = 0;
        }
        static void UmaThreadTravada()
        {
            Console.WriteLine("Tarefa especial...");
            while (temporizador3 <= 10)
            {
                lock (travar)   // Um lock trava uma thread ao passar por ela na primeira vez. Na terceira vez, será destravada.
                {
                    //mutador.WaitOne();
                    Console.WriteLine($"THREAD 3: {temporizador3} segundos decorridos.");
                    Thread.Sleep(1000);
                    temporizador3++;
                    //mutador.ReleaseMutex();
                }
            }
        }
        static void Main(string[] args)
        {
            travar = new object();
            //mutador = new Mutex();


            tComParam = new Thread(new ParameterizedThreadStart(UmaThreadComParametro));
            t1 = new Thread(new ThreadStart(UmaThread1));
            t1.Priority = ThreadPriority.AboveNormal;       // Define prioridade à thread
            t2 = new Thread(new ThreadStart(UmaThread2));
            t2.Priority = ThreadPriority.Normal;
            t3 = new Thread(new ThreadStart(UmaThreadTravada));
            t3.Priority = ThreadPriority.BelowNormal;
            t4 = new Thread(new ParameterizedThreadStart(UmaThreadComParametro2));
            ParamThread maisDeUmParam = new ParamThread(6, "Fulano");               // Criar a thread do tipo da classe
            t4.Start(maisDeUmParam);

            t1.Start();
            t2.Start();
            t3.Start();
            tComParam.Start(5);

            /*
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{i} segundo(s) decorrido(s)...\r");
            }
            */
        }
    }
}

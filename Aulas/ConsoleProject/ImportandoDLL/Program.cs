using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SobreDLL;
using System.Reflection;                // Use o Reflection para carregar dlls dinamicamente.

namespace ImportandoDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para importar uma DLL, clique com o botão direito em Referências e selecione "adicionar referência".
            // Busque pelo arquivo pelo bovtão "procurar".

            //Console.WriteLine($"Chamando um método estático de uma dll: {ConversorTempo.dayToHours(12)} horas");

            // Carregando dinamicamente:
            Assembly umaDLL = Assembly.LoadFile(@"D:\CS\Aulas\ConsoleProject\SobreDLL\bin\Debug\SobreDLL.dll"); // Carregou a dll
            Type classeConversor = umaDLL.GetType("SobreDLL.ConversorTempo");  // Pegou a classe em questão dessa dll
            dynamic instConversor = Activator.CreateInstance(classeConversor); // Criando uma instância da classe - não é necessário para métodos estáticos.
            var umMetodo = classeConversor.GetMethod("dayToHours");            // Pegou o método.
            // O primeiro parâmetro é null, pois o método usado aqui é estático. Caso não seja, use o nome da instância.
            // Para chamar os métodos do objeto, é necessário usar o Invoke, que recebe como parâmetro a instância e o parâmetro do método (se existir).
            // Como o Invoke retorna um valor, é necessário criar uma variável que irá recebê-lo.
            /*
            Situação	                                Melhor abordagem
            Projeto fixo com dependências conhecidas	Referência estática
            Sistema de plugins ou extensível	        Carregamento dinâmico
            Precisa de desempenho e segurança de tipo	Referência estática
            Precisa de flexibilidade e modularidade	    Reflection
            */
            int resultado = (int)umMetodo.Invoke(null, new object[] {12});
            Console.WriteLine($"{resultado} horas");
        }
    }
}

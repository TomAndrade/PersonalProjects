using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreMetodos
{
    internal class Program
    {
        public static void Metodos(string param1, string param2, ref string paramRef)
        {
            param1 = "Algo";
            param2 = "Outro";
            // ref é uma espécie de sinalizador que indica que o param de entrada PODE ser modificado pelo método. Ou seja, não é necessário que seja modificado.
            //paramRef = "Exemplo";
        }
        public static double OutroExemplo(double x, double y, out double paramRef)
        {
            // No caso de out é o contrário. Você PRECISA modifica-lo.
            paramRef = x*y;
            return 0.0;
        }

        static void Main(string[] args)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores
{
    internal class Program
    {
        enum NotasReal
        {
            Notade2 = 2, Notade5 = 5, Notade10 = 10
        }
        enum NotasIncrementais
        {
            // Quando não há valores para cada atributo, o próximo incrementa 1 do primeiro.
            // Mesmo se não inserir valores no primeiro, ele será considerado como 0.
            // Números negativos são válidos também.
            Nota0 = 0, Nota1, Nota2, Nota3, Nota4
        }
        static void Main(string[] args)
        {
            NotasReal[] notas = { NotasReal.Notade2, NotasReal.Notade5, NotasReal.Notade10 };
            Console.WriteLine((UInt32)notas[1]);
        }
    }
}

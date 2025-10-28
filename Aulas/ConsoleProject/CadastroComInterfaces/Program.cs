using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroComInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDeDados db = new BaseDeDados();
            GUITest programa = new GUITest(db);
            programa.IniciaGUI();
        }
    }
}

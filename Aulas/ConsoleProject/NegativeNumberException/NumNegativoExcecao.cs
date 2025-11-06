using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeNumberException
{
    public class NumNegativoExcecao: Exception
    {
        public NumNegativoExcecao(int numero) : base($"Número {numero} não é positivo.")
        {

        }
    }
}

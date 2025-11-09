using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores
{
    internal class VersaoJava
    {
        // Em C#, não é possível ter construtores e atributos dentro de um enum da mesma forma que em Java.
        // Para simular esse comportamento, usamos uma classe "Enum-like" com instâncias estáticas readonly.
        public sealed class TipoCliente
        {
            // Instâncias estáticas (equivalente aos valores do enum Java)
            public static readonly TipoCliente PESSOA_FISICA = new TipoCliente(1, "Sem restrições");
            public static readonly TipoCliente PESSOA_JURIDICA = new TipoCliente(2, "Com restrições");

            // Campos imutáveis
            public readonly int Valor;
            private readonly string _restricao;

            // Construtor privado — impede criação fora da classe
            private TipoCliente(int valor, string restricao)
            {
                this.Valor = valor;
                this._restricao = restricao;
            }

            // Getter para restrição
            public string GetRestricao()
            {
                return _restricao;
            }

            // Método para obter instância a partir do valor (sem switch expression)
            public static TipoCliente ObterPorValor(int valor)
            {
                if (valor == 1) return PESSOA_FISICA;
                if (valor == 2) return PESSOA_JURIDICA;
                return null; // pode retornar null se o valor não corresponder
            }

            // Sobrescreve ToString() para comportamento semelhante ao Java
            public override string ToString()
            {
                return _restricao;
            }
        }
    }
}

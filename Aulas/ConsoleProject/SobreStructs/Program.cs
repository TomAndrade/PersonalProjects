using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SobreStructs
{
    internal class Program
    {
        // Structs são estruturas de variáveis. É como uma variável que tem variáveis de diferentes tipos dentro dela.
        /*
            Entretanto, muitas vezes você pode usar qualquer uma das duas que obterá o mesmo resultado. A principal diferença ocorre quando uma instância de uma classe ou struct é passado como parâmetro de uma função:
            - Quando uma instância de uma classe é passada como argumento para um método, qualquer alteração feita dentro do método afeta o objeto original.
            - Quando um struct é passado para um método, ele é copiado, ou seja, mudanças dentro do método não afetam o original.
            Tente sempre usar classes.
         */
        // Use structs para coisas mais simples, como atributos simples que compartilham de um mesmo conceito.
        struct DadosCadastro
        {
            public string Nome;
            public string NomeRua;
            public UInt32 NumRua;
            public int NumCasa;
            public DateTime DataNascimento;
        }
        static void Main(string[] args)
        {
            DadosCadastro meuCadastro;
            meuCadastro.Nome = "Fulano";
            meuCadastro.NomeRua = "Dolores";
            meuCadastro.NumRua = 322;
            meuCadastro.NumCasa = 154;
            meuCadastro.DataNascimento = new DateTime(1994,12,8);
            Console.WriteLine(meuCadastro.DataNascimento);
        }
    }
}

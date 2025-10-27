using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManipulandoArquivosStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "d:\\CS\\Aulas\\Teste2.txt";
            FileStream arquivo = File.Create(caminho);
            arquivo.Close();

            StreamWriter sw = new StreamWriter(caminho);
            sw.Write("Olá, mundo!");
            sw.Close();     // Assim como o FileStream, você precisa fechar o arquivo.

            StreamReader sr = new StreamReader("d:\\CS\\ListaCadastrosDB.txt");
            string leitura = sr.ReadToEnd();        // Lerá todo o conteúdo do arquivo.
            Console.WriteLine(leitura);
            sr.Close();
        }
    }
}

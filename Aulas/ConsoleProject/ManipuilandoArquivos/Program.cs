using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManipuilandoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Há duas formas de digitar caminhos de arquivo:
            string dir1 = "d:\\CS\\Aulas\\teste1.txt";
            string dir2 = @"d:\CS\Aulas\teste2.txt";

            FileStream arquivo1 = File.Create(dir1);    // Usado para criar um arquivo e permitir que possa ser lido e/ ou editado.
            arquivo1.Close();   // Use Close() para fechar o arquivo logo após de usá-lo. Isso evita que o arquivo permaneça aberto.

            bool arquivoExsite = File.Exists(dir1);  // Verifica se o arquivo existe retornando bool; não é necessário criar variáveis para métodos File.

            if (File.Exists(dir1))
            {
                Console.WriteLine("Arquivo existe.");
            }
            else
            {
                Console.WriteLine("Arquivo não existe.");
            }
            File.Move(dir1, "d:\\CS\\Aulas\\ConsoleProject\\NewFile.txt"); // Cria uma cópia do arquivo e o move.
            File.WriteAllText(dir1, "Conteúdo sendo escrito...\r\nSegunda linha.");     // Escreve conteúdo dentro do arquivo.

            string[] exemploArray = {"Fulano","Ciclano","Beltrano"};
            File.WriteAllLines(dir1, exemploArray);         // Escreverá o array inteiro, dividindo-o em linhas.

            Console.WriteLine(File.ReadAllText(dir1));      // Lê todo o conteúdo do arquivo.
            string[] conteudo = File.ReadAllLines(dir1);    // Lê o conteúdo de um arquivo e armazena num array.

            File.AppendAllText(dir1, "Um, dois, três, quatro...\r\n");


        }
    }
}

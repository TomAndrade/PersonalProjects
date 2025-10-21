using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 's' para sair, 'c' para cadastrar
            //Nome completo; gênero; data de nascimento; nome da rua; número da casa
            string opcao;

            do
            {
                Console.Write("Pressione C para cadastrar ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao != "c" && opcao != "s")
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }else if (opcao == "s")
                {
                    Console.WriteLine("Encerrando...");
                    break;
                }
                Console.Write("\r\nDigite seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite seu sexo: ");
                char sexo = Console.ReadKey().KeyChar;
                Console.Write("\r\nDigite da data de nascimento (dia/mês/ano): ");
                DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Digite o nome da rua: ");
                string nomeRua = Console.ReadLine();
                Console.Write("Digite o número da casa: ");
                UInt32 numCasa = Convert.ToUInt32(Console.ReadLine());
            } while (true);
        }
    }
}

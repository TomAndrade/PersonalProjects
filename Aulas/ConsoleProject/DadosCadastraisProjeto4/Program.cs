using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace DadosCadastraisProjeto4
{
    internal class Program
    {
        public enum ResultadoEnum
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2
        }
        public struct DadosCadastroStruct
        {
            public string Nome;
            public DateTime data;
            public string NomeRua;
            public UInt32 NumCasa;
            public string NumDocumento;
        }
        public static void ExibeMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
        public static ResultadoEnum GetString(ref string palavra, string mensagem)
        {
            ResultadoEnum retorno;
            Console.Write(mensagem);
            string temp = Console.ReadLine().ToLower();
            if (temp == "s")
            {
                retorno = ResultadoEnum.Sair;
            }
            else
            {
                palavra = temp;
                retorno = ResultadoEnum.Sucesso;
            }
            Console.Clear();
            return retorno;
        }
        public static ResultadoEnum GetDate(ref DateTime umaData, string mensagem)
        {
            ResultadoEnum retorno;

            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine().ToLower();
                    if (temp == "s")
                    {
                        retorno = ResultadoEnum.Sair;
                    }
                    else
                    {
                        umaData = Convert.ToDateTime(temp);
                        retorno = ResultadoEnum.Sucesso;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine("Erro ao tentar converter: " + e.Message);
                    retorno = ResultadoEnum.Excecao;
                }
            } while (retorno == ResultadoEnum.Excecao);

            Console.Clear();
            return retorno;
        }
        public static ResultadoEnum GetNumCasa(ref UInt32 umNum, string mensagem)
        {
            ResultadoEnum retorno;

            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine().ToLower();
                    if (temp == "s")
                    {
                        retorno = ResultadoEnum.Sair;
                    }
                    else
                    {
                        umNum = Convert.ToUInt32(temp);
                        retorno = ResultadoEnum.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao tentar converter: " + e.Message);
                    retorno = ResultadoEnum.Excecao;
                }
            } while (retorno == ResultadoEnum.Excecao);

            Console.Clear();
            return retorno;
        }
        public static void CadastraUsuario(ref List<DadosCadastroStruct> umaListadeUsuarios)
        {
            DadosCadastroStruct dadosUsuario;
            dadosUsuario.Nome = string.Empty;
            dadosUsuario.data = new DateTime();
            dadosUsuario.NomeRua = string.Empty;
            dadosUsuario.NumCasa = 0;
            dadosUsuario.NumDocumento = string.Empty;

            if (GetString(ref dadosUsuario.Nome, "Digite seu nome ou digite 's' para sair: ") != ResultadoEnum.Sucesso)
            {
                return;
            }
            if (GetDate(ref dadosUsuario.data, "Digite a data de nascimento (dd/mm/aaa) ou digite 's' para sair: ") != ResultadoEnum.Sucesso)
            {
                return;
            }
            if (GetString(ref dadosUsuario.NomeRua, "Digite o nome da rua ou digite 's' para sair: ") != ResultadoEnum.Sucesso)
            {
                return;
            }
            if (GetNumCasa(ref dadosUsuario.NumCasa, "Digite o número da casa ou digite 's' para sair: ") != ResultadoEnum.Sucesso)
            {
                return;
            }
            if (GetString(ref dadosUsuario.NumDocumento, "Digite o número do documento ou digite 's' para sair: ") != ResultadoEnum.Sucesso)
            {
                return;
            }
            umaListadeUsuarios.Add(dadosUsuario);
            Console.WriteLine("Dados cadastrados com sucesso.");
        }
        static void Main(string[] args)
        {
            List<DadosCadastroStruct> ListaCadastrais = new List<DadosCadastroStruct>();
            string opcao;

            do
            {
                Console.Write("Digite C para cadastrar ou S para sair: ");
                opcao = Console.ReadKey().KeyChar.ToString().ToLower();

                if (opcao == "s")
                {
                    ExibeMensagem("\nEncerrando..."); 
                    break;
                }
                if (opcao == "c")
                {
                    CadastraUsuario(ref ListaCadastrais);
                }
                else ExibeMensagem("\nOpção inválida.");

            } while (true);
        }
    }
}

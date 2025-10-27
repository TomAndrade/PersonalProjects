using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DadosCadastraisProjeto4
{
    internal class Program
    {
        // Estas tags só servem para identificar o que cada linha tem.
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagDataNasc;
        static string tagNomeRua;
        static string tagNumCasa;
        static string tagNumDocumento;
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
        public static ResultadoEnum CadastraUsuario(ref List<DadosCadastroStruct> umaListadeUsuarios)
        {
            DadosCadastroStruct dadosUsuario;
            dadosUsuario.Nome = string.Empty;
            dadosUsuario.data = new DateTime();
            dadosUsuario.NomeRua = string.Empty;
            dadosUsuario.NumCasa = 0;
            dadosUsuario.NumDocumento = string.Empty;

            if (GetString(ref dadosUsuario.Nome, "\nDigite seu nome ou digite 's' para sair: ") == ResultadoEnum.Sair)
            {
                return ResultadoEnum.Sair;
            }
            if (GetDate(ref dadosUsuario.data, "\nDigite a data de nascimento (dd/mm/aaa) ou digite 's' para sair: ") == ResultadoEnum.Sair)
            {
                return ResultadoEnum.Sair;
            }
            if (GetString(ref dadosUsuario.NomeRua, "\nDigite o nome da rua ou digite 's' para sair: ") == ResultadoEnum.Sair)
            {
                return ResultadoEnum.Sair;
            }
            if (GetNumCasa(ref dadosUsuario.NumCasa, "\nDigite o número da casa ou digite 's' para sair: ") == ResultadoEnum.Sair)
            {
                return ResultadoEnum.Sair;
            }
            if (GetString(ref dadosUsuario.NumDocumento, "\nDigite o número do documento ou digite 's' para sair: ") == ResultadoEnum.Sair)
            {
                return ResultadoEnum.Sair;
            }
            umaListadeUsuarios.Add(dadosUsuario);
            Console.WriteLine("Dados cadastrados com sucesso.");
            return ResultadoEnum.Sucesso;
        }
        public static void GravarDadosCadastrais(string caminho, List<DadosCadastroStruct> ListadeCadastros)
        {
            try
            {
                string conteudoArquivo = "";
                foreach (DadosCadastroStruct dados in ListadeCadastros)
                {
                    // A cada dado analisado, será acrescentado um delimitador inicial com pula linha com ele sendo inserido na variável.
                    conteudoArquivo += delimitadorInicio + "\r\n";
                    conteudoArquivo += tagNome + dados.Nome + "\r\n";
                    conteudoArquivo += tagDataNasc + dados.data.ToString("dd/MM/yyyy") + "\r\n";
                    conteudoArquivo += tagNomeRua + dados.NomeRua + "\r\n";
                    conteudoArquivo += tagNumCasa + dados.NumCasa + "\r\n";
                    conteudoArquivo += tagNumDocumento + dados.NumDocumento + "\r\n";
                    conteudoArquivo += delimitadorFim + "\r\n";
                }
                File.WriteAllText(caminho, conteudoArquivo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado: " + e.Message);
            }
        }
        public static void CarregarDadosCadastrais(string caminho, ref List<DadosCadastroStruct> ListaDeCadastros)
        {
            try
            {
                if (File.Exists(caminho))
                {
                    string[] conteudoArquivo = File.ReadAllLines(caminho);
                    DadosCadastroStruct dadosCadastrados;
                    dadosCadastrados.Nome = string.Empty;
                    dadosCadastrados.data = new DateTime();
                    dadosCadastrados.NomeRua = string.Empty;
                    dadosCadastrados.NumCasa = 0;
                    dadosCadastrados.NumDocumento = string.Empty;

                    foreach(string linha in conteudoArquivo)
                    {
                        if (linha.Contains(delimitadorInicio)) continue;                                                                // Se a linha for o delimitador inicia, pule ela.
                        if (linha.Contains(delimitadorFim)) ListaDeCadastros.Add(dadosCadastrados);                                     // Se for o delimitador final, adicione os dados preenchidos na lista.
                        if (linha.Contains(tagNome)) dadosCadastrados.Nome = linha.Replace(tagNome, "");                                // Se for alguma tag, remova-a.
                        if (linha.Contains(tagDataNasc)) dadosCadastrados.data = Convert.ToDateTime(linha.Replace(tagDataNasc, ""));    
                        if (linha.Contains(tagNomeRua)) dadosCadastrados.NomeRua = linha.Replace(tagNomeRua, "");    
                        if (linha.Contains(tagNumCasa)) dadosCadastrados.NumCasa = Convert.ToUInt32(linha.Replace(tagNomeRua, ""));    
                        if (linha.Contains(tagNumDocumento)) dadosCadastrados.NumDocumento = linha.Replace(tagNumDocumento, "");    
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possível ler o arquivo: "+e.Message);
            }
        }
        static void Main(string[] args)
        {
            List<DadosCadastroStruct> ListaCadastrais = new List<DadosCadastroStruct>();
            string opcao;
            delimitadorInicio = "##### INÍCIO #####";
            delimitadorFim = "##### FIM #####";
            tagNome = "NOME: ";
            tagDataNasc = "DATA_DE_NASCIMENTO: ";
            tagNomeRua = "NOME_DA_RUA: ";
            tagNumCasa = "NUMERO_DA_CASA: ";
            tagNumDocumento = "NUMERO_DO_DOCUMENTO: ";
            string caminhoDB = "d:\\CS\\ListaCadastrosDB.txt";              // É possível inserir apenas o nome do arquivo. Ele será salvo e carregado no mesmo caminho onde se encontra o executável deste programa.

            CarregarDadosCadastrais(caminhoDB, ref ListaCadastrais);        // Este método irá carregar os dados que foram cadastrados para a memória, caso exista.

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
                    if (CadastraUsuario(ref ListaCadastrais) == ResultadoEnum.Sucesso)
                    {
                        GravarDadosCadastrais(caminhoDB, ListaCadastrais);  // Só irá gravar no arquivo se tudo correr bem.
                    }
                }
                else ExibeMensagem("\nOpção inválida.");

            } while (true);
        }
    }
}

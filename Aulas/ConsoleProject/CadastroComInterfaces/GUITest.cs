using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroComInterfaces
{
    internal class GUITest
    {
        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2
        }
        public void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
                retorno = Resultado_e.Sair;
            else
            {
                minhaString = temp;
                retorno = Resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }
        public Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {

                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem("EXCECAO: " + e.Message);
                    retorno = Resultado_e.Excecao;
                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        public Resultado_e PegaUInt32(ref UInt32 numeroUInt32, string mensagem)
        {
            Resultado_e retorno;
            do
            {

                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        numeroUInt32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    MostraMensagem("EXCECAO: " + e.Message);
                    retorno = Resultado_e.Excecao;
                }

            } while (retorno == Resultado_e.Excecao);
            Console.Clear();
            return retorno;
        }

        BaseDeDados baseDeDados;
        public GUITest(BaseDeDados db)
        {
            db = baseDeDados;
        }

        public void ImprimeDadosNaTela(CadastroPessoa pessoa)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}\r\nNúmero do documento: {pessoa.NumDocumento}\r\n" +
                $"Data de nascimento: {pessoa.DataNasc}\r\nNome da rua: {pessoa.NomeRua}\r\nNúmero da casa: {pessoa.NumCasa}\r\n");
        }
        public void ImprimeDadosNaTela(List<CadastroPessoa> listaPessoas)
        {
            foreach (CadastroPessoa pessoa in listaPessoas)
            {
                ImprimeDadosNaTela(pessoa);
            }
        }

        public Resultado_e CadastraUsuario()
        {
            Console.Clear();
            string nome = string.Empty;
            string numDoc = string.Empty;
            DateTime dataNasc = new DateTime();
            string nomeRua = string.Empty;
            UInt32 numCasa = 0;

            if (PegaString(ref nome, "Digite o nome completo ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaData(ref dataNasc, "Digite a data de nascimento no formato DD/MM/AAAA ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref numDoc, "Digite o número do documento ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref nomeRua, "Digite o nome da rua ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaUInt32(ref numCasa, "Digite o número da casa ou digite S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            CadastroPessoa cadastroUsuario = new CadastroPessoa(nome,numDoc,dataNasc,nomeRua,numCasa);
            baseDeDados.AddPessoa(cadastroUsuario);
            //ListaDeUsuarios.Add(cadastroUsuario);
            //GravaDados(caminhoArquivo, ListaDeUsuarios);
            Console.Clear();
            Console.WriteLine("Adicionando usuário: ");
            ImprimeDadosNaTela(cadastroUsuario);
            MostraMensagem("");
            return Resultado_e.Sucesso;
        }
        public void BuscarUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o número do documento do usuário que deseja buscar ou digite 's' para sair: ");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s") return; 
            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.pesquisarPessoaPorDoc(temp);
            Console.Clear();
            if(listaDePessoaTemp == null)
            {
                Console.WriteLine($"Nenhum usuário com o documento {temp} foi encontrado.");
                MostraMensagem(""); return;
            }
            Console.WriteLine($"{listaDePessoaTemp.Count} usuário(s) com o documento {temp} encontrado(s): ");
            ImprimeDadosNaTela(listaDePessoaTemp);
        }
        public void RemoverUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o número do documento do usuário que deseja remover ou digite 's' para sair: ");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s") return;
            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.removerPessoaPorDoc(temp);
            Console.Clear();
            if (listaDePessoaTemp == null)
            {
                Console.WriteLine($"Nenhum usuário com o documento {temp} foi encontrado.");
                MostraMensagem(""); return;
            }
            Console.WriteLine($"{listaDePessoaTemp.Count} usuário(s) com o documento {temp} removido(s): ");
            ImprimeDadosNaTela(listaDePessoaTemp);
        }
        public void Sair()
        {
            Console.Clear();
            MostraMensagem("Encerrando...");
        }
        public void OpcaoDesconhecida()
        {
            Console.Clear();
            MostraMensagem("Opção desconhecida.");
        }
        public void IniciaGUI()
        {
            string temp;
            do
            {
                Console.WriteLine("Digite 'c' para cadastrar um novo usuário");
                Console.WriteLine("Digite 'b' para buscar um usuário pelo número do documento");
                Console.WriteLine("Digite 'r' para remover um novo usuário pelo número do documento");
                Console.WriteLine("Digite 's' para sair");
                temp = Console.ReadKey().KeyChar.ToString().ToLower();
                switch (temp)
                {
                    case "c": CadastraUsuario(); break;
                    case "b": BuscarUsuario(); break;
                    case "r": RemoverUsuario(); break;
                    case "s": Sair(); break;
                    default: OpcaoDesconhecida(); break;
                }
            } while (temp != "s");
        }
    }
}

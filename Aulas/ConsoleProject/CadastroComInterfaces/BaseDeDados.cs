using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroComInterfaces
{
    internal class BaseDeDados
    {
        private List<CadastroPessoa> listaPessoas;


        public void AddPessoa(CadastroPessoa pessoa)
        {
            listaPessoas.Add(pessoa);
        }
        public List<CadastroPessoa> pesquisarPessoaPorDoc (string numDoc)
        {
            List<CadastroPessoa> listaTemp = listaPessoas.Where(x=>x.NumDocumento==numDoc).ToList();
            if (listaTemp.Count == 0)
            {
                Console.WriteLine("Núnmero de documento não encontrado ou a lista está vazia.");
                return null;
            }
            return listaTemp;
        }
        public List<CadastroPessoa> removerPessoaPorDoc(string numDoc)
        {
            List<CadastroPessoa> listaTemp = listaPessoas.Where(x => x.NumDocumento == numDoc).ToList();
            if (listaTemp.Count == 0)
            {
                Console.WriteLine("Núnmero de documento não encontrado ou a lista está vazia.");
                return null;
            }
            foreach(CadastroPessoa pessoa in listaTemp)
            {
                listaPessoas.Remove(pessoa);
            }
            return listaTemp;
        }
        public BaseDeDados()
        {
            listaPessoas = new List<CadastroPessoa>();
        }
    }
}

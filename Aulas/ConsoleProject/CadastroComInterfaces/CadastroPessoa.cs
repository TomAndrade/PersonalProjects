using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroComInterfaces
{
    internal class CadastroPessoa
    {
        private string nome;
        private string numDocumento;
        private DateTime dataNasc;
        private string nomeRua;
        private UInt32 numCasa;

        public string Nome { get => nome; set => nome = value; }
        public string NumDocumento { get => numDocumento; set => numDocumento = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string NomeRua { get => nomeRua; set => nomeRua = value; }
        public uint NumCasa { get => numCasa; set => numCasa = value; }

        public CadastroPessoa(string nome, string numDocumento, DateTime dataNasc, string nomeRua, uint numCasa)
        {
            this.nome = nome;
            this.numDocumento = numDocumento;
            this.dataNasc = dataNasc;
            this.nomeRua = nomeRua;
            this.numCasa = numCasa;
        }
    }
}

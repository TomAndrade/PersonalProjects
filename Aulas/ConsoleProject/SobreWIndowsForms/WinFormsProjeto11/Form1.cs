using CadastroBiblioteca;
using System.Diagnostics.CodeAnalysis;

// Para que o form possa usar as bibliotecas, é necessário adicionar as dependências para com elas.
// Clique com o botão direito em "Dependências" e depois adicione as dependências necessárias.

namespace WinFormsProjeto11
{
    public partial class Form1 : Form
    {
        BaseDeDados baseDados;
        public Form1()
        {
            InitializeComponent();
            baseDados = new BaseDeDados("BaseDeDados.xml");
        }
        private void label12_Click(object sender, EventArgs e)
        {
            //...
        }

        private void buttonCadastra_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(textBoxNome.Text, textBoxNumDoc.Text,
                Convert.ToDateTime(textBoxDataNasc.Text), textBoxRua.Text, Convert.ToUInt32(textBoxNumCasa.Text));
            baseDados.AdicionarPessoa(cadastroPessoa);
            MessageBox.Show("Cadastro realizado com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDados.PesquisaPessoaPorDoc(textBoxBuscarDoc.Text);
            if (listaPessoas is not null && listaPessoas.Count>0)
            {
                labelNomeMod.Text = listaPessoas[0].Nome;
                labelDataNascMod.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelRuaMod.Text = listaPessoas[0].NomeDaRua;
                labelNumCasaMod.Text = listaPessoas[0].NumeroDaCasa.ToString();
            }
            else
            {
                MessageBox.Show("Registro não localizado!","Falha",MessageBoxButtons.OK,MessageBoxIcon.Error);   
         
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoa = baseDados.PesquisaPessoaPorDoc(textBoxBuscarDoc.Text);
            if (listaPessoa is not null && listaPessoa.Count > 0)
            {
                labelNomeMod.Text = listaPessoa[0].Nome;
                labelDataNascMod.Text = listaPessoa[0].DataDeNascimento.ToString();
                labelRuaMod.Text = listaPessoa[0].NomeDaRua;
                labelNumCasaMod.Text = listaPessoa[0].NumeroDaCasa.ToString();
                MessageBox.Show("Registro removido com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro não localizado!","Falha",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
        }
    }
}

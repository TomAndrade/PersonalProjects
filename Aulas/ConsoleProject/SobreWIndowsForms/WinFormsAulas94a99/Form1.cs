using System.Data;

namespace WinFormsAulas94a99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // O DataGridView precisa de uma tabela. Esta pode ser criada através da classe DataTable:
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));       // Para adicionar uma coluna, é necessário passar como parâmetros o nome e o tipo.
            dt.Columns.Add("Nome", typeof(string));

            DataRow linha1 = dt.NewRow();           // Para criar uma linha, primeiro, tem que criar um objeto do tipo DataRow.
            linha1["ID"] = 1;                       // Após isso, especificar o(s) elemento(s) que será(ão) adicionado(s) por coluna.
            linha1["Nome"] = "Fulano";

            dt.Rows.Add(linha1);

            DataRow linha2 = dt.NewRow();
            linha2["ID"] = 2;
            linha2["Nome"] = "Ciclano";

            dt.Rows.Add(linha2);

            DataRow linha3 = dt.NewRow();
            linha3["ID"] = 3;
            linha3["Nome"] = "Beltrano";

            dt.Rows.Add(linha3);

            dataGridView1.DataSource = dt;          // Após completar a tabela, adicione-a pelo DataSource.
        }
        // OpenFileDialog
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Para usar o recurso de abrir um determinado arquivo em menu, crie um e adicione um openFileDialog no Form. O método ShowDialog mostra a caixa de diálogo.
            // Para adicionar mais de uma extensão, use o Filter e separe cada opção com pipeline: Arquivos de texto|*.txt;*.ini;*.doc|Todos os arquivos| *.*
            // O método ShowDialog retorna DialogResult OK ou Cancel. Use-os para saber ou copiar o caminho do que foi selecionado.
            openFileDialog1.ShowDialog();
        }
        // FolderBrowserDialog
        private void abrirPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderBrowserDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
            }
        }
        // MonthCalendar
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dataInicial = monthCalendar1.SelectionStart;
            DateTime dataFinal = monthCalendar1.SelectionEnd;
        }
    }
}

namespace PrimeiraInterfaceGrafica
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInicial_Click(object sender, EventArgs e)
        {
            buttonInicial.Text = "Clicado";
        }

        private void LabelTexto1_MouseEnter(object sender, EventArgs e)
        {
            LabelTexto1.Text = "Clique no botão >>>";
        }

        private void LabelTexto1_MouseLeave(object sender, EventArgs e)
        {
            LabelTexto1.Text = "Texto:";
        }

        private void LabelTexto1_Click(object sender, EventArgs e)
        {
            LabelTexto1.Font = new Font("ArialBlack", 18);
        }

        private void buttonInicial_MouseEnter(object sender, EventArgs e)
        {
            buttonInicial.BackColor = Color.White;
            buttonInicial.ForeColor = Color.Gray;
        }

        private void buttonInicial_MouseLeave(object sender, EventArgs e)
        {
            buttonInicial.BackColor = Color.LightGray;
            buttonInicial.ForeColor = Color.Gray;
        }

        private void buttonMsgBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Caixa de mensagem clicada.", "Título da mensagem", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Clicou em OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Clicou em Cancelar", "Cancelou", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BotaoInverte_Click(object sender, EventArgs e)
        {
            string texto = CaixaDeTextoSuperior.Text;
            string textoRico = CaixaDeTextoRica.Text;

            CaixaDeTextoSuperior.Text = textoRico;
            CaixaDeTextoRica.Text = texto;
        }
    }
}

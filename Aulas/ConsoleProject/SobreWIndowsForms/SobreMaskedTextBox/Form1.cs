namespace SobreMaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Use MaskTextBox para adicionar máscaras em campos de texto a fim de padroniza-los.
            // Há máscaras predefinidas nas propriedades do controle sem que precise digitar tudo aqui diretamente.
            // Neste caso, inserir # é opcional. Inserir 0 é obrigatório.
            maskedTextBoxNum.Mask = "0000";

            // No caso de letras, usa-se L (obrigatório) e ? (opcional).
            maskedTextBoxLetras.Mask = "LLLLLLLL";

            // Exemplo de uso para datas:
            maskedTextBoxDate.Mask = "00/00/0000";

            // Exemplo de uso para placas de carro:
            mTBPlacaDeCarro.Mask = "LLL0L00";

            // Exemplo de uso para horas:
            maskedTextBoxHora.Mask = "00:00:##";

            // Exemplo de uso para números decimais - use o ponto ao invés da vírgula para marcar:
            maskedTextBoxDecimais.Mask = "000.00000";

            // Para senhas - use o PasswordChar para substituir todos os caracteres por aquele escolhido, escondendo a senha:
            maskedTextBoxSenha.Mask = "0000";
            maskedTextBoxSenha.PasswordChar = '*';

            // Exemplo de uso para número de celular - use \\ para inserir caracteres forçados ou que não podem ser deletados:
            maskedTextBoxCelular.Mask = "(\\000) \\90000-0000";

        }

        private void chkboxMercosul_Click(object sender, EventArgs e)
        {

        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MaskedTextBox m && !m.MaskCompleted)
                {
                    MessageBox.Show("Existem campos obrigatórios não preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            MessageBox.Show("Todos os campos foram preenchidos!");
        }

        private void chkboxMercosul_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxMercosul.Checked)
            {
                mTBPlacaDeCarro.Mask = "LLL-0000";
            }
            else
            {
                mTBPlacaDeCarro.Mask = "LLL0L00";
            }
        }
    }
}

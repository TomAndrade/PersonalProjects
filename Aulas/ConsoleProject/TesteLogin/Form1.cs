namespace TesteLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (buttonEnter.Text == "Connect")
            {
                if (maskedTextBoxPass.Text == "" && textBoxUser.Text == "")
                {
                    MessageBox.Show("Digite o usuário e senha para continuar.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxUser.Text == "" || textBoxUser.Text == string.Empty)
                {
                    MessageBox.Show("O campo user está vazio. Digite o nome de usuário!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBoxUser.Text == "well")
                    {
                        if (maskedTextBoxPass.Text == "" || maskedTextBoxPass.Text == string.Empty)
                        {
                            MessageBox.Show("O campo password está vazio. Digite a senha do usuário!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (maskedTextBoxPass.Text == "1234")
                            {
                                MessageBox.Show("Login feito com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                labelConexao.Text = "Conectado";
                                labelConexao.ForeColor = Color.Green;
                                textBoxUser.Text = "";
                                maskedTextBoxPass.Text = "";
                                buttonEnter.Text = "Disconnect";
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta.", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário incorreto. Tente novamente.", "Usuário incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                labelConexao.Text = "Desconectado";
                labelConexao.ForeColor = Color.Red;
                buttonEnter.Text = "Connect";
            }
        }

        private void trackBarAtiva_ValueChanged(object sender, EventArgs e)
        {
            // O valor da barra progressiva será o valor do die
            progressBarPassivo.Value = trackBarAtiva.Value;
        }
    }
}

namespace WinFormsAulas98a101
{
    public partial class Form1 : Form
    {
        static DateTime tempo = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPausarContinuar_Click(object sender, EventArgs e)
        {
            if (buttonPausarContinuar.Text == "Pausar")
            {
                buttonPausarContinuar.Text = "Continuar";
                timerIntervalos.Enabled = false;
            }
            else
            {
                buttonPausarContinuar.Text = "Pausar";
                timerIntervalos.Enabled = true;
            }
        }

        private void timerIntervalos_Tick(object sender, EventArgs e)
        {
            labelTempoAtual.Text = tempo.ToString("HH:mm:ss");
            labelInvertido.Text = tempo.AddSeconds(-2).ToString("HH:mm:ss");
            tempo = DateTime.Now;
        }
        private void labelInvertido_MouseHover(object sender, EventArgs e)
        {
            // A tooltip precisa de um alvo que é o segundo parâmetro.
            toolTip1.Show("Exemplo de tooltip", labelInvertido);
        }

        private void buttonAbrirSegForm_Click(object sender, EventArgs e)
        {
            // Use o Application.OpenForms[formName] para permitir que apenas uma intância possa ser iniciada.
            // Para acessar o outro form, é necessário criar uma instância dele no formulário "pai". Depois, faça o casting do tipo form para funcionar. Neste caso, sempre é nulo.
            ExSegundoForm form2 = (ExSegundoForm)Application.OpenForms["Segundo Formulário"];
            if (form2 == null)
            {
                form2 = new ExSegundoForm();
                form2.Name = "Segundo Formulário";
                form2.Show();
                buttonAbrirSegForm.Enabled = false;
            }
            form2.FormClosed += (sender, args) =>
            {
                buttonAbrirSegForm.Enabled = true;
            };
        }
    }
}

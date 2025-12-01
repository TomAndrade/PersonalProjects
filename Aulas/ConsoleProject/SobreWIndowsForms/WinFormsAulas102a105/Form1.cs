namespace WinFormsAulas102a105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Os três eventos são necessários para que o recurso de drag drop funcione devidamente.
        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            // Evento ativado quando se arrasta algo sobre o item.
            // DragDropEffects.All aceitará todos os eventos possíveis.
            e.Effect = DragDropEffects.All;
            label1.ForeColor = Color.Red;
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            // Evento ativado quando se solta algo sobre o item.
            // O Drop irá servir para capturar arquivos. Para isso, use o Data.GetData seguido do parâmetro "DataFormats".
            // Neste caso, o Drop aceitará qualquer tipo de arquivo.
            string[] arquivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            textBox1.Text = arquivos[0];
            label1.ForeColor = Color.Black;
        }

        private void label1_DragLeave(object sender, EventArgs e)
        {
            // Evento ativado quando algo sai do campo de controle do item, ou seja, quando se tira algo de cima, mas não o solta.
            textBox1.Text = "";
            label1.ForeColor = Color.Black;
        }
    }
}

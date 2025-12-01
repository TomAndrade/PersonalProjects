namespace WinFormsAddCtrlProgramaticamente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Assim como qualquer outro controle, para criar um via código, use a classe correspondente.
            // Use Point para inserir as coordenadas (x e y) do label no designer.
            Label umaLabel = new Label();
            umaLabel.Location = new Point(10,10);
            umaLabel.Name = "labelUmaLabel";
            umaLabel.Text = "Uma label feita via código";

            Button umBotao = new Button();
            umBotao.Location = new Point(10,40);
            umBotao.Name = "buttonUmBotao";
            umBotao.Text = "Um botão";
            umBotao.Size = new Size(100,20);

            this.Controls.Add(umaLabel);    // Permite adicionar o controle ao designer.
            this.Controls.Add(umBotao);     // Para adicionar um controle dentro de outro, use: controlePai.Controls.Add(controleFilho);
        }
    }
}

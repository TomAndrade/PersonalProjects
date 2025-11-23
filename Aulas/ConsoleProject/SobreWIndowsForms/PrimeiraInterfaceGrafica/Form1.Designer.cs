namespace PrimeiraInterfaceGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonInicial = new Button();
            LabelTexto1 = new Label();
            buttonMsgBox = new Button();
            CaixaDeTextoSuperior = new TextBox();
            CaixaDeTextoRica = new RichTextBox();
            BotaoInverte = new Button();
            SuspendLayout();
            // 
            // buttonInicial
            // 
            buttonInicial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonInicial.BackColor = SystemColors.ControlLight;
            buttonInicial.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInicial.Location = new Point(344, 3);
            buttonInicial.Name = "buttonInicial";
            buttonInicial.Size = new Size(115, 45);
            buttonInicial.TabIndex = 0;
            buttonInicial.Text = "Botão1";
            buttonInicial.UseVisualStyleBackColor = false;
            buttonInicial.Click += buttonInicial_Click;
            buttonInicial.MouseEnter += buttonInicial_MouseEnter;
            buttonInicial.MouseLeave += buttonInicial_MouseLeave;
            // 
            // LabelTexto1
            // 
            LabelTexto1.AutoSize = true;
            LabelTexto1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTexto1.Location = new Point(12, 9);
            LabelTexto1.Name = "LabelTexto1";
            LabelTexto1.Size = new Size(85, 32);
            LabelTexto1.TabIndex = 1;
            LabelTexto1.Text = "Texto:";
            LabelTexto1.Click += LabelTexto1_Click;
            LabelTexto1.MouseEnter += LabelTexto1_MouseEnter;
            LabelTexto1.MouseLeave += LabelTexto1_MouseLeave;
            // 
            // buttonMsgBox
            // 
            buttonMsgBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMsgBox.Font = new Font("Arial", 20F);
            buttonMsgBox.Location = new Point(649, 9);
            buttonMsgBox.Name = "buttonMsgBox";
            buttonMsgBox.Size = new Size(139, 39);
            buttonMsgBox.TabIndex = 2;
            buttonMsgBox.Text = "MsgBox";
            buttonMsgBox.UseVisualStyleBackColor = true;
            buttonMsgBox.Click += buttonMsgBox_Click;
            // 
            // CaixaDeTextoSuperior
            // 
            CaixaDeTextoSuperior.Location = new Point(12, 54);
            CaixaDeTextoSuperior.Name = "CaixaDeTextoSuperior";
            CaixaDeTextoSuperior.Size = new Size(776, 23);
            CaixaDeTextoSuperior.TabIndex = 3;
            // 
            // CaixaDeTextoRica
            // 
            CaixaDeTextoRica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CaixaDeTextoRica.Location = new Point(12, 83);
            CaixaDeTextoRica.Name = "CaixaDeTextoRica";
            CaixaDeTextoRica.Size = new Size(776, 311);
            CaixaDeTextoRica.TabIndex = 4;
            CaixaDeTextoRica.Text = "";
            // 
            // BotaoInverte
            // 
            BotaoInverte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BotaoInverte.Font = new Font("Arial", 14F);
            BotaoInverte.Location = new Point(649, 400);
            BotaoInverte.Name = "BotaoInverte";
            BotaoInverte.Size = new Size(139, 38);
            BotaoInverte.TabIndex = 5;
            BotaoInverte.Text = "Inverter";
            BotaoInverte.UseVisualStyleBackColor = true;
            BotaoInverte.Click += BotaoInverte_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotaoInverte);
            Controls.Add(CaixaDeTextoRica);
            Controls.Add(CaixaDeTextoSuperior);
            Controls.Add(buttonMsgBox);
            Controls.Add(LabelTexto1);
            Controls.Add(buttonInicial);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInicial;
        private Label LabelTexto1;
        private Button buttonMsgBox;
        private TextBox CaixaDeTextoSuperior;
        private RichTextBox CaixaDeTextoRica;
        private Button BotaoInverte;
    }
}

namespace SobreMaskedTextBox
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
            maskedTextBoxNum = new MaskedTextBox();
            maskedTextBoxLetras = new MaskedTextBox();
            maskedTextBoxDate = new MaskedTextBox();
            mTBPlacaDeCarro = new MaskedTextBox();
            maskedTextBoxHora = new MaskedTextBox();
            maskedTextBoxDecimais = new MaskedTextBox();
            maskedTextBoxSenha = new MaskedTextBox();
            maskedTextBoxCelular = new MaskedTextBox();
            chkboxMercosul = new CheckBox();
            buttonVerifica = new Button();
            SuspendLayout();
            // 
            // maskedTextBoxNum
            // 
            maskedTextBoxNum.Location = new Point(12, 12);
            maskedTextBoxNum.Name = "maskedTextBoxNum";
            maskedTextBoxNum.Size = new Size(425, 23);
            maskedTextBoxNum.TabIndex = 0;
            // 
            // maskedTextBoxLetras
            // 
            maskedTextBoxLetras.Location = new Point(12, 41);
            maskedTextBoxLetras.Name = "maskedTextBoxLetras";
            maskedTextBoxLetras.Size = new Size(425, 23);
            maskedTextBoxLetras.TabIndex = 0;
            // 
            // maskedTextBoxDate
            // 
            maskedTextBoxDate.Location = new Point(12, 70);
            maskedTextBoxDate.Name = "maskedTextBoxDate";
            maskedTextBoxDate.Size = new Size(425, 23);
            maskedTextBoxDate.TabIndex = 0;
            // 
            // mTBPlacaDeCarro
            // 
            mTBPlacaDeCarro.Location = new Point(12, 99);
            mTBPlacaDeCarro.Name = "mTBPlacaDeCarro";
            mTBPlacaDeCarro.Size = new Size(425, 23);
            mTBPlacaDeCarro.TabIndex = 0;
            // 
            // maskedTextBoxHora
            // 
            maskedTextBoxHora.Location = new Point(12, 128);
            maskedTextBoxHora.Name = "maskedTextBoxHora";
            maskedTextBoxHora.Size = new Size(425, 23);
            maskedTextBoxHora.TabIndex = 0;
            // 
            // maskedTextBoxDecimais
            // 
            maskedTextBoxDecimais.Location = new Point(12, 157);
            maskedTextBoxDecimais.Name = "maskedTextBoxDecimais";
            maskedTextBoxDecimais.Size = new Size(425, 23);
            maskedTextBoxDecimais.TabIndex = 0;
            // 
            // maskedTextBoxSenha
            // 
            maskedTextBoxSenha.Location = new Point(12, 186);
            maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            maskedTextBoxSenha.Size = new Size(425, 23);
            maskedTextBoxSenha.TabIndex = 0;
            // 
            // maskedTextBoxCelular
            // 
            maskedTextBoxCelular.Location = new Point(12, 215);
            maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            maskedTextBoxCelular.Size = new Size(425, 23);
            maskedTextBoxCelular.TabIndex = 0;
            // 
            // chkboxMercosul
            // 
            chkboxMercosul.AutoSize = true;
            chkboxMercosul.Location = new Point(455, 102);
            chkboxMercosul.Name = "chkboxMercosul";
            chkboxMercosul.Size = new Size(163, 19);
            chkboxMercosul.TabIndex = 1;
            chkboxMercosul.Text = "Modelo Antigo (BRA2019)";
            chkboxMercosul.UseVisualStyleBackColor = true;
            chkboxMercosul.Click += chkboxMercosul_Click;
            // 
            // buttonVerifica
            // 
            buttonVerifica.Font = new Font("Segoe UI", 12F);
            buttonVerifica.Location = new Point(355, 257);
            buttonVerifica.Name = "buttonVerifica";
            buttonVerifica.Size = new Size(82, 30);
            buttonVerifica.TabIndex = 2;
            buttonVerifica.Text = "Validar";
            buttonVerifica.UseVisualStyleBackColor = true;
            buttonVerifica.Click += buttonVerifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVerifica);
            Controls.Add(chkboxMercosul);
            Controls.Add(maskedTextBoxCelular);
            Controls.Add(maskedTextBoxSenha);
            Controls.Add(maskedTextBoxDecimais);
            Controls.Add(maskedTextBoxHora);
            Controls.Add(mTBPlacaDeCarro);
            Controls.Add(maskedTextBoxDate);
            Controls.Add(maskedTextBoxLetras);
            Controls.Add(maskedTextBoxNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxNum;
        private MaskedTextBox maskedTextBoxLetras;
        private MaskedTextBox maskedTextBoxDate;
        private MaskedTextBox mTBPlacaDeCarro;
        private MaskedTextBox maskedTextBoxHora;
        private MaskedTextBox maskedTextBoxDecimais;
        private MaskedTextBox maskedTextBoxSenha;
        private MaskedTextBox maskedTextBoxCelular;
        private CheckBox chkboxMercosul;
        private Button buttonVerifica;
    }
}

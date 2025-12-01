namespace WinFormsProjeto11
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonCadastra = new Button();
            textBoxNumCasa = new TextBox();
            textBoxRua = new TextBox();
            textBoxDataNasc = new TextBox();
            textBoxNumDoc = new TextBox();
            textBoxNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            buttonExcluir = new Button();
            buttonBuscar = new Button();
            textBoxBuscarDoc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            labelRuaMod = new Label();
            labelNumCasaMod = new Label();
            labelNomeMod = new Label();
            labelDataNascMod = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(519, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonCadastra);
            tabPage1.Controls.Add(textBoxNumCasa);
            tabPage1.Controls.Add(textBoxRua);
            tabPage1.Controls.Add(textBoxDataNasc);
            tabPage1.Controls.Add(textBoxNumDoc);
            tabPage1.Controls.Add(textBoxNome);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(511, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCadastra
            // 
            buttonCadastra.Font = new Font("Segoe UI", 16F);
            buttonCadastra.Location = new Point(6, 180);
            buttonCadastra.Name = "buttonCadastra";
            buttonCadastra.Size = new Size(499, 54);
            buttonCadastra.TabIndex = 2;
            buttonCadastra.Text = "Cadastrar";
            buttonCadastra.UseVisualStyleBackColor = true;
            buttonCadastra.Click += buttonCadastra_Click;
            // 
            // textBoxNumCasa
            // 
            textBoxNumCasa.Location = new Point(201, 135);
            textBoxNumCasa.Name = "textBoxNumCasa";
            textBoxNumCasa.Size = new Size(304, 23);
            textBoxNumCasa.TabIndex = 1;
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(201, 106);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(304, 23);
            textBoxRua.TabIndex = 1;
            // 
            // textBoxDataNasc
            // 
            textBoxDataNasc.Location = new Point(201, 77);
            textBoxDataNasc.Name = "textBoxDataNasc";
            textBoxDataNasc.Size = new Size(304, 23);
            textBoxDataNasc.TabIndex = 1;
            // 
            // textBoxNumDoc
            // 
            textBoxNumDoc.Location = new Point(201, 48);
            textBoxNumDoc.Name = "textBoxNumDoc";
            textBoxNumDoc.Size = new Size(304, 23);
            textBoxNumDoc.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(201, 20);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(304, 23);
            textBoxNome.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(16, 133);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 0;
            label5.Text = "Número da casa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(16, 104);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 0;
            label4.Text = "Rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 75);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 0;
            label3.Text = "Data de nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 0;
            label2.Text = "Número do documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonExcluir);
            tabPage2.Controls.Add(buttonBuscar);
            tabPage2.Controls.Add(textBoxBuscarDoc);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(labelRuaMod);
            tabPage2.Controls.Add(labelNumCasaMod);
            tabPage2.Controls.Add(labelNomeMod);
            tabPage2.Controls.Add(labelDataNascMod);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(511, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Font = new Font("Segoe UI", 16F);
            buttonExcluir.Location = new Point(268, 184);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(228, 44);
            buttonExcluir.TabIndex = 7;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Segoe UI", 16F);
            buttonBuscar.Location = new Point(18, 184);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(234, 44);
            buttonBuscar.TabIndex = 7;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscarDoc
            // 
            textBoxBuscarDoc.Location = new Point(214, 17);
            textBoxBuscarDoc.Name = "textBoxBuscarDoc";
            textBoxBuscarDoc.Size = new Size(291, 23);
            textBoxBuscarDoc.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(18, 137);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 1;
            label6.Text = "Número da casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(18, 107);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 2;
            label7.Text = "Rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(18, 79);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 3;
            label8.Text = "Data de nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(18, 17);
            label9.Name = "label9";
            label9.Size = new Size(176, 21);
            label9.TabIndex = 4;
            label9.Text = "Número do documento:";
            // 
            // labelRuaMod
            // 
            labelRuaMod.AutoSize = true;
            labelRuaMod.Font = new Font("Segoe UI", 12F);
            labelRuaMod.Location = new Point(214, 107);
            labelRuaMod.Name = "labelRuaMod";
            labelRuaMod.Size = new Size(56, 21);
            labelRuaMod.TabIndex = 5;
            labelRuaMod.Text = "(vazio)";
            // 
            // labelNumCasaMod
            // 
            labelNumCasaMod.AutoSize = true;
            labelNumCasaMod.Font = new Font("Segoe UI", 12F);
            labelNumCasaMod.Location = new Point(214, 137);
            labelNumCasaMod.Name = "labelNumCasaMod";
            labelNumCasaMod.Size = new Size(56, 21);
            labelNumCasaMod.TabIndex = 5;
            labelNumCasaMod.Text = "(vazio)";
            // 
            // labelNomeMod
            // 
            labelNomeMod.AutoSize = true;
            labelNomeMod.Font = new Font("Segoe UI", 12F);
            labelNomeMod.Location = new Point(214, 48);
            labelNomeMod.Name = "labelNomeMod";
            labelNomeMod.Size = new Size(56, 21);
            labelNomeMod.TabIndex = 5;
            labelNomeMod.Text = "(vazio)";
            // 
            // labelDataNascMod
            // 
            labelDataNascMod.AutoSize = true;
            labelDataNascMod.Font = new Font("Segoe UI", 12F);
            labelDataNascMod.Location = new Point(214, 79);
            labelDataNascMod.Name = "labelDataNascMod";
            labelDataNascMod.Size = new Size(56, 21);
            labelDataNascMod.TabIndex = 5;
            labelDataNascMod.Text = "(vazio)";
            labelDataNascMod.Click += label12_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(18, 48);
            label10.Name = "label10";
            label10.Size = new Size(125, 21);
            label10.TabIndex = 5;
            label10.Text = "Nome completo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 450);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private TextBox textBoxNome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxNumCasa;
        private TextBox textBoxRua;
        private TextBox textBoxDataNasc;
        private TextBox textBoxNumDoc;
        private Button buttonCadastra;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelRuaMod;
        private Label labelNumCasaMod;
        private Label labelNomeMod;
        private Label labelDataNascMod;
        private TextBox textBoxBuscarDoc;
        private Button buttonExcluir;
        private Button buttonBuscar;
    }
}

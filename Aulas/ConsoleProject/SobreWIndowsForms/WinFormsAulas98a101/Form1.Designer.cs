namespace WinFormsAulas98a101
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
            components = new System.ComponentModel.Container();
            timerIntervalos = new System.Windows.Forms.Timer(components);
            labelTempoAtual = new Label();
            buttonPausarContinuar = new Button();
            labelInvertido = new Label();
            toolTip1 = new ToolTip(components);
            buttonAbrirSegForm = new Button();
            SuspendLayout();
            // 
            // timerIntervalos
            // 
            timerIntervalos.Enabled = true;
            timerIntervalos.Interval = 1000;
            timerIntervalos.Tick += timerIntervalos_Tick;
            // 
            // labelTempoAtual
            // 
            labelTempoAtual.AutoSize = true;
            labelTempoAtual.Font = new Font("Segoe UI", 20F);
            labelTempoAtual.Location = new Point(186, 12);
            labelTempoAtual.Name = "labelTempoAtual";
            labelTempoAtual.Size = new Size(119, 37);
            labelTempoAtual.TabIndex = 0;
            labelTempoAtual.Text = "00:00:00";
            // 
            // buttonPausarContinuar
            // 
            buttonPausarContinuar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPausarContinuar.Font = new Font("Segoe UI", 18F);
            buttonPausarContinuar.Location = new Point(47, 12);
            buttonPausarContinuar.Name = "buttonPausarContinuar";
            buttonPausarContinuar.Size = new Size(133, 41);
            buttonPausarContinuar.TabIndex = 1;
            buttonPausarContinuar.Text = "Pausar";
            buttonPausarContinuar.UseVisualStyleBackColor = true;
            buttonPausarContinuar.Click += buttonPausarContinuar_Click;
            // 
            // labelInvertido
            // 
            labelInvertido.AutoSize = true;
            labelInvertido.Font = new Font("Segoe UI", 20F);
            labelInvertido.Location = new Point(186, 49);
            labelInvertido.Name = "labelInvertido";
            labelInvertido.Size = new Size(119, 37);
            labelInvertido.TabIndex = 0;
            labelInvertido.Text = "00:00:00";
            labelInvertido.MouseHover += labelInvertido_MouseHover;
            // 
            // buttonAbrirSegForm
            // 
            buttonAbrirSegForm.Font = new Font("Segoe UI", 20F);
            buttonAbrirSegForm.Location = new Point(47, 116);
            buttonAbrirSegForm.Name = "buttonAbrirSegForm";
            buttonAbrirSegForm.Size = new Size(258, 91);
            buttonAbrirSegForm.TabIndex = 2;
            buttonAbrirSegForm.Text = "Abrir segundo formulário";
            buttonAbrirSegForm.UseVisualStyleBackColor = true;
            buttonAbrirSegForm.Click += buttonAbrirSegForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 244);
            Controls.Add(buttonAbrirSegForm);
            Controls.Add(buttonPausarContinuar);
            Controls.Add(labelInvertido);
            Controls.Add(labelTempoAtual);
            MaximizeBox = false;
            MaximumSize = new Size(387, 283);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerIntervalos;
        private Label labelTempoAtual;
        private Button buttonPausarContinuar;
        private Label labelInvertido;
        private ToolTip toolTip1;
        private Button buttonAbrirSegForm;
    }
}

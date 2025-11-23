namespace TesteLogin
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
            labelLogin = new Label();
            labelUser = new Label();
            labelPass = new Label();
            textBoxUser = new TextBox();
            maskedTextBoxPass = new MaskedTextBox();
            buttonEnter = new Button();
            labelConexao = new Label();
            progressBarPassivo = new ProgressBar();
            trackBarAtiva = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBarAtiva).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            labelLogin.Location = new Point(80, 38);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(138, 59);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 18F);
            labelUser.Location = new Point(21, 127);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(66, 32);
            labelUser.TabIndex = 1;
            labelUser.Text = "User:";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 18F);
            labelPass.Location = new Point(21, 159);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(116, 32);
            labelPass.TabIndex = 1;
            labelPass.Text = "Password:";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(161, 136);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(117, 23);
            textBoxUser.TabIndex = 2;
            // 
            // maskedTextBoxPass
            // 
            maskedTextBoxPass.Location = new Point(161, 168);
            maskedTextBoxPass.Name = "maskedTextBoxPass";
            maskedTextBoxPass.PasswordChar = '*';
            maskedTextBoxPass.Size = new Size(117, 23);
            maskedTextBoxPass.TabIndex = 3;
            // 
            // buttonEnter
            // 
            buttonEnter.Font = new Font("Segoe UI", 16F);
            buttonEnter.Location = new Point(91, 214);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(127, 41);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Connect";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            buttonEnter.KeyDown += buttonEnter_KeyDown;
            // 
            // labelConexao
            // 
            labelConexao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelConexao.AutoSize = true;
            labelConexao.Font = new Font("Segoe UI", 10F);
            labelConexao.ForeColor = Color.Red;
            labelConexao.Location = new Point(208, 269);
            labelConexao.Name = "labelConexao";
            labelConexao.Size = new Size(95, 19);
            labelConexao.TabIndex = 5;
            labelConexao.Text = "Desconectado";
            labelConexao.TextAlign = ContentAlignment.BottomRight;
            // 
            // progressBarPassivo
            // 
            progressBarPassivo.Location = new Point(203, 12);
            progressBarPassivo.Maximum = 5;
            progressBarPassivo.Name = "progressBarPassivo";
            progressBarPassivo.Size = new Size(100, 23);
            progressBarPassivo.TabIndex = 6;
            // 
            // trackBarAtiva
            // 
            trackBarAtiva.Location = new Point(8, 12);
            trackBarAtiva.Maximum = 5;
            trackBarAtiva.Name = "trackBarAtiva";
            trackBarAtiva.Size = new Size(66, 45);
            trackBarAtiva.TabIndex = 7;
            trackBarAtiva.ValueChanged += trackBarAtiva_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 297);
            Controls.Add(trackBarAtiva);
            Controls.Add(progressBarPassivo);
            Controls.Add(labelConexao);
            Controls.Add(buttonEnter);
            Controls.Add(maskedTextBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(labelPass);
            Controls.Add(labelUser);
            Controls.Add(labelLogin);
            MaximizeBox = false;
            MaximumSize = new Size(331, 336);
            MinimumSize = new Size(331, 336);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarAtiva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelUser;
        private Label labelPass;
        private TextBox textBoxUser;
        private MaskedTextBox maskedTextBoxPass;
        private Button buttonEnter;
        private Label labelConexao;
        private ProgressBar progressBarPassivo;
        private TrackBar trackBarAtiva;
    }
}

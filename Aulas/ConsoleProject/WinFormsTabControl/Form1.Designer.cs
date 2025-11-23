namespace WinFormsTabControl
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
            tabPage2 = new TabPage();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            formulárioToolStripMenuItem = new ToolStripMenuItem();
            padrãoToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(633, 419);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(625, 391);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(625, 406);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, editarToolStripMenuItem, exibirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(61, 20);
            toolStripMenuItem1.Text = "Arquivo";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // exibirToolStripMenuItem
            // 
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            exibirToolStripMenuItem.Size = new Size(48, 20);
            exibirToolStripMenuItem.Text = "Exibir";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formulárioToolStripMenuItem, padrãoToolStripMenuItem });
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            // 
            // formulárioToolStripMenuItem
            // 
            formulárioToolStripMenuItem.Name = "formulárioToolStripMenuItem";
            formulárioToolStripMenuItem.Size = new Size(180, 22);
            formulárioToolStripMenuItem.Text = "Formulário...";
            // 
            // padrãoToolStripMenuItem
            // 
            padrãoToolStripMenuItem.Name = "padrãoToolStripMenuItem";
            padrãoToolStripMenuItem.Size = new Size(180, 22);
            padrãoToolStripMenuItem.Text = "Padrão...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem formulárioToolStripMenuItem;
        private ToolStripMenuItem padrãoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem exibirToolStripMenuItem;
    }
}

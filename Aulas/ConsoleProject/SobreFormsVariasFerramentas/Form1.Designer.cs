namespace SobreFormsVariasFerramentas
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
            comboBoxClasses = new ComboBox();
            labelClassesComboBox = new Label();
            labelSubclassesComboBox = new Label();
            comboBoxSubclasse = new ComboBox();
            listBoxClasses = new ListBox();
            labelClasseListBox = new Label();
            listBoxSubclasses = new ListBox();
            label1 = new Label();
            labelSubclassesListBox = new Label();
            labelMoverClasses = new Label();
            listBoxMoverClasses = new ListBox();
            buttonAddClasse = new Button();
            buttonRemoveClasse = new Button();
            listBoxClassesMovidas = new ListBox();
            groupBox1 = new GroupBox();
            numericUpDownNumeros = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeros).BeginInit();
            SuspendLayout();
            // 
            // comboBoxClasses
            // 
            comboBoxClasses.FormattingEnabled = true;
            comboBoxClasses.Items.AddRange(new object[] { "Paladin", "Warrior", "White Wizard", "Black Wizard", "Rogue" });
            comboBoxClasses.Location = new Point(106, 30);
            comboBoxClasses.Name = "comboBoxClasses";
            comboBoxClasses.Size = new Size(176, 23);
            comboBoxClasses.TabIndex = 0;
            comboBoxClasses.SelectionChangeCommitted += comboBoxClasses_SelectionChangeCommitted;
            // 
            // labelClassesComboBox
            // 
            labelClassesComboBox.AutoSize = true;
            labelClassesComboBox.Font = new Font("Segoe UI", 12F);
            labelClassesComboBox.Location = new Point(12, 28);
            labelClassesComboBox.Name = "labelClassesComboBox";
            labelClassesComboBox.Size = new Size(57, 21);
            labelClassesComboBox.TabIndex = 1;
            labelClassesComboBox.Text = "Classe:";
            // 
            // labelSubclassesComboBox
            // 
            labelSubclassesComboBox.AutoSize = true;
            labelSubclassesComboBox.Font = new Font("Segoe UI", 12F);
            labelSubclassesComboBox.Location = new Point(12, 65);
            labelSubclassesComboBox.Name = "labelSubclassesComboBox";
            labelSubclassesComboBox.Size = new Size(81, 21);
            labelSubclassesComboBox.TabIndex = 1;
            labelSubclassesComboBox.Text = "Subclasse:";
            // 
            // comboBoxSubclasse
            // 
            comboBoxSubclasse.Enabled = false;
            comboBoxSubclasse.FormattingEnabled = true;
            comboBoxSubclasse.Location = new Point(106, 67);
            comboBoxSubclasse.Name = "comboBoxSubclasse";
            comboBoxSubclasse.Size = new Size(176, 23);
            comboBoxSubclasse.TabIndex = 2;
            // 
            // listBoxClasses
            // 
            listBoxClasses.FormattingEnabled = true;
            listBoxClasses.ItemHeight = 15;
            listBoxClasses.Items.AddRange(new object[] { "Paladin", "Warrior", "White Wizard", "Black Wizard", "Rogue" });
            listBoxClasses.Location = new Point(12, 164);
            listBoxClasses.Name = "listBoxClasses";
            listBoxClasses.Size = new Size(120, 94);
            listBoxClasses.TabIndex = 3;
            listBoxClasses.SelectedIndexChanged += listBoxClasses_SelectedIndexChanged;
            // 
            // labelClasseListBox
            // 
            labelClasseListBox.AutoSize = true;
            labelClasseListBox.Font = new Font("Segoe UI", 12F);
            labelClasseListBox.Location = new Point(12, 140);
            labelClasseListBox.Name = "labelClasseListBox";
            labelClasseListBox.Size = new Size(57, 21);
            labelClasseListBox.TabIndex = 1;
            labelClasseListBox.Text = "Classe:";
            // 
            // listBoxSubclasses
            // 
            listBoxSubclasses.Enabled = false;
            listBoxSubclasses.FormattingEnabled = true;
            listBoxSubclasses.ItemHeight = 15;
            listBoxSubclasses.Location = new Point(188, 164);
            listBoxSubclasses.Name = "listBoxSubclasses";
            listBoxSubclasses.Size = new Size(120, 94);
            listBoxSubclasses.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(138, 196);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 5;
            label1.Text = ">>>";
            // 
            // labelSubclassesListBox
            // 
            labelSubclassesListBox.AutoSize = true;
            labelSubclassesListBox.Font = new Font("Segoe UI", 12F);
            labelSubclassesListBox.Location = new Point(188, 140);
            labelSubclassesListBox.Name = "labelSubclassesListBox";
            labelSubclassesListBox.Size = new Size(81, 21);
            labelSubclassesListBox.TabIndex = 1;
            labelSubclassesListBox.Text = "Subclasse:";
            // 
            // labelMoverClasses
            // 
            labelMoverClasses.AutoSize = true;
            labelMoverClasses.Font = new Font("Segoe UI", 12F);
            labelMoverClasses.Location = new Point(12, 277);
            labelMoverClasses.Name = "labelMoverClasses";
            labelMoverClasses.Size = new Size(57, 21);
            labelMoverClasses.TabIndex = 1;
            labelMoverClasses.Text = "Classe:";
            // 
            // listBoxMoverClasses
            // 
            listBoxMoverClasses.FormattingEnabled = true;
            listBoxMoverClasses.ItemHeight = 15;
            listBoxMoverClasses.Items.AddRange(new object[] { "Paladin", "Warrior", "White Wizard", "Black Wizard", "Rogue" });
            listBoxMoverClasses.Location = new Point(12, 301);
            listBoxMoverClasses.Name = "listBoxMoverClasses";
            listBoxMoverClasses.Size = new Size(120, 94);
            listBoxMoverClasses.TabIndex = 6;
            // 
            // buttonAddClasse
            // 
            buttonAddClasse.Location = new Point(138, 322);
            buttonAddClasse.Name = "buttonAddClasse";
            buttonAddClasse.Size = new Size(44, 23);
            buttonAddClasse.TabIndex = 7;
            buttonAddClasse.Text = ">>>";
            buttonAddClasse.UseVisualStyleBackColor = true;
            buttonAddClasse.Click += buttonAddClasse_Click;
            // 
            // buttonRemoveClasse
            // 
            buttonRemoveClasse.Location = new Point(138, 351);
            buttonRemoveClasse.Name = "buttonRemoveClasse";
            buttonRemoveClasse.Size = new Size(44, 23);
            buttonRemoveClasse.TabIndex = 7;
            buttonRemoveClasse.Text = "<<<";
            buttonRemoveClasse.UseVisualStyleBackColor = true;
            buttonRemoveClasse.Click += buttonRemoveClasse_Click;
            // 
            // listBoxClassesMovidas
            // 
            listBoxClassesMovidas.FormattingEnabled = true;
            listBoxClassesMovidas.ItemHeight = 15;
            listBoxClassesMovidas.Location = new Point(188, 301);
            listBoxClassesMovidas.Name = "listBoxClassesMovidas";
            listBoxClassesMovidas.Size = new Size(120, 94);
            listBoxClassesMovidas.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownNumeros);
            groupBox1.Location = new Point(334, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 426);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caixa de grupos";
            // 
            // numericUpDownNumeros
            // 
            numericUpDownNumeros.Location = new Point(18, 56);
            numericUpDownNumeros.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNumeros.Name = "numericUpDownNumeros";
            numericUpDownNumeros.Size = new Size(77, 23);
            numericUpDownNumeros.TabIndex = 0;
            numericUpDownNumeros.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(listBoxClassesMovidas);
            Controls.Add(buttonRemoveClasse);
            Controls.Add(buttonAddClasse);
            Controls.Add(listBoxMoverClasses);
            Controls.Add(label1);
            Controls.Add(listBoxSubclasses);
            Controls.Add(listBoxClasses);
            Controls.Add(comboBoxSubclasse);
            Controls.Add(labelSubclassesComboBox);
            Controls.Add(labelSubclassesListBox);
            Controls.Add(labelMoverClasses);
            Controls.Add(labelClasseListBox);
            Controls.Add(labelClassesComboBox);
            Controls.Add(comboBoxClasses);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClasses;
        private Label labelClassesComboBox;
        private Label labelSubclassesComboBox;
        private ComboBox comboBoxSubclasse;
        private ListBox listBoxClasses;
        private Label labelClasseListBox;
        private ListBox listBoxSubclasses;
        private Label label1;
        private Label labelSubclassesListBox;
        private Label labelMoverClasses;
        private ListBox listBoxMoverClasses;
        private Button buttonAddClasse;
        private Button buttonRemoveClasse;
        private ListBox listBoxClassesMovidas;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownNumeros;
    }
}

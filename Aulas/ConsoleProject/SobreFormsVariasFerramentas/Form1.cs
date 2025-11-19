namespace SobreFormsVariasFerramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxClasses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxSubclasse.Enabled = true;
            switch (comboBoxClasses.SelectedItem)
            {
                case "Paladin":
                    comboBoxSubclasse.Items.Clear();
                    comboBoxSubclasse.Text = "";
                    comboBoxSubclasse.Items.Add("Hero");                        // One-handed sword only, one-handed sword + shield, one-handed axe only 
                    comboBoxSubclasse.Items.Add("Duelist");                     // Various mid range weapons
                    comboBoxSubclasse.Items.Add("Inquisitor"); break;           // 
                case "Warrior":
                    comboBoxSubclasse.Items.Clear();
                    comboBoxSubclasse.Text = "";
                    comboBoxSubclasse.Items.Add("Warlord");                     // Two-handed sowrd, two-handed axe, hammer, one-handed spear + shield, two-handed spear.
                    comboBoxSubclasse.Items.Add("Barbarian");                   // One-handed double axe, two-handed double axe
                    comboBoxSubclasse.Items.Add("Fighter"); break;              // Gauntlet, bare hands, morning star
                case "White Wizard":
                    comboBoxSubclasse.Items.Clear();
                    comboBoxSubclasse.Text = "";
                    comboBoxSubclasse.Items.Add("Cleric");                      // Wand, staff, grimoire
                    comboBoxSubclasse.Items.Add("Shaman");                      // Various summoning weapons.
                    comboBoxSubclasse.Items.Add("Alchemist"); break;            // Various summoning weapons.
                case "Black Wizard":
                    comboBoxSubclasse.Items.Clear();
                    comboBoxSubclasse.Text = "";
                    comboBoxSubclasse.Items.Add("Necromancer");                 // Tome, staff
                    comboBoxSubclasse.Items.Add("Sorcerer");                    // Grimoire, staff
                    comboBoxSubclasse.Items.Add("Healer"); break;               // staff.
                case "Rogue":
                    comboBoxSubclasse.Items.Clear();
                    comboBoxSubclasse.Text = "";
                    comboBoxSubclasse.Items.Add("Assassin/ Thief"); break;      // One dagger, two daggers, gauntlet, bare hands, dagger
                default: MessageBox.Show("Choose a class.", "No class selected", MessageBoxButtons.OK); break;
            }
        }

        private void buttonAddClasse_Click(object sender, EventArgs e)
        {
            if (listBoxMoverClasses.SelectedItem != null)
            {
                if (!listBoxClassesMovidas.Items.Contains(listBoxMoverClasses.SelectedItem))
                {
                    listBoxClassesMovidas.Items.Add(listBoxMoverClasses.SelectedItem);
                    listBoxMoverClasses.Items.Remove(listBoxMoverClasses.SelectedItem);
                }
            }
        }

        private void buttonRemoveClasse_Click(object sender, EventArgs e)
        {
            if (listBoxClassesMovidas.SelectedItem != null)
            {
                if (!listBoxMoverClasses.Items.Contains(listBoxClassesMovidas.SelectedItem))
                {
                    listBoxMoverClasses.Items.Add(listBoxClassesMovidas.SelectedItem);
                    //listBoxMoverClasses.Items[0] = listBoxClassesMovidas.SelectedItem;
                    listBoxClassesMovidas.Items.Remove(listBoxClassesMovidas.SelectedItem);
                }
            }
        }

        private void listBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSubclasses.Enabled = true;
            switch (listBoxClasses.SelectedItem)
            {
                case "Paladin":
                    listBoxSubclasses.Items.Clear();
                    listBoxSubclasses.Items.Add("Hero");
                    listBoxSubclasses.Items.Add("Duelist");
                    listBoxSubclasses.Items.Add("Inquisitor"); break;
                case "Warrior":
                    listBoxSubclasses.Items.Clear();
                    listBoxSubclasses.Items.Add("Warlord");
                    listBoxSubclasses.Items.Add("Barbarian");
                    listBoxSubclasses.Items.Add("Fighter"); break;
                case "White Wizard":
                    listBoxSubclasses.Items.Clear();
                    listBoxSubclasses.Items.Add("Cleric");
                    listBoxSubclasses.Items.Add("Shaman");
                    listBoxSubclasses.Items.Add("Alchemist"); break;
                case "Black Wizard":
                    listBoxSubclasses.Items.Clear();
                    listBoxSubclasses.Items.Add("Necromancer");
                    listBoxSubclasses.Items.Add("Sorcerer");
                    listBoxSubclasses.Items.Add("Healer"); break;
                case "Rogue":
                    listBoxSubclasses.Items.Clear();
                    listBoxSubclasses.Items.Add("Assasssin/ Thief"); break;
            }
        }
    }
}

namespace DND_Character_manager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRaces_Click(object sender, EventArgs e)
        {
            new FormRaces().Show();
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            new FormClasses().Show();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            new FormItems().Show();
        }

        private void buttonCharacters_Click(object sender, EventArgs e)
        {
            new FormCharacters().Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

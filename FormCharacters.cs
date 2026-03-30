using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Character_manager
{
    public partial class FormCharacters : Form
    {
        private BindingNavigator bindingNavigatorCharacters;
        public FormCharacters()
        {
            InitializeComponent();

            bindingNavigatorCharacters = new BindingNavigator(true); //true creates all bindingNavigator buttons
            bindingNavigatorCharacters.Name = "bindingNavigatorCharacters";
            bindingNavigatorCharacters.Dock = DockStyle.Top;
            bindingNavigatorCharacters.BindingSource = bindingSourceCharacters;

            Controls.Add(bindingNavigatorCharacters); //displays on form
            bindingNavigatorCharacters.BringToFront();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

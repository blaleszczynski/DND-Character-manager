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
    public partial class FormClasses : Form
    {
        private BindingNavigator bindingNavigatorClasses;
        public FormClasses()
        {
            InitializeComponent();

            bindingNavigatorClasses = new BindingNavigator(true); //true creates all bindingNavigator buttons
            bindingNavigatorClasses.Name = "bindingNavigatorClasses";
            bindingNavigatorClasses.Dock = DockStyle.Top;
            bindingNavigatorClasses.BindingSource = bindingSourceClasses;

            Controls.Add(bindingNavigatorClasses); //displays on form
            bindingNavigatorClasses.BringToFront();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormRaces : Form
    {
        private BindingNavigator bindingNavigatorRaces; //can't find BindingNavigator in Toolbox
        public FormRaces()
        {
            InitializeComponent();

            bindingNavigatorRaces = new BindingNavigator(true); //true creates all bindingNavigator buttons
            bindingNavigatorRaces.Name = "bindingNavigatorRaces";
            bindingNavigatorRaces.Dock = DockStyle.Top;
            bindingNavigatorRaces.BindingSource = bindingSourceRaces;

            Controls.Add(bindingNavigatorRaces); //displays on form
            bindingNavigatorRaces.BringToFront();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

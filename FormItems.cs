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
    public partial class FormItems : Form
    {
        private BindingNavigator bindingNavigatorItems;
        public FormItems()
        {
            InitializeComponent();

            bindingNavigatorItems = new BindingNavigator(true); //true creates all bindingNavigator buttons
            bindingNavigatorItems.Name = "bindingNavigatorItems";
            bindingNavigatorItems.Dock = DockStyle.Top;
            bindingNavigatorItems.BindingSource = bindingSourceItems;

            Controls.Add(bindingNavigatorItems); //displays on form
            bindingNavigatorItems.BringToFront();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DND_Character_manager
{
    public partial class FormRaces : Form
    {
        private SQLiteConnection connection;
        private SQLiteDataAdapter adapter;
        private DataTable dataTable;

        public FormRaces()
        {
            InitializeComponent();
        }

        private void FormRaces_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=DND_database.db;Version=3;");
                adapter = new SQLiteDataAdapter("SELECT * FROM Races", connection);

                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                bindingSourceRaces.DataSource = dataTable;
                dataGridViewRaces.DataSource = bindingSourceRaces;

                comboBoxRaceSize.Items.Clear();
                comboBoxRaceSize.Items.AddRange(new string[] { "Small", "Medium", "Large" });

                textBoxRaceName.DataBindings.Clear();
                textBoxRaceName.DataBindings.Add("Text", bindingSourceRaces, "name", true, DataSourceUpdateMode.OnPropertyChanged);

                numericUpDownRaceSpeed.DataBindings.Clear();
                numericUpDownRaceSpeed.DataBindings.Add("Value", bindingSourceRaces, "speed", true, DataSourceUpdateMode.OnPropertyChanged);

                comboBoxRaceSize.DataBindings.Clear();
                comboBoxRaceSize.DataBindings.Add("Text", bindingSourceRaces, "size", true, DataSourceUpdateMode.OnPropertyChanged);

                textBoxAbilityBonusDescription.DataBindings.Clear();
                textBoxAbilityBonusDescription.DataBindings.Add("Text", bindingSourceRaces, "ability_bonus_description", true, DataSourceUpdateMode.OnPropertyChanged);


                dataGridViewRaces.ReadOnly = true;
                dataGridViewRaces.AllowUserToAddRows = false;
                dataGridViewRaces.AllowUserToDeleteRows = false;
                dataGridViewRaces.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewRaces.MultiSelect = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateRace()
        {
            errorProviderRaces.Clear();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBoxRaceName.Text))
            {
                errorProviderRaces.SetError(textBoxRaceName, "Name is required.");
                isValid = false;
            }

            if (comboBoxRaceSize.SelectedIndex == -1 && string.IsNullOrWhiteSpace(comboBoxRaceSize.Text))
            {
                errorProviderRaces.SetError(comboBoxRaceSize, "Size is required.");
                isValid = false;
            }

            return isValid;
        }

        private void buttonAddRace_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceRaces.EndEdit();

                DataRow newRow = dataTable.NewRow();
                newRow["name"] = "";
                newRow["speed"] = 0;
                newRow["size"] = "Medium";
                newRow["ability_bonus_description"] = "";

                dataTable.Rows.Add(newRow);
                bindingSourceRaces.Position = bindingSourceRaces.Count - 1;

                textBoxRaceName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteRace_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceRaces.Current == null)
                {
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Delete selected race?",
                    "Confirm delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bindingSourceRaces.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateRace())
                {
                    return;
                }

                Validate();
                bindingSourceRaces.EndEdit();
                adapter.Update(dataTable);

                MessageBox.Show("Zapisano zmiany");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormRaces_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bindingSourceRaces.EndEdit();

                if (dataTable != null && dataTable.GetChanges() != null)
                {
                    DialogResult result = MessageBox.Show(
                        "Do you want to save the changes?",
                        "Unsaved changes",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!ValidateRace())
                        {
                            e.Cancel = true;
                            return;
                        }

                        Validate();
                        bindingSourceRaces.EndEdit();
                        adapter.Update(dataTable);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
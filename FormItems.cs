using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DND_Character_manager
{
    public partial class FormItems : Form
    {
        private BindingNavigator bindingNavigatorItems;
        private SQLiteConnection connection;
        private SQLiteDataAdapter adapter;
        private DataTable dataTable;

        public FormItems()
        {
            InitializeComponent();
        }



        private string GetDefaultItemName()
        {
            int number = 1;
            string name = "New Item " + number;

            while (ItemNameExists(name))
            {
                number++;
                name = "New Item " + number;
            }

            return name;
        }

        private bool ItemNameExists(string name)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;
                if (string.Equals(row["name"].ToString(), name, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }


        private bool ValidateItems()
        {
            var names = new System.Collections.Generic.HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (DataRow row in dataTable.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                string name = row["name"].ToString().Trim();

                if (string.IsNullOrWhiteSpace(name))
                    return false;

                if (!names.Add(name))
                    return false;

                object weightObj = row["weight"];
                if (weightObj == DBNull.Value)
                    return false;

                double weight;
                try
                {
                    weight = Convert.ToDouble(weightObj);
                }
                catch
                {
                    return false;
                }

                if (weight < 0)
                    return false;
            }

            return true;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                bindingSourceItems.EndEdit();

                if (!ValidateItems())
                {
                    MessageBox.Show("Błąd walidacji: nazwa wymagana, nazwy unikalne, waga >= 0.");
                    return;
                }

                DataTable changes = dataTable.GetChanges();
                if (changes == null)
                {
                    MessageBox.Show("Brak zmian do zapisania.");
                    return;
                }

                adapter.Update(changes);

                dataTable.Clear();
                adapter.Fill(dataTable);

                MessageBox.Show("Zapisano zmiany.");
            }
            catch (SQLiteException ex) when (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
            {
                MessageBox.Show("Błąd bazy danych: nazwa przedmiotu musi być unikalna i niepusta.");
                dataTable.RejectChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania: " + ex.Message);
                dataTable.RejectChanges();
            }
        }



      

        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTable == null)
                {
                    MessageBox.Show("Dane nie zostały załadowane. Sprawdź, czy FormItems_Load jest podpięty.");
                    return;
                }

                bindingSourceItems.EndEdit();

                DataRow newRow = dataTable.NewRow();
                newRow["name"] = GetDefaultItemName();
                newRow["type"] = "";
                newRow["description"] = "";
                newRow["weight"] = 0.0;

                dataTable.Rows.Add(newRow);
                bindingSourceItems.Position = bindingSourceItems.Count - 1;

                textBoxItemName.Focus();
                textBoxItemName.SelectAll();

                MessageBox.Show("Dodano nowy przedmiot. Uzupełnij dane i kliknij 'Save changes'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania: " + ex.Message);
            }
        }

        private void FormItems_Load_1(object sender, EventArgs e)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=DND_database.db;Version=3;");
                adapter = new SQLiteDataAdapter("SELECT * FROM Items", connection);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                bindingSourceItems.DataSource = dataTable;
                dataGridViewItems.DataSource = bindingSourceItems;

                textBoxItemName.DataBindings.Clear();
                textBoxItemType.DataBindings.Clear();
                numericUpDownItemWeight.DataBindings.Clear();
                textBoxItemDescription.DataBindings.Clear();

                textBoxItemName.DataBindings.Add("Text", bindingSourceItems, "name", true, DataSourceUpdateMode.OnPropertyChanged);
                textBoxItemType.DataBindings.Add("Text", bindingSourceItems, "type", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownItemWeight.DataBindings.Add("Value", bindingSourceItems, "weight", true, DataSourceUpdateMode.OnPropertyChanged);
                textBoxItemDescription.DataBindings.Add("Text", bindingSourceItems, "description", true, DataSourceUpdateMode.OnPropertyChanged);

                dataGridViewItems.ReadOnly = true;
                dataGridViewItems.AllowUserToAddRows = false;
                dataGridViewItems.AllowUserToDeleteRows = false;
                dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewItems.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas ładowania danych: " + ex.Message);
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceItems.Current == null) return;

                string itemName = ((DataRowView)bindingSourceItems.Current)["name"].ToString();

                var result = MessageBox.Show("Usunąć przedmiot: " + itemName + "?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bindingSourceItems.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania: " + ex.Message);
            }
        }

        private void FormItems_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                bindingSourceItems.EndEdit();

                if (dataTable != null && dataTable.GetChanges() != null)
                {
                    var result = MessageBox.Show("Masz niezapisane zmiany. Zapisać przed zamknięciem?", "Niezapisane zmiany",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        buttonSaveChanges.PerformClick();
                        if (dataTable.GetChanges() != null)
                            e.Cancel = true;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zamykania: " + ex.Message);
                e.Cancel = true;
            }
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DND_Character_manager
{
    public partial class FormClasses : Form
    {
        private BindingNavigator bindingNavigatorClasses;
        private SQLiteConnection connection;
        private SQLiteDataAdapter adapter;
        private DataTable dataTable;
        private bool isNewRowAdded = false;
        private int newRowIndex = -1;

        public FormClasses()
        {
            InitializeComponent();
        }

        private void FormClasses_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=DND_database.db;Version=3;");
                adapter = new SQLiteDataAdapter("SELECT * FROM Classes", connection);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                bindingSourceClasses.DataSource = dataTable;
                dataGridViewClasses.DataSource = bindingSourceClasses;

                comboBoxPrimaryAbility.Items.Clear();
                comboBoxPrimaryAbility.Items.AddRange(new string[] { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" });

                textBoxClassName.DataBindings.Add("Text", bindingSourceClasses, "name", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownHitDie.DataBindings.Add("Value", bindingSourceClasses, "hit_die", true, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxPrimaryAbility.DataBindings.Add("Text", bindingSourceClasses, "primary_ability", true, DataSourceUpdateMode.OnPropertyChanged);

               
                dataGridViewClasses.ReadOnly = true;
                dataGridViewClasses.AllowUserToAddRows = false;
                dataGridViewClasses.AllowUserToDeleteRows = false;
                dataGridViewClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewClasses.MultiSelect = false;

                
                bindingSourceClasses.PositionChanged += BindingSourceClasses_PositionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindingSourceClasses_PositionChanged(object sender, EventArgs e)
        {
           
            if (isNewRowAdded && bindingSourceClasses.Position != newRowIndex)
            {
                var result = MessageBox.Show(
                    "Dodałeś nową klasę, która nie została jeszcze zapisana. Czy chcesz ją zachować?",
                    "Niezapisana nowa klasa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                  
                    DataRow rowToDelete = dataTable.Rows[newRowIndex];
                    dataTable.Rows.Remove(rowToDelete);
                    isNewRowAdded = false;
                    newRowIndex = -1;
                }
            }
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (isNewRowAdded)
                {
                    MessageBox.Show("Najpierw zapisz lub usuń poprzednio dodaną klasę.",
                        "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceClasses.Position = newRowIndex;
                    return;
                }

                bindingSourceClasses.EndEdit();

               
                DataRow newRow = dataTable.NewRow();
                newRow["name"] = "Nowa klasa";
                newRow["hit_die"] = 6;
                newRow["primary_ability"] = "Strength";

                dataTable.Rows.Add(newRow);

                
                isNewRowAdded = true;
                newRowIndex = dataTable.Rows.Count - 1;

                bindingSourceClasses.Position = bindingSourceClasses.Count - 1;

              
                textBoxClassName.Focus();
                textBoxClassName.SelectAll();

                MessageBox.Show("Dodano nową klasę. Edytuj jej dane w polach powyżej i kliknij 'Zapisz zmiany', aby trwale zapisać w bazie.",
                    "Dodano klasę", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania: " + ex.Message);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
               
                Validate();
                bindingSourceClasses.EndEdit();

                
                if (!ValidateUniqueClassNames())
                {
                    MessageBox.Show("Błąd: Znaleziono duplikaty nazw klas. Każda klasa musi mieć unikalną nazwę.",
                        "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                DataTable changes = dataTable.GetChanges();
                if (changes == null)
                {
                    MessageBox.Show("Brak zmian do zapisania.");
                    return;
                }

               
                adapter.Update(changes);
                dataTable.AcceptChanges();

               
                isNewRowAdded = false;
                newRowIndex = -1;

                MessageBox.Show("Zapisano zmiany pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException ex) when (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
            {
                MessageBox.Show("Błąd zapisu: Nazwa klasy musi być unikalna. Sprawdź, czy nie próbujesz zapisać duplikatu.",
                    "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataTable.RejectChanges();
                isNewRowAdded = false;
                newRowIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania: " + ex.Message);
                dataTable.RejectChanges();
                isNewRowAdded = false;
                newRowIndex = -1;
            }
        }

        private bool ValidateUniqueClassNames()
        {
            var classNames = new System.Collections.Generic.HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (DataRow row in dataTable.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;

                string name = row["name"].ToString().Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Nazwa klasy nie może być pusta.", "Błąd walidacji",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!classNames.Add(name))
                {
                    return false;  
                }
            }

            return true;
        }

        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {
            if (bindingSourceClasses.Current == null)
            {
                MessageBox.Show("Nie wybrano klasy do usunięcia.", "Informacja",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView currentRow = (DataRowView)bindingSourceClasses.Current;
            string className = currentRow["name"].ToString();

            DialogResult result = MessageBox.Show(
                $"Czy na pewno chcesz usunąć klasę '{className}'?\n\nPamiętaj, aby kliknąć 'Zapisz zmiany' w celu trwałego usunięcia z bazy.",
                "Potwierdź usunięcie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                if (isNewRowAdded && bindingSourceClasses.Position == newRowIndex)
                {
                    isNewRowAdded = false;
                    newRowIndex = -1;
                }

                bindingSourceClasses.RemoveCurrent();
            }
        }

        private void FormClasses_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bindingSourceClasses.EndEdit();

                if (dataTable != null && dataTable.GetChanges() != null)
                {
                    var result = MessageBox.Show(
                        "Masz niezapisane zmiany. Czy chcesz je zapisać?",
                        "Niezapisane zmiany",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        buttonSaveChanges.PerformClick();

                       
                        if (dataTable.GetChanges() != null)
                        {
                            e.Cancel = true;
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else 
                    {
                        dataTable.RejectChanges();
                        isNewRowAdded = false;
                        newRowIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zamykania formularza: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
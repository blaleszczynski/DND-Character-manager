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
    public partial class FormCharacters : Form
    {
        private SQLiteConnection connection;

        private SQLiteDataAdapter charactersAdapter;
        private SQLiteDataAdapter characterItemsAdapter;
        private SQLiteDataAdapter racesAdapter;
        private SQLiteDataAdapter classesAdapter;
        private SQLiteDataAdapter itemsAdapter;

        private DataTable charactersTable;
        private DataTable characterItemsTable;
        private DataTable racesTable;
        private DataTable classesTable;
        private DataTable itemsTable;

        private DataView characterItemsView; 

        public FormCharacters()
        {
            InitializeComponent();
        }

        private void FormCharacters_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=DND_database.db;Version=3;");

                charactersAdapter = new SQLiteDataAdapter("SELECT * FROM Characters", connection);
                characterItemsAdapter = new SQLiteDataAdapter("SELECT * FROM CharacterItems", connection);
                racesAdapter = new SQLiteDataAdapter("SELECT id, name FROM Races", connection);
                classesAdapter = new SQLiteDataAdapter("SELECT id, name FROM Classes", connection);
                itemsAdapter = new SQLiteDataAdapter("SELECT id, name FROM Items", connection);

                SQLiteCommandBuilder charactersBuilder = new SQLiteCommandBuilder(charactersAdapter);
                SQLiteCommandBuilder characterItemsBuilder = new SQLiteCommandBuilder(characterItemsAdapter);

                charactersTable = new DataTable();
                characterItemsTable = new DataTable();
                racesTable = new DataTable();
                classesTable = new DataTable();
                itemsTable = new DataTable();

                charactersAdapter.Fill(charactersTable);
                characterItemsAdapter.Fill(characterItemsTable);
                racesAdapter.Fill(racesTable);
                classesAdapter.Fill(classesTable);
                itemsAdapter.Fill(itemsTable);

                bindingSourceCharacters.DataSource = charactersTable;
                dataGridViewCharacters.DataSource = bindingSourceCharacters;

                characterItemsView = new DataView(characterItemsTable);
                bindingSourceCharacterItems.DataSource = characterItemsView;
                dataGridViewCharacterItems.DataSource = bindingSourceCharacterItems;

                comboBoxAlignment.Items.Clear();
                comboBoxAlignment.Items.AddRange(new string[]
                {
                    "Lawful Good",
                    "Neutral Good",
                    "Chaotic Good",
                    "Lawful Neutral",
                    "True Neutral",
                    "Chaotic Neutral",
                    "Lawful Evil",
                    "Neutral Evil",
                    "Chaotic Evil"
                });

                comboBoxRace.DataSource = racesTable;
                comboBoxRace.DisplayMember = "name";
                comboBoxRace.ValueMember = "id";
                comboBoxRace.SelectedIndex = -1;

                comboBoxClass.DataSource = classesTable;
                comboBoxClass.DisplayMember = "name";
                comboBoxClass.ValueMember = "id";
                comboBoxClass.SelectedIndex = -1;

                comboBoxAvailableItems.DataSource = itemsTable;
                comboBoxAvailableItems.DisplayMember = "name";
                comboBoxAvailableItems.ValueMember = "id";
                comboBoxAvailableItems.SelectedIndex = -1;

                textBoxCharacterName.DataBindings.Clear();
                textBoxBackground.DataBindings.Clear();
                textBoxNotes.DataBindings.Clear();

                comboBoxAlignment.DataBindings.Clear();
                comboBoxRace.DataBindings.Clear();
                comboBoxClass.DataBindings.Clear();

                numericUpDownLevel.DataBindings.Clear();
                numericUpDownStrength.DataBindings.Clear();
                numericUpDownDexterity.DataBindings.Clear();
                numericUpDownConstitution.DataBindings.Clear();
                numericUpDownIntelligence.DataBindings.Clear();
                numericUpDownWisdom.DataBindings.Clear();
                numericUpDownCharisma.DataBindings.Clear();
                numericUpDownMaxHp.DataBindings.Clear();
                numericUpDownCurrentHp.DataBindings.Clear();

                comboBoxAvailableItems.DataBindings.Clear();
                numericUpDownItemQuantity.DataBindings.Clear();
                checkBoxIsEquipped.DataBindings.Clear();

                textBoxCharacterName.DataBindings.Add("Text", bindingSourceCharacters, "name", true, DataSourceUpdateMode.OnPropertyChanged);
                textBoxBackground.DataBindings.Add("Text", bindingSourceCharacters, "background", true, DataSourceUpdateMode.OnPropertyChanged);
                textBoxNotes.DataBindings.Add("Text", bindingSourceCharacters, "notes", true, DataSourceUpdateMode.OnPropertyChanged);

                comboBoxAlignment.DataBindings.Add("Text", bindingSourceCharacters, "alignment", true, DataSourceUpdateMode.OnPropertyChanged);
                comboBoxRace.DataBindings.Add("SelectedValue", bindingSourceCharacters, "race_id", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
                comboBoxClass.DataBindings.Add("SelectedValue", bindingSourceCharacters, "class_id", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);

                numericUpDownLevel.DataBindings.Add("Value", bindingSourceCharacters, "level", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownStrength.DataBindings.Add("Value", bindingSourceCharacters, "strength", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownDexterity.DataBindings.Add("Value", bindingSourceCharacters, "dexterity", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownConstitution.DataBindings.Add("Value", bindingSourceCharacters, "constitution", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownIntelligence.DataBindings.Add("Value", bindingSourceCharacters, "intelligence", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownWisdom.DataBindings.Add("Value", bindingSourceCharacters, "wisdom", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownCharisma.DataBindings.Add("Value", bindingSourceCharacters, "charisma", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownMaxHp.DataBindings.Add("Value", bindingSourceCharacters, "max_hp", true, DataSourceUpdateMode.OnPropertyChanged);
                numericUpDownCurrentHp.DataBindings.Add("Value", bindingSourceCharacters, "current_hp", true, DataSourceUpdateMode.OnPropertyChanged);

                comboBoxAvailableItems.DataBindings.Add("SelectedValue", bindingSourceCharacterItems, "item_id", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
                numericUpDownItemQuantity.DataBindings.Add("Value", bindingSourceCharacterItems, "quantity", true, DataSourceUpdateMode.OnPropertyChanged);
                checkBoxIsEquipped.DataBindings.Add("Checked", bindingSourceCharacterItems, "is_equipped", true, DataSourceUpdateMode.OnPropertyChanged);

                dataGridViewCharacters.ReadOnly = true;
                dataGridViewCharacters.AllowUserToAddRows = false;
                dataGridViewCharacters.AllowUserToDeleteRows = false;
                dataGridViewCharacters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewCharacters.MultiSelect = false;

                dataGridViewCharacterItems.ReadOnly = true;
                dataGridViewCharacterItems.AllowUserToAddRows = false;
                dataGridViewCharacterItems.AllowUserToDeleteRows = false;
                dataGridViewCharacterItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewCharacterItems.MultiSelect = false;
                dataGridViewCharacterItems.AutoGenerateColumns = false;
                dataGridViewCharacterItems.Columns.Clear();

                DataGridViewTextBoxColumn columnCharacterId = new DataGridViewTextBoxColumn();
                columnCharacterId.DataPropertyName = "character_id";
                columnCharacterId.Name = "character_id";
                columnCharacterId.Visible = false;
                dataGridViewCharacterItems.Columns.Add(columnCharacterId);

                DataGridViewTextBoxColumn columnItemIdHidden = new DataGridViewTextBoxColumn();
                columnItemIdHidden.DataPropertyName = "item_id";
                columnItemIdHidden.Name = "item_id";
                columnItemIdHidden.Visible = false;
                dataGridViewCharacterItems.Columns.Add(columnItemIdHidden);

                DataGridViewComboBoxColumn columnItemName = new DataGridViewComboBoxColumn();
                columnItemName.Name = "item_name";
                columnItemName.HeaderText = "Item";
                columnItemName.DataPropertyName = "item_id";
                columnItemName.DataSource = itemsTable;
                columnItemName.DisplayMember = "name";
                columnItemName.ValueMember = "id";
                columnItemName.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                dataGridViewCharacterItems.Columns.Add(columnItemName);

                DataGridViewTextBoxColumn columnQuantity = new DataGridViewTextBoxColumn();
                columnQuantity.Name = "quantity";
                columnQuantity.HeaderText = "Quantity";
                columnQuantity.DataPropertyName = "quantity";
                dataGridViewCharacterItems.Columns.Add(columnQuantity);

                DataGridViewCheckBoxColumn columnEquipped = new DataGridViewCheckBoxColumn();
                columnEquipped.Name = "is_equipped";
                columnEquipped.HeaderText = "Equipped";
                columnEquipped.DataPropertyName = "is_equipped";
                dataGridViewCharacterItems.Columns.Add(columnEquipped);

                bindingSourceCharacters.CurrentChanged += bindingSourceCharacters_CurrentChanged;
                bindingSourceCharacterItems.CurrentChanged += bindingSourceCharacterItems_CurrentChanged;

                RefreshCharacterItemsView();
                LoadSelectedCharacterItemToEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingSourceCharacters_CurrentChanged(object sender, EventArgs e)
        {
            RefreshCharacterItemsView();
            LoadSelectedCharacterItemToEditor();
        }

        private void bindingSourceCharacterItems_CurrentChanged(object sender, EventArgs e)
        {
            LoadSelectedCharacterItemToEditor();
        }

        private int? GetCurrentCharacterId()
        {
            if (bindingSourceCharacters.Current == null)
            {
                return null;
            }

            DataRowView currentRow = bindingSourceCharacters.Current as DataRowView;

            if (currentRow == null)
            {
                return null;
            }

            if (currentRow["id"] == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(currentRow["id"]);
        }

        private void RefreshCharacterItemsView()
        {
            if (characterItemsView == null)
            {
                return;
            }

            int? characterId = GetCurrentCharacterId();

            if (characterId == null)
            {
                characterItemsView.RowFilter = "1 = 0";
                return;
            }

            characterItemsView.RowFilter = "character_id = " + characterId.Value;
        }

        private void LoadSelectedCharacterItemToEditor()
        {
            if (bindingSourceCharacterItems.Current == null)
            {
                comboBoxAvailableItems.SelectedIndex = -1;
                numericUpDownItemQuantity.Value = 1;
                checkBoxIsEquipped.Checked = false;
            }
        }

        private bool ValidateCharacter()
        {
            errorProviderCharacters.Clear();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBoxCharacterName.Text))
            {
                errorProviderCharacters.SetError(textBoxCharacterName, "Name is required.");
                isValid = false;
            }

            if (numericUpDownLevel.Value < 1)
            {
                errorProviderCharacters.SetError(numericUpDownLevel, "Level must be at least 1.");
                isValid = false;
            }

            if (numericUpDownCurrentHp.Value > numericUpDownMaxHp.Value)
            {
                errorProviderCharacters.SetError(numericUpDownCurrentHp, "Current HP cannot be greater than Max HP.");
                isValid = false;
            }

            return isValid;
        }

        private bool HasUnsavedChanges()
        {
            bool charactersChanged = charactersTable != null && charactersTable.GetChanges() != null;
            bool characterItemsChanged = characterItemsTable != null && characterItemsTable.GetChanges() != null;

            return charactersChanged || characterItemsChanged;
        }

        private void buttonAddCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCharacters.EndEdit();

                DataRow newRow = charactersTable.NewRow();
                newRow["name"] = "";
                newRow["level"] = 1;
                newRow["alignment"] = "";
                newRow["background"] = "";
                newRow["race_id"] = DBNull.Value;
                newRow["class_id"] = DBNull.Value;
                newRow["strength"] = 10;
                newRow["dexterity"] = 10;
                newRow["constitution"] = 10;
                newRow["intelligence"] = 10;
                newRow["wisdom"] = 10;
                newRow["charisma"] = 10;
                newRow["max_hp"] = 10;
                newRow["current_hp"] = 10;
                newRow["notes"] = "";

                charactersTable.Rows.Add(newRow);
                bindingSourceCharacters.Position = bindingSourceCharacters.Count - 1;

                textBoxCharacterName.Focus();
                RefreshCharacterItemsView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceCharacters.Current == null)
                {
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Delete selected character?",
                    "Confirm delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                int? characterId = GetCurrentCharacterId();

                if (characterId != null)
                {
                    DataRow[] relatedRows = characterItemsTable.Select("character_id = " + characterId.Value);

                    foreach (DataRow row in relatedRows)
                    {
                        row.Delete();
                    }
                }

                bindingSourceCharacters.RemoveCurrent();
                RefreshCharacterItemsView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddItemToCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                int? characterId = GetCurrentCharacterId();

                if (characterId == null)
                {
                    MessageBox.Show("Save the character first before adding items.");
                    return;
                }

                if (comboBoxAvailableItems.SelectedValue == null)
                {
                    MessageBox.Show("Select an item first.");
                    return;
                }

                int itemId = Convert.ToInt32(comboBoxAvailableItems.SelectedValue);

                DataRow[] existingRows = characterItemsTable.Select("character_id = " + characterId.Value + " AND item_id = " + itemId);

                if (existingRows.Length > 0)
                {
                    MessageBox.Show("This item is already assigned to the character.");
                    return;
                }

                DataRow newRow = characterItemsTable.NewRow();
                newRow["character_id"] = characterId.Value;
                newRow["item_id"] = itemId;
                newRow["quantity"] = Convert.ToInt32(numericUpDownItemQuantity.Value);
                newRow["is_equipped"] = checkBoxIsEquipped.Checked ? 1 : 0;

                characterItemsTable.Rows.Add(newRow);
                RefreshCharacterItemsView();

                if (bindingSourceCharacterItems.Count > 0)
                {
                    bindingSourceCharacterItems.Position = bindingSourceCharacterItems.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemoveItemFromCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceCharacterItems.Current == null)
                {
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Remove selected item from character?",
                    "Confirm delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bindingSourceCharacterItems.RemoveCurrent();
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
                if (!ValidateCharacter())
                {
                    return;
                }

                Validate();
                bindingSourceCharacters.EndEdit();
                bindingSourceCharacterItems.EndEdit();

                charactersAdapter.Update(charactersTable);
                characterItemsAdapter.Update(characterItemsTable);

                charactersTable.Clear();
                characterItemsTable.Clear();

                charactersAdapter.Fill(charactersTable);
                characterItemsAdapter.Fill(characterItemsTable);

                RefreshCharacterItemsView();

                MessageBox.Show("Changes saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCharacters_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bindingSourceCharacters.EndEdit();
                bindingSourceCharacterItems.EndEdit();
                if (!HasUnsavedChanges())
                {
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Do you want to save the changes?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (!ValidateCharacter())
                    {
                        e.Cancel = true;
                        return;
                    }

                    Validate();
                    bindingSourceCharacters.EndEdit();
                    bindingSourceCharacterItems.EndEdit();

                    charactersAdapter.Update(charactersTable);
                    characterItemsAdapter.Update(characterItemsTable);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
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
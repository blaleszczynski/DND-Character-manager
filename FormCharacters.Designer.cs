namespace DND_Character_manager
{
    partial class FormCharacters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSourceCharacters = new BindingSource(components);
            labelCharactersTitle = new Label();
            labelCharacterName = new Label();
            labelCharacterLevel = new Label();
            labelCharacterAlignment = new Label();
            labelCharacterBackground = new Label();
            labelCharacterRace = new Label();
            labelCharacterClass = new Label();
            labelCharacterStrength = new Label();
            numericUpDownStrength = new NumericUpDown();
            numericUpDownConstitution = new NumericUpDown();
            labelCharacterConstitution = new Label();
            numericUpDownIntelligence = new NumericUpDown();
            labelCharacterIntelligence = new Label();
            numericUpDownWisdom = new NumericUpDown();
            labelCharacterWisdom = new Label();
            numericUpDownCharisma = new NumericUpDown();
            labelCurrentHp = new Label();
            numericUpDownCurrentHp = new NumericUpDown();
            labelCharacterCharisma = new Label();
            numericUpDownMaxHp = new NumericUpDown();
            labelCharacterMaxHp = new Label();
            numericUpDownDexterity = new NumericUpDown();
            labelCharacterDexterity = new Label();
            numericUpDownLevel = new NumericUpDown();
            comboBoxAlignment = new ComboBox();
            comboBoxClass = new ComboBox();
            comboBoxRace = new ComboBox();
            textBoxCharacterName = new TextBox();
            textBoxBackground = new TextBox();
            textBoxNotes = new TextBox();
            labelCharacterNotes = new Label();
            dataGridViewCharacters = new DataGridView();
            dataGridViewCharacterItems = new DataGridView();
            errorProviderCharacters = new ErrorProvider(components);
            buttonSaveChanges = new Button();
            buttonClose = new Button();
            bindingSourceCharacterItems = new BindingSource(components);
            comboBoxAvailableItems = new ComboBox();
            numericUpDownItemQuantity = new NumericUpDown();
            checkBoxIsEquipped = new CheckBox();
            buttonAddCharacter = new Button();
            buttonDeleteCharacter = new Button();
            buttonAddItemToCharacter = new Button();
            buttonRemoveItemFromCharacter = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConstitution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIntelligence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWisdom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCharisma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentHp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxHp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDexterity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharacterItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCharacterItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownItemQuantity).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceCharacters
            // 
            bindingSourceCharacters.CurrentChanged += bindingSourceCharacters_CurrentChanged;
            // 
            // labelCharactersTitle
            // 
            labelCharactersTitle.AutoSize = true;
            labelCharactersTitle.Location = new Point(329, 9);
            labelCharactersTitle.Name = "labelCharactersTitle";
            labelCharactersTitle.Size = new Size(63, 15);
            labelCharactersTitle.TabIndex = 0;
            labelCharactersTitle.Text = "Characters";
            // 
            // labelCharacterName
            // 
            labelCharacterName.AutoSize = true;
            labelCharacterName.Location = new Point(21, 79);
            labelCharacterName.Name = "labelCharacterName";
            labelCharacterName.Size = new Size(39, 15);
            labelCharacterName.TabIndex = 1;
            labelCharacterName.Text = "Name";
            // 
            // labelCharacterLevel
            // 
            labelCharacterLevel.AutoSize = true;
            labelCharacterLevel.Location = new Point(21, 135);
            labelCharacterLevel.Name = "labelCharacterLevel";
            labelCharacterLevel.Size = new Size(34, 15);
            labelCharacterLevel.TabIndex = 2;
            labelCharacterLevel.Text = "Level";
            // 
            // labelCharacterAlignment
            // 
            labelCharacterAlignment.AutoSize = true;
            labelCharacterAlignment.Location = new Point(17, 191);
            labelCharacterAlignment.Name = "labelCharacterAlignment";
            labelCharacterAlignment.Size = new Size(63, 15);
            labelCharacterAlignment.TabIndex = 3;
            labelCharacterAlignment.Text = "Alignment";
            // 
            // labelCharacterBackground
            // 
            labelCharacterBackground.AutoSize = true;
            labelCharacterBackground.Location = new Point(17, 235);
            labelCharacterBackground.Name = "labelCharacterBackground";
            labelCharacterBackground.Size = new Size(71, 15);
            labelCharacterBackground.TabIndex = 4;
            labelCharacterBackground.Text = "Background";
            // 
            // labelCharacterRace
            // 
            labelCharacterRace.AutoSize = true;
            labelCharacterRace.Location = new Point(17, 283);
            labelCharacterRace.Name = "labelCharacterRace";
            labelCharacterRace.Size = new Size(32, 15);
            labelCharacterRace.TabIndex = 5;
            labelCharacterRace.Text = "Race";
            // 
            // labelCharacterClass
            // 
            labelCharacterClass.AutoSize = true;
            labelCharacterClass.Location = new Point(21, 338);
            labelCharacterClass.Name = "labelCharacterClass";
            labelCharacterClass.Size = new Size(34, 15);
            labelCharacterClass.TabIndex = 6;
            labelCharacterClass.Text = "Class";
            // 
            // labelCharacterStrength
            // 
            labelCharacterStrength.AutoSize = true;
            labelCharacterStrength.Location = new Point(272, 109);
            labelCharacterStrength.Name = "labelCharacterStrength";
            labelCharacterStrength.Size = new Size(52, 15);
            labelCharacterStrength.TabIndex = 14;
            labelCharacterStrength.Text = "Strength";
            // 
            // numericUpDownStrength
            // 
            numericUpDownStrength.Location = new Point(272, 127);
            numericUpDownStrength.Name = "numericUpDownStrength";
            numericUpDownStrength.Size = new Size(120, 23);
            numericUpDownStrength.TabIndex = 15;
            // 
            // numericUpDownConstitution
            // 
            numericUpDownConstitution.Location = new Point(272, 253);
            numericUpDownConstitution.Name = "numericUpDownConstitution";
            numericUpDownConstitution.Size = new Size(120, 23);
            numericUpDownConstitution.TabIndex = 17;
            // 
            // labelCharacterConstitution
            // 
            labelCharacterConstitution.AutoSize = true;
            labelCharacterConstitution.Location = new Point(272, 235);
            labelCharacterConstitution.Name = "labelCharacterConstitution";
            labelCharacterConstitution.Size = new Size(73, 15);
            labelCharacterConstitution.TabIndex = 16;
            labelCharacterConstitution.Text = "Constitution";
            // 
            // numericUpDownIntelligence
            // 
            numericUpDownIntelligence.Location = new Point(272, 330);
            numericUpDownIntelligence.Name = "numericUpDownIntelligence";
            numericUpDownIntelligence.Size = new Size(120, 23);
            numericUpDownIntelligence.TabIndex = 19;
            // 
            // labelCharacterIntelligence
            // 
            labelCharacterIntelligence.AutoSize = true;
            labelCharacterIntelligence.Location = new Point(272, 312);
            labelCharacterIntelligence.Name = "labelCharacterIntelligence";
            labelCharacterIntelligence.Size = new Size(68, 15);
            labelCharacterIntelligence.TabIndex = 18;
            labelCharacterIntelligence.Text = "Intelligence";
            // 
            // numericUpDownWisdom
            // 
            numericUpDownWisdom.Location = new Point(272, 389);
            numericUpDownWisdom.Name = "numericUpDownWisdom";
            numericUpDownWisdom.Size = new Size(120, 23);
            numericUpDownWisdom.TabIndex = 21;
            // 
            // labelCharacterWisdom
            // 
            labelCharacterWisdom.AutoSize = true;
            labelCharacterWisdom.Location = new Point(272, 371);
            labelCharacterWisdom.Name = "labelCharacterWisdom";
            labelCharacterWisdom.Size = new Size(51, 15);
            labelCharacterWisdom.TabIndex = 20;
            labelCharacterWisdom.Text = "Wisdom";
            // 
            // numericUpDownCharisma
            // 
            numericUpDownCharisma.Location = new Point(272, 452);
            numericUpDownCharisma.Name = "numericUpDownCharisma";
            numericUpDownCharisma.Size = new Size(120, 23);
            numericUpDownCharisma.TabIndex = 23;
            // 
            // labelCurrentHp
            // 
            labelCurrentHp.AutoSize = true;
            labelCurrentHp.Location = new Point(436, 109);
            labelCurrentHp.Name = "labelCurrentHp";
            labelCurrentHp.Size = new Size(66, 15);
            labelCurrentHp.TabIndex = 22;
            labelCurrentHp.Text = "Current HP";
            // 
            // numericUpDownCurrentHp
            // 
            numericUpDownCurrentHp.Location = new Point(436, 127);
            numericUpDownCurrentHp.Name = "numericUpDownCurrentHp";
            numericUpDownCurrentHp.Size = new Size(120, 23);
            numericUpDownCurrentHp.TabIndex = 25;
            // 
            // labelCharacterCharisma
            // 
            labelCharacterCharisma.AutoSize = true;
            labelCharacterCharisma.Location = new Point(272, 434);
            labelCharacterCharisma.Name = "labelCharacterCharisma";
            labelCharacterCharisma.Size = new Size(57, 15);
            labelCharacterCharisma.TabIndex = 24;
            labelCharacterCharisma.Text = "Charisma";
            // 
            // numericUpDownMaxHp
            // 
            numericUpDownMaxHp.Location = new Point(436, 188);
            numericUpDownMaxHp.Name = "numericUpDownMaxHp";
            numericUpDownMaxHp.Size = new Size(120, 23);
            numericUpDownMaxHp.TabIndex = 27;
            // 
            // labelCharacterMaxHp
            // 
            labelCharacterMaxHp.AutoSize = true;
            labelCharacterMaxHp.Location = new Point(436, 170);
            labelCharacterMaxHp.Name = "labelCharacterMaxHp";
            labelCharacterMaxHp.Size = new Size(48, 15);
            labelCharacterMaxHp.TabIndex = 26;
            labelCharacterMaxHp.Text = "Max HP";
            // 
            // numericUpDownDexterity
            // 
            numericUpDownDexterity.Location = new Point(272, 189);
            numericUpDownDexterity.Name = "numericUpDownDexterity";
            numericUpDownDexterity.Size = new Size(120, 23);
            numericUpDownDexterity.TabIndex = 29;
            // 
            // labelCharacterDexterity
            // 
            labelCharacterDexterity.AutoSize = true;
            labelCharacterDexterity.Location = new Point(272, 171);
            labelCharacterDexterity.Name = "labelCharacterDexterity";
            labelCharacterDexterity.Size = new Size(53, 15);
            labelCharacterDexterity.TabIndex = 28;
            labelCharacterDexterity.Text = "Dexterity";
            // 
            // numericUpDownLevel
            // 
            numericUpDownLevel.Location = new Point(21, 162);
            numericUpDownLevel.Name = "numericUpDownLevel";
            numericUpDownLevel.Size = new Size(120, 23);
            numericUpDownLevel.TabIndex = 30;
            // 
            // comboBoxAlignment
            // 
            comboBoxAlignment.FormattingEnabled = true;
            comboBoxAlignment.Location = new Point(21, 209);
            comboBoxAlignment.Name = "comboBoxAlignment";
            comboBoxAlignment.Size = new Size(121, 23);
            comboBoxAlignment.TabIndex = 31;
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(20, 356);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(121, 23);
            comboBoxClass.TabIndex = 32;
            // 
            // comboBoxRace
            // 
            comboBoxRace.FormattingEnabled = true;
            comboBoxRace.Location = new Point(21, 304);
            comboBoxRace.Name = "comboBoxRace";
            comboBoxRace.Size = new Size(121, 23);
            comboBoxRace.TabIndex = 33;
            // 
            // textBoxCharacterName
            // 
            textBoxCharacterName.Location = new Point(20, 106);
            textBoxCharacterName.Name = "textBoxCharacterName";
            textBoxCharacterName.Size = new Size(100, 23);
            textBoxCharacterName.TabIndex = 34;
            // 
            // textBoxBackground
            // 
            textBoxBackground.Location = new Point(21, 253);
            textBoxBackground.Name = "textBoxBackground";
            textBoxBackground.Size = new Size(100, 23);
            textBoxBackground.TabIndex = 35;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(20, 452);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(100, 23);
            textBoxNotes.TabIndex = 37;
            // 
            // labelCharacterNotes
            // 
            labelCharacterNotes.AutoSize = true;
            labelCharacterNotes.Location = new Point(21, 425);
            labelCharacterNotes.Name = "labelCharacterNotes";
            labelCharacterNotes.Size = new Size(38, 15);
            labelCharacterNotes.TabIndex = 36;
            labelCharacterNotes.Text = "Notes";
            // 
            // dataGridViewCharacters
            // 
            dataGridViewCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCharacters.Location = new Point(964, 56);
            dataGridViewCharacters.Name = "dataGridViewCharacters";
            dataGridViewCharacters.Size = new Size(483, 150);
            dataGridViewCharacters.TabIndex = 38;
            // 
            // dataGridViewCharacterItems
            // 
            dataGridViewCharacterItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCharacterItems.Location = new Point(964, 283);
            dataGridViewCharacterItems.Name = "dataGridViewCharacterItems";
            dataGridViewCharacterItems.Size = new Size(483, 150);
            dataGridViewCharacterItems.TabIndex = 39;
            // 
            // errorProviderCharacters
            // 
            errorProviderCharacters.ContainerControl = this;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(785, 605);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(144, 23);
            buttonSaveChanges.TabIndex = 40;
            buttonSaveChanges.Text = "Save Changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(959, 605);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 41;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // bindingSourceCharacterItems
            // 
            bindingSourceCharacterItems.CurrentChanged += bindingSourceCharacterItems_CurrentChanged;
            // 
            // comboBoxAvailableItems
            // 
            comboBoxAvailableItems.FormattingEnabled = true;
            comboBoxAvailableItems.Location = new Point(635, 451);
            comboBoxAvailableItems.Name = "comboBoxAvailableItems";
            comboBoxAvailableItems.Size = new Size(121, 23);
            comboBoxAvailableItems.TabIndex = 42;
            // 
            // numericUpDownItemQuantity
            // 
            numericUpDownItemQuantity.Location = new Point(636, 490);
            numericUpDownItemQuantity.Name = "numericUpDownItemQuantity";
            numericUpDownItemQuantity.Size = new Size(120, 23);
            numericUpDownItemQuantity.TabIndex = 43;
            // 
            // checkBoxIsEquipped
            // 
            checkBoxIsEquipped.AutoSize = true;
            checkBoxIsEquipped.Location = new Point(636, 519);
            checkBoxIsEquipped.Name = "checkBoxIsEquipped";
            checkBoxIsEquipped.Size = new Size(81, 19);
            checkBoxIsEquipped.TabIndex = 44;
            checkBoxIsEquipped.Text = "Equipped?";
            checkBoxIsEquipped.UseVisualStyleBackColor = true;
            // 
            // buttonAddCharacter
            // 
            buttonAddCharacter.Location = new Point(811, 56);
            buttonAddCharacter.Name = "buttonAddCharacter";
            buttonAddCharacter.Size = new Size(135, 23);
            buttonAddCharacter.TabIndex = 45;
            buttonAddCharacter.Text = "Add character";
            buttonAddCharacter.UseVisualStyleBackColor = true;
            buttonAddCharacter.Click += buttonAddCharacter_Click;
            // 
            // buttonDeleteCharacter
            // 
            buttonDeleteCharacter.Location = new Point(811, 85);
            buttonDeleteCharacter.Name = "buttonDeleteCharacter";
            buttonDeleteCharacter.Size = new Size(135, 23);
            buttonDeleteCharacter.TabIndex = 46;
            buttonDeleteCharacter.Text = "Delete character";
            buttonDeleteCharacter.UseVisualStyleBackColor = true;
            buttonDeleteCharacter.Click += buttonDeleteCharacter_Click;
            // 
            // buttonAddItemToCharacter
            // 
            buttonAddItemToCharacter.Location = new Point(762, 452);
            buttonAddItemToCharacter.Name = "buttonAddItemToCharacter";
            buttonAddItemToCharacter.Size = new Size(135, 23);
            buttonAddItemToCharacter.TabIndex = 48;
            buttonAddItemToCharacter.Text = "Add Item";
            buttonAddItemToCharacter.UseVisualStyleBackColor = true;
            buttonAddItemToCharacter.Click += buttonAddItemToCharacter_Click;
            // 
            // buttonRemoveItemFromCharacter
            // 
            buttonRemoveItemFromCharacter.Location = new Point(762, 510);
            buttonRemoveItemFromCharacter.Name = "buttonRemoveItemFromCharacter";
            buttonRemoveItemFromCharacter.Size = new Size(135, 23);
            buttonRemoveItemFromCharacter.TabIndex = 49;
            buttonRemoveItemFromCharacter.Text = "Remove Item";
            buttonRemoveItemFromCharacter.UseVisualStyleBackColor = true;
            buttonRemoveItemFromCharacter.Click += buttonRemoveItemFromCharacter_Click;
            // 
            // FormCharacters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 821);
            Controls.Add(buttonRemoveItemFromCharacter);
            Controls.Add(buttonAddItemToCharacter);
            Controls.Add(buttonDeleteCharacter);
            Controls.Add(buttonAddCharacter);
            Controls.Add(checkBoxIsEquipped);
            Controls.Add(numericUpDownItemQuantity);
            Controls.Add(comboBoxAvailableItems);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveChanges);
            Controls.Add(dataGridViewCharacterItems);
            Controls.Add(dataGridViewCharacters);
            Controls.Add(textBoxNotes);
            Controls.Add(labelCharacterNotes);
            Controls.Add(textBoxBackground);
            Controls.Add(textBoxCharacterName);
            Controls.Add(comboBoxRace);
            Controls.Add(comboBoxClass);
            Controls.Add(comboBoxAlignment);
            Controls.Add(numericUpDownLevel);
            Controls.Add(numericUpDownDexterity);
            Controls.Add(labelCharacterDexterity);
            Controls.Add(numericUpDownMaxHp);
            Controls.Add(labelCharacterMaxHp);
            Controls.Add(numericUpDownCurrentHp);
            Controls.Add(labelCharacterCharisma);
            Controls.Add(numericUpDownCharisma);
            Controls.Add(labelCurrentHp);
            Controls.Add(numericUpDownWisdom);
            Controls.Add(labelCharacterWisdom);
            Controls.Add(numericUpDownIntelligence);
            Controls.Add(labelCharacterIntelligence);
            Controls.Add(numericUpDownConstitution);
            Controls.Add(labelCharacterConstitution);
            Controls.Add(numericUpDownStrength);
            Controls.Add(labelCharacterStrength);
            Controls.Add(labelCharacterClass);
            Controls.Add(labelCharacterRace);
            Controls.Add(labelCharacterBackground);
            Controls.Add(labelCharacterAlignment);
            Controls.Add(labelCharacterLevel);
            Controls.Add(labelCharacterName);
            Controls.Add(labelCharactersTitle);
            Name = "FormCharacters";
            Text = "FormCharacters";
            FormClosing += FormCharacters_FormClosing;
            Load += FormCharacters_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConstitution).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIntelligence).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWisdom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCharisma).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentHp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxHp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDexterity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCharacterItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCharacterItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownItemQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSourceCharacters;
        private Label labelCharactersTitle;
        private Label labelCharacterName;
        private Label labelCharacterLevel;
        private Label labelCharacterAlignment;
        private Label labelCharacterBackground;
        private Label labelCharacterRace;
        private Label labelCharacterClass;
        private Label labelCharacterStrength;
        private NumericUpDown numericUpDownStrength;
        private NumericUpDown numericUpDownConstitution;
        private Label labelCharacterConstitution;
        private NumericUpDown numericUpDownIntelligence;
        private Label labelCharacterIntelligence;
        private NumericUpDown numericUpDownWisdom;
        private Label labelCharacterWisdom;
        private NumericUpDown numericUpDownCharisma;
        private Label labelCurrentHp;
        private NumericUpDown numericUpDownCurrentHp;
        private Label labelCharacterCharisma;
        private NumericUpDown numericUpDownMaxHp;
        private Label labelCharacterMaxHp;
        private NumericUpDown numericUpDownDexterity;
        private Label labelCharacterDexterity;
        private NumericUpDown numericUpDownLevel;
        private ComboBox comboBoxAlignment;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxRace;
        private TextBox textBoxCharacterName;
        private TextBox textBoxBackground;
        private TextBox textBoxNotes;
        private Label labelCharacterNotes;
        private DataGridView dataGridViewCharacters;
        private DataGridView dataGridViewCharacterItems;
        private ErrorProvider errorProviderCharacters;
        private Button buttonClose;
        private Button buttonSaveChanges;
        private BindingSource bindingSourceCharacterItems;
        private NumericUpDown numericUpDownItemQuantity;
        private ComboBox comboBoxAvailableItems;
        private CheckBox checkBoxIsEquipped;
        private Button buttonRemoveItemFromCharacter;
        private Button buttonAddItemToCharacter;
        private Button buttonDeleteCharacter;
        private Button buttonAddCharacter;
    }
}
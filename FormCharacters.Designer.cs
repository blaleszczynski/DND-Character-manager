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
            labelCharactersTitle.Font = new Font("Segoe UI", 20F);
            labelCharactersTitle.Location = new Point(559, 38);
            labelCharactersTitle.Margin = new Padding(4, 0, 4, 0);
            labelCharactersTitle.Name = "labelCharactersTitle";
            labelCharactersTitle.Size = new Size(209, 54);
            labelCharactersTitle.TabIndex = 0;
            labelCharactersTitle.Text = "Characters";
            // 
            // labelCharacterName
            // 
            labelCharacterName.AutoSize = true;
            labelCharacterName.Location = new Point(28, 415);
            labelCharacterName.Margin = new Padding(4, 0, 4, 0);
            labelCharacterName.Name = "labelCharacterName";
            labelCharacterName.Size = new Size(59, 25);
            labelCharacterName.TabIndex = 1;
            labelCharacterName.Text = "Name";
            // 
            // labelCharacterLevel
            // 
            labelCharacterLevel.AutoSize = true;
            labelCharacterLevel.Location = new Point(28, 516);
            labelCharacterLevel.Margin = new Padding(4, 0, 4, 0);
            labelCharacterLevel.Name = "labelCharacterLevel";
            labelCharacterLevel.Size = new Size(51, 25);
            labelCharacterLevel.TabIndex = 2;
            labelCharacterLevel.Text = "Level";
            // 
            // labelCharacterAlignment
            // 
            labelCharacterAlignment.AutoSize = true;
            labelCharacterAlignment.Location = new Point(22, 592);
            labelCharacterAlignment.Margin = new Padding(4, 0, 4, 0);
            labelCharacterAlignment.Name = "labelCharacterAlignment";
            labelCharacterAlignment.Size = new Size(94, 25);
            labelCharacterAlignment.TabIndex = 3;
            labelCharacterAlignment.Text = "Alignment";
            // 
            // labelCharacterBackground
            // 
            labelCharacterBackground.AutoSize = true;
            labelCharacterBackground.Location = new Point(22, 679);
            labelCharacterBackground.Margin = new Padding(4, 0, 4, 0);
            labelCharacterBackground.Name = "labelCharacterBackground";
            labelCharacterBackground.Size = new Size(107, 25);
            labelCharacterBackground.TabIndex = 4;
            labelCharacterBackground.Text = "Background";
            // 
            // labelCharacterRace
            // 
            labelCharacterRace.AutoSize = true;
            labelCharacterRace.Location = new Point(22, 759);
            labelCharacterRace.Margin = new Padding(4, 0, 4, 0);
            labelCharacterRace.Name = "labelCharacterRace";
            labelCharacterRace.Size = new Size(49, 25);
            labelCharacterRace.TabIndex = 5;
            labelCharacterRace.Text = "Race";
            // 
            // labelCharacterClass
            // 
            labelCharacterClass.AutoSize = true;
            labelCharacterClass.Location = new Point(23, 827);
            labelCharacterClass.Margin = new Padding(4, 0, 4, 0);
            labelCharacterClass.Name = "labelCharacterClass";
            labelCharacterClass.Size = new Size(52, 25);
            labelCharacterClass.TabIndex = 6;
            labelCharacterClass.Text = "Class";
            // 
            // labelCharacterStrength
            // 
            labelCharacterStrength.AutoSize = true;
            labelCharacterStrength.Location = new Point(235, 415);
            labelCharacterStrength.Margin = new Padding(4, 0, 4, 0);
            labelCharacterStrength.Name = "labelCharacterStrength";
            labelCharacterStrength.Size = new Size(79, 25);
            labelCharacterStrength.TabIndex = 14;
            labelCharacterStrength.Text = "Strength";
            // 
            // numericUpDownStrength
            // 
            numericUpDownStrength.Location = new Point(235, 460);
            numericUpDownStrength.Margin = new Padding(4, 5, 4, 5);
            numericUpDownStrength.Name = "numericUpDownStrength";
            numericUpDownStrength.Size = new Size(171, 31);
            numericUpDownStrength.TabIndex = 15;
            // 
            // numericUpDownConstitution
            // 
            numericUpDownConstitution.Location = new Point(235, 624);
            numericUpDownConstitution.Margin = new Padding(4, 5, 4, 5);
            numericUpDownConstitution.Name = "numericUpDownConstitution";
            numericUpDownConstitution.Size = new Size(171, 31);
            numericUpDownConstitution.TabIndex = 17;
            // 
            // labelCharacterConstitution
            // 
            labelCharacterConstitution.AutoSize = true;
            labelCharacterConstitution.Location = new Point(235, 594);
            labelCharacterConstitution.Margin = new Padding(4, 0, 4, 0);
            labelCharacterConstitution.Name = "labelCharacterConstitution";
            labelCharacterConstitution.Size = new Size(109, 25);
            labelCharacterConstitution.TabIndex = 16;
            labelCharacterConstitution.Text = "Constitution";
            // 
            // numericUpDownIntelligence
            // 
            numericUpDownIntelligence.Location = new Point(235, 710);
            numericUpDownIntelligence.Margin = new Padding(4, 5, 4, 5);
            numericUpDownIntelligence.Name = "numericUpDownIntelligence";
            numericUpDownIntelligence.Size = new Size(171, 31);
            numericUpDownIntelligence.TabIndex = 19;
            // 
            // labelCharacterIntelligence
            // 
            labelCharacterIntelligence.AutoSize = true;
            labelCharacterIntelligence.Location = new Point(235, 680);
            labelCharacterIntelligence.Margin = new Padding(4, 0, 4, 0);
            labelCharacterIntelligence.Name = "labelCharacterIntelligence";
            labelCharacterIntelligence.Size = new Size(101, 25);
            labelCharacterIntelligence.TabIndex = 18;
            labelCharacterIntelligence.Text = "Intelligence";
            // 
            // numericUpDownWisdom
            // 
            numericUpDownWisdom.Location = new Point(235, 789);
            numericUpDownWisdom.Margin = new Padding(4, 5, 4, 5);
            numericUpDownWisdom.Name = "numericUpDownWisdom";
            numericUpDownWisdom.Size = new Size(171, 31);
            numericUpDownWisdom.TabIndex = 21;
            // 
            // labelCharacterWisdom
            // 
            labelCharacterWisdom.AutoSize = true;
            labelCharacterWisdom.Location = new Point(235, 759);
            labelCharacterWisdom.Margin = new Padding(4, 0, 4, 0);
            labelCharacterWisdom.Name = "labelCharacterWisdom";
            labelCharacterWisdom.Size = new Size(79, 25);
            labelCharacterWisdom.TabIndex = 20;
            labelCharacterWisdom.Text = "Wisdom";
            // 
            // numericUpDownCharisma
            // 
            numericUpDownCharisma.Location = new Point(235, 864);
            numericUpDownCharisma.Margin = new Padding(4, 5, 4, 5);
            numericUpDownCharisma.Name = "numericUpDownCharisma";
            numericUpDownCharisma.Size = new Size(171, 31);
            numericUpDownCharisma.TabIndex = 23;
            // 
            // labelCurrentHp
            // 
            labelCurrentHp.AutoSize = true;
            labelCurrentHp.Location = new Point(436, 415);
            labelCurrentHp.Margin = new Padding(4, 0, 4, 0);
            labelCurrentHp.Name = "labelCurrentHp";
            labelCurrentHp.Size = new Size(98, 25);
            labelCurrentHp.TabIndex = 22;
            labelCurrentHp.Text = "Current HP";
            // 
            // numericUpDownCurrentHp
            // 
            numericUpDownCurrentHp.Location = new Point(436, 461);
            numericUpDownCurrentHp.Margin = new Padding(4, 5, 4, 5);
            numericUpDownCurrentHp.Name = "numericUpDownCurrentHp";
            numericUpDownCurrentHp.Size = new Size(171, 31);
            numericUpDownCurrentHp.TabIndex = 25;
            // 
            // labelCharacterCharisma
            // 
            labelCharacterCharisma.AutoSize = true;
            labelCharacterCharisma.Location = new Point(235, 830);
            labelCharacterCharisma.Margin = new Padding(4, 0, 4, 0);
            labelCharacterCharisma.Name = "labelCharacterCharisma";
            labelCharacterCharisma.Size = new Size(85, 25);
            labelCharacterCharisma.TabIndex = 24;
            labelCharacterCharisma.Text = "Charisma";
            // 
            // numericUpDownMaxHp
            // 
            numericUpDownMaxHp.Location = new Point(436, 546);
            numericUpDownMaxHp.Margin = new Padding(4, 5, 4, 5);
            numericUpDownMaxHp.Name = "numericUpDownMaxHp";
            numericUpDownMaxHp.Size = new Size(171, 31);
            numericUpDownMaxHp.TabIndex = 27;
            // 
            // labelCharacterMaxHp
            // 
            labelCharacterMaxHp.AutoSize = true;
            labelCharacterMaxHp.Location = new Point(436, 516);
            labelCharacterMaxHp.Margin = new Padding(4, 0, 4, 0);
            labelCharacterMaxHp.Name = "labelCharacterMaxHp";
            labelCharacterMaxHp.Size = new Size(73, 25);
            labelCharacterMaxHp.TabIndex = 26;
            labelCharacterMaxHp.Text = "Max HP";
            // 
            // numericUpDownDexterity
            // 
            numericUpDownDexterity.Location = new Point(235, 546);
            numericUpDownDexterity.Margin = new Padding(4, 5, 4, 5);
            numericUpDownDexterity.Name = "numericUpDownDexterity";
            numericUpDownDexterity.Size = new Size(171, 31);
            numericUpDownDexterity.TabIndex = 29;
            // 
            // labelCharacterDexterity
            // 
            labelCharacterDexterity.AutoSize = true;
            labelCharacterDexterity.Location = new Point(235, 516);
            labelCharacterDexterity.Margin = new Padding(4, 0, 4, 0);
            labelCharacterDexterity.Name = "labelCharacterDexterity";
            labelCharacterDexterity.Size = new Size(82, 25);
            labelCharacterDexterity.TabIndex = 28;
            labelCharacterDexterity.Text = "Dexterity";
            // 
            // numericUpDownLevel
            // 
            numericUpDownLevel.Location = new Point(28, 546);
            numericUpDownLevel.Margin = new Padding(4, 5, 4, 5);
            numericUpDownLevel.Name = "numericUpDownLevel";
            numericUpDownLevel.Size = new Size(171, 31);
            numericUpDownLevel.TabIndex = 30;
            // 
            // comboBoxAlignment
            // 
            comboBoxAlignment.FormattingEnabled = true;
            comboBoxAlignment.Location = new Point(28, 622);
            comboBoxAlignment.Margin = new Padding(4, 5, 4, 5);
            comboBoxAlignment.Name = "comboBoxAlignment";
            comboBoxAlignment.Size = new Size(171, 33);
            comboBoxAlignment.TabIndex = 31;
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(22, 857);
            comboBoxClass.Margin = new Padding(4, 5, 4, 5);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(177, 33);
            comboBoxClass.TabIndex = 32;
            // 
            // comboBoxRace
            // 
            comboBoxRace.FormattingEnabled = true;
            comboBoxRace.Location = new Point(22, 789);
            comboBoxRace.Margin = new Padding(4, 5, 4, 5);
            comboBoxRace.Name = "comboBoxRace";
            comboBoxRace.Size = new Size(177, 33);
            comboBoxRace.TabIndex = 33;
            // 
            // textBoxCharacterName
            // 
            textBoxCharacterName.Location = new Point(27, 460);
            textBoxCharacterName.Margin = new Padding(4, 5, 4, 5);
            textBoxCharacterName.Name = "textBoxCharacterName";
            textBoxCharacterName.Size = new Size(170, 31);
            textBoxCharacterName.TabIndex = 34;
            textBoxCharacterName.TextChanged += textBoxCharacterName_TextChanged;
            // 
            // textBoxBackground
            // 
            textBoxBackground.Location = new Point(26, 709);
            textBoxBackground.Margin = new Padding(4, 5, 4, 5);
            textBoxBackground.Name = "textBoxBackground";
            textBoxBackground.Size = new Size(173, 31);
            textBoxBackground.TabIndex = 35;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(22, 945);
            textBoxNotes.Margin = new Padding(4, 5, 4, 5);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(177, 31);
            textBoxNotes.TabIndex = 37;
            // 
            // labelCharacterNotes
            // 
            labelCharacterNotes.AutoSize = true;
            labelCharacterNotes.Location = new Point(23, 911);
            labelCharacterNotes.Margin = new Padding(4, 0, 4, 0);
            labelCharacterNotes.Name = "labelCharacterNotes";
            labelCharacterNotes.Size = new Size(59, 25);
            labelCharacterNotes.TabIndex = 36;
            labelCharacterNotes.Text = "Notes";
            // 
            // dataGridViewCharacters
            // 
            dataGridViewCharacters.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCharacters.Location = new Point(13, 110);
            dataGridViewCharacters.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCharacters.Name = "dataGridViewCharacters";
            dataGridViewCharacters.RowHeadersWidth = 62;
            dataGridViewCharacters.Size = new Size(632, 250);
            dataGridViewCharacters.TabIndex = 38;
            // 
            // dataGridViewCharacterItems
            // 
            dataGridViewCharacterItems.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCharacterItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCharacterItems.Location = new Point(670, 110);
            dataGridViewCharacterItems.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCharacterItems.Name = "dataGridViewCharacterItems";
            dataGridViewCharacterItems.RowHeadersWidth = 62;
            dataGridViewCharacterItems.Size = new Size(611, 250);
            dataGridViewCharacterItems.TabIndex = 39;
            // 
            // errorProviderCharacters
            // 
            errorProviderCharacters.ContainerControl = this;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(436, 721);
            buttonSaveChanges.Margin = new Padding(4, 5, 4, 5);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(193, 38);
            buttonSaveChanges.TabIndex = 40;
            buttonSaveChanges.Text = "Save Changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(1370, 1008);
            buttonClose.Margin = new Padding(4, 5, 4, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(107, 38);
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
            comboBoxAvailableItems.Location = new Point(820, 461);
            comboBoxAvailableItems.Margin = new Padding(4, 5, 4, 5);
            comboBoxAvailableItems.Name = "comboBoxAvailableItems";
            comboBoxAvailableItems.Size = new Size(171, 33);
            comboBoxAvailableItems.TabIndex = 42;
            // 
            // numericUpDownItemQuantity
            // 
            numericUpDownItemQuantity.Location = new Point(822, 526);
            numericUpDownItemQuantity.Margin = new Padding(4, 5, 4, 5);
            numericUpDownItemQuantity.Name = "numericUpDownItemQuantity";
            numericUpDownItemQuantity.Size = new Size(171, 31);
            numericUpDownItemQuantity.TabIndex = 43;
            // 
            // checkBoxIsEquipped
            // 
            checkBoxIsEquipped.AutoSize = true;
            checkBoxIsEquipped.Location = new Point(822, 574);
            checkBoxIsEquipped.Margin = new Padding(4, 5, 4, 5);
            checkBoxIsEquipped.Name = "checkBoxIsEquipped";
            checkBoxIsEquipped.Size = new Size(122, 29);
            checkBoxIsEquipped.TabIndex = 44;
            checkBoxIsEquipped.Text = "Equipped?";
            checkBoxIsEquipped.UseVisualStyleBackColor = true;
            // 
            // buttonAddCharacter
            // 
            buttonAddCharacter.Location = new Point(436, 624);
            buttonAddCharacter.Margin = new Padding(4, 5, 4, 5);
            buttonAddCharacter.Name = "buttonAddCharacter";
            buttonAddCharacter.Size = new Size(193, 38);
            buttonAddCharacter.TabIndex = 45;
            buttonAddCharacter.Text = "Add character";
            buttonAddCharacter.UseVisualStyleBackColor = true;
            buttonAddCharacter.Click += buttonAddCharacter_Click;
            // 
            // buttonDeleteCharacter
            // 
            buttonDeleteCharacter.Location = new Point(436, 673);
            buttonDeleteCharacter.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteCharacter.Name = "buttonDeleteCharacter";
            buttonDeleteCharacter.Size = new Size(193, 38);
            buttonDeleteCharacter.TabIndex = 46;
            buttonDeleteCharacter.Text = "Delete character";
            buttonDeleteCharacter.UseVisualStyleBackColor = true;
            buttonDeleteCharacter.Click += buttonDeleteCharacter_Click;
            // 
            // buttonAddItemToCharacter
            // 
            buttonAddItemToCharacter.Location = new Point(1002, 462);
            buttonAddItemToCharacter.Margin = new Padding(4, 5, 4, 5);
            buttonAddItemToCharacter.Name = "buttonAddItemToCharacter";
            buttonAddItemToCharacter.Size = new Size(193, 38);
            buttonAddItemToCharacter.TabIndex = 48;
            buttonAddItemToCharacter.Text = "Add Item";
            buttonAddItemToCharacter.UseVisualStyleBackColor = true;
            buttonAddItemToCharacter.Click += buttonAddItemToCharacter_Click;
            // 
            // buttonRemoveItemFromCharacter
            // 
            buttonRemoveItemFromCharacter.Location = new Point(1002, 559);
            buttonRemoveItemFromCharacter.Margin = new Padding(4, 5, 4, 5);
            buttonRemoveItemFromCharacter.Name = "buttonRemoveItemFromCharacter";
            buttonRemoveItemFromCharacter.Size = new Size(193, 38);
            buttonRemoveItemFromCharacter.TabIndex = 49;
            buttonRemoveItemFromCharacter.Text = "Remove Item";
            buttonRemoveItemFromCharacter.UseVisualStyleBackColor = true;
            buttonRemoveItemFromCharacter.Click += buttonRemoveItemFromCharacter_Click;
            // 
            // FormCharacters
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1924, 1050);
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
            Margin = new Padding(4, 5, 4, 5);
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
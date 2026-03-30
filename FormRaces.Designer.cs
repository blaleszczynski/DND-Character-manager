namespace DND_Character_manager
{
    partial class FormRaces
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
            dataGridViewRaces = new DataGridView();
            bindingSourceRaces = new BindingSource(components);
            errorProviderRaces = new ErrorProvider(components);
            labelRacesTitle = new Label();
            labelAbilityBonusDescription = new Label();
            labelRaceSize = new Label();
            labelRaceSpeed = new Label();
            labelRaceName = new Label();
            textBoxRaceName = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBoxSize = new ComboBox();
            buttonSaveChanges = new Button();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRaces
            // 
            dataGridViewRaces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRaces.Location = new Point(133, 166);
            dataGridViewRaces.Name = "dataGridViewRaces";
            dataGridViewRaces.Size = new Size(240, 150);
            dataGridViewRaces.TabIndex = 0;
            // 
            // errorProviderRaces
            // 
            errorProviderRaces.ContainerControl = this;
            // 
            // labelRacesTitle
            // 
            labelRacesTitle.AutoSize = true;
            labelRacesTitle.Location = new Point(519, 44);
            labelRacesTitle.Name = "labelRacesTitle";
            labelRacesTitle.Size = new Size(37, 15);
            labelRacesTitle.TabIndex = 1;
            labelRacesTitle.Text = "Races";
            // 
            // labelAbilityBonusDescription
            // 
            labelAbilityBonusDescription.AutoSize = true;
            labelAbilityBonusDescription.Location = new Point(856, 411);
            labelAbilityBonusDescription.Name = "labelAbilityBonusDescription";
            labelAbilityBonusDescription.Size = new Size(41, 15);
            labelAbilityBonusDescription.TabIndex = 2;
            labelAbilityBonusDescription.Text = "Ability";
            // 
            // labelRaceSize
            // 
            labelRaceSize.AutoSize = true;
            labelRaceSize.Location = new Point(856, 357);
            labelRaceSize.Name = "labelRaceSize";
            labelRaceSize.Size = new Size(27, 15);
            labelRaceSize.TabIndex = 3;
            labelRaceSize.Text = "Size";
            // 
            // labelRaceSpeed
            // 
            labelRaceSpeed.AutoSize = true;
            labelRaceSpeed.Location = new Point(856, 311);
            labelRaceSpeed.Name = "labelRaceSpeed";
            labelRaceSpeed.Size = new Size(39, 15);
            labelRaceSpeed.TabIndex = 4;
            labelRaceSpeed.Text = "Speed";
            // 
            // labelRaceName
            // 
            labelRaceName.AutoSize = true;
            labelRaceName.Location = new Point(854, 267);
            labelRaceName.Name = "labelRaceName";
            labelRaceName.Size = new Size(39, 15);
            labelRaceName.TabIndex = 5;
            labelRaceName.Text = "Name";
            // 
            // textBoxRaceName
            // 
            textBoxRaceName.Location = new Point(854, 285);
            textBoxRaceName.Name = "textBoxRaceName";
            textBoxRaceName.Size = new Size(100, 23);
            textBoxRaceName.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(854, 331);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // comboBoxSize
            // 
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Location = new Point(853, 375);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(121, 23);
            comboBoxSize.TabIndex = 10;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(481, 436);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(164, 23);
            buttonSaveChanges.TabIndex = 13;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(680, 436);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 14;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormRaces
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 706);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveChanges);
            Controls.Add(comboBoxSize);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxRaceName);
            Controls.Add(labelRaceName);
            Controls.Add(labelRaceSpeed);
            Controls.Add(labelRaceSize);
            Controls.Add(labelAbilityBonusDescription);
            Controls.Add(labelRacesTitle);
            Controls.Add(dataGridViewRaces);
            Name = "FormRaces";
            Text = "FormRaces";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRaces;
        private BindingSource bindingSourceRaces;
        private ErrorProvider errorProviderRaces;
        private Label labelRacesTitle;
        private Label labelRaceName;
        private Label labelRaceSpeed;
        private Label labelRaceSize;
        private Label labelAbilityBonusDescription;
        private NumericUpDown numericUpDown1;
        private TextBox textBoxRaceName;
        private Button buttonClose;
        private Button buttonSaveChanges;
        private ComboBox comboBoxSize;
    }
}
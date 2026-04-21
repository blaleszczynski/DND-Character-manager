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
            numericUpDownRaceSpeed = new NumericUpDown();
            comboBoxRaceSize = new ComboBox();
            buttonSaveChanges = new Button();
            buttonClose = new Button();
            textBoxAbilityBonusDescription = new TextBox();
            buttonAddRace = new Button();
            buttonDeleteRace = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRaceSpeed).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRaces
            // 
            dataGridViewRaces.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewRaces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRaces.Location = new Point(81, 68);
            dataGridViewRaces.Margin = new Padding(4, 5, 4, 5);
            dataGridViewRaces.Name = "dataGridViewRaces";
            dataGridViewRaces.RowHeadersWidth = 62;
            dataGridViewRaces.Size = new Size(1198, 280);
            dataGridViewRaces.TabIndex = 0;
            // 
            // errorProviderRaces
            // 
            errorProviderRaces.ContainerControl = this;
            // 
            // labelRacesTitle
            // 
            labelRacesTitle.AutoSize = true;
            labelRacesTitle.Font = new Font("Segoe UI", 20F);
            labelRacesTitle.Location = new Point(601, 9);
            labelRacesTitle.Margin = new Padding(4, 0, 4, 0);
            labelRacesTitle.Name = "labelRacesTitle";
            labelRacesTitle.Size = new Size(123, 54);
            labelRacesTitle.TabIndex = 1;
            labelRacesTitle.Text = "Races";
            // 
            // labelAbilityBonusDescription
            // 
            labelAbilityBonusDescription.AutoSize = true;
            labelAbilityBonusDescription.Location = new Point(1104, 359);
            labelAbilityBonusDescription.Margin = new Padding(4, 0, 4, 0);
            labelAbilityBonusDescription.Name = "labelAbilityBonusDescription";
            labelAbilityBonusDescription.Size = new Size(62, 25);
            labelAbilityBonusDescription.TabIndex = 2;
            labelAbilityBonusDescription.Text = "Ability";
            // 
            // labelRaceSize
            // 
            labelRaceSize.AutoSize = true;
            labelRaceSize.Location = new Point(754, 369);
            labelRaceSize.Margin = new Padding(4, 0, 4, 0);
            labelRaceSize.Name = "labelRaceSize";
            labelRaceSize.Size = new Size(43, 25);
            labelRaceSize.TabIndex = 3;
            labelRaceSize.Text = "Size";
            // 
            // labelRaceSpeed
            // 
            labelRaceSpeed.AutoSize = true;
            labelRaceSpeed.Location = new Point(390, 370);
            labelRaceSpeed.Margin = new Padding(4, 0, 4, 0);
            labelRaceSpeed.Name = "labelRaceSpeed";
            labelRaceSpeed.Size = new Size(62, 25);
            labelRaceSpeed.TabIndex = 4;
            labelRaceSpeed.Text = "Speed";
            // 
            // labelRaceName
            // 
            labelRaceName.AutoSize = true;
            labelRaceName.Location = new Point(105, 373);
            labelRaceName.Margin = new Padding(4, 0, 4, 0);
            labelRaceName.Name = "labelRaceName";
            labelRaceName.Size = new Size(59, 25);
            labelRaceName.TabIndex = 5;
            labelRaceName.Text = "Name";
            // 
            // textBoxRaceName
            // 
            textBoxRaceName.Location = new Point(105, 403);
            textBoxRaceName.Margin = new Padding(4, 5, 4, 5);
            textBoxRaceName.Name = "textBoxRaceName";
            textBoxRaceName.Size = new Size(141, 31);
            textBoxRaceName.TabIndex = 7;
            // 
            // numericUpDownRaceSpeed
            // 
            numericUpDownRaceSpeed.Location = new Point(387, 404);
            numericUpDownRaceSpeed.Margin = new Padding(4, 5, 4, 5);
            numericUpDownRaceSpeed.Name = "numericUpDownRaceSpeed";
            numericUpDownRaceSpeed.Size = new Size(171, 31);
            numericUpDownRaceSpeed.TabIndex = 9;
            // 
            // comboBoxRaceSize
            // 
            comboBoxRaceSize.FormattingEnabled = true;
            comboBoxRaceSize.Location = new Point(750, 399);
            comboBoxRaceSize.Margin = new Padding(4, 5, 4, 5);
            comboBoxRaceSize.Name = "comboBoxRaceSize";
            comboBoxRaceSize.Size = new Size(171, 33);
            comboBoxRaceSize.TabIndex = 10;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(255, 192, 128);
            buttonSaveChanges.Location = new Point(105, 495);
            buttonSaveChanges.Margin = new Padding(4, 5, 4, 5);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(147, 38);
            buttonSaveChanges.TabIndex = 13;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(255, 128, 128);
            buttonClose.Location = new Point(299, 495);
            buttonClose.Margin = new Padding(4, 5, 4, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(125, 38);
            buttonClose.TabIndex = 14;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxAbilityBonusDescription
            // 
            textBoxAbilityBonusDescription.Location = new Point(1100, 401);
            textBoxAbilityBonusDescription.Margin = new Padding(4, 5, 4, 5);
            textBoxAbilityBonusDescription.Name = "textBoxAbilityBonusDescription";
            textBoxAbilityBonusDescription.Size = new Size(141, 31);
            textBoxAbilityBonusDescription.TabIndex = 15;
            // 
            // buttonAddRace
            // 
            buttonAddRace.BackColor = Color.FromArgb(255, 192, 255);
            buttonAddRace.Location = new Point(105, 560);
            buttonAddRace.Margin = new Padding(4, 5, 4, 5);
            buttonAddRace.Name = "buttonAddRace";
            buttonAddRace.Size = new Size(147, 38);
            buttonAddRace.TabIndex = 16;
            buttonAddRace.Text = "Add Race";
            buttonAddRace.UseVisualStyleBackColor = false;
            buttonAddRace.Click += buttonAddRace_Click;
            // 
            // buttonDeleteRace
            // 
            buttonDeleteRace.BackColor = Color.Red;
            buttonDeleteRace.Location = new Point(299, 560);
            buttonDeleteRace.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteRace.Name = "buttonDeleteRace";
            buttonDeleteRace.Size = new Size(125, 38);
            buttonDeleteRace.TabIndex = 17;
            buttonDeleteRace.Text = "Delete race";
            buttonDeleteRace.UseVisualStyleBackColor = false;
            buttonDeleteRace.Click += buttonDeleteRace_Click;
            // 
            // FormRaces
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(buttonDeleteRace);
            Controls.Add(buttonAddRace);
            Controls.Add(textBoxAbilityBonusDescription);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveChanges);
            Controls.Add(comboBoxRaceSize);
            Controls.Add(numericUpDownRaceSpeed);
            Controls.Add(textBoxRaceName);
            Controls.Add(labelRaceName);
            Controls.Add(labelRaceSpeed);
            Controls.Add(labelRaceSize);
            Controls.Add(labelAbilityBonusDescription);
            Controls.Add(labelRacesTitle);
            Controls.Add(dataGridViewRaces);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRaces";
            Text = "FormRaces";
            FormClosing += FormRaces_FormClosing;
            Load += FormRaces_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRaceSpeed).EndInit();
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
        private NumericUpDown numericUpDownRaceSpeed;
        private TextBox textBoxRaceName;
        private Button buttonClose;
        private Button buttonSaveChanges;
        private ComboBox comboBoxRaceSize;
        private TextBox textBoxAbilityBonusDescription;
        private Button buttonDeleteRace;
        private Button buttonAddRace;
    }
}
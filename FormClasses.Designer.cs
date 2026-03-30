namespace DND_Character_manager
{
    partial class FormClasses
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
            labelClassesTitle = new Label();
            labelClassName = new Label();
            label2 = new Label();
            labelPrimaryAbility = new Label();
            textBoxClassName = new TextBox();
            numericUpDownHitDie = new NumericUpDown();
            comboBoxPrimaryAbility = new ComboBox();
            dataGridViewViewClasses = new DataGridView();
            bindingSourceClasses = new BindingSource(components);
            buttonSaveChanges = new Button();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHitDie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewViewClasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClasses).BeginInit();
            SuspendLayout();
            // 
            // labelClassesTitle
            // 
            labelClassesTitle.AutoSize = true;
            labelClassesTitle.Location = new Point(356, 56);
            labelClassesTitle.Name = "labelClassesTitle";
            labelClassesTitle.Size = new Size(45, 15);
            labelClassesTitle.TabIndex = 0;
            labelClassesTitle.Text = "Classes";
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Location = new Point(659, 213);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new Size(39, 15);
            labelClassName.TabIndex = 1;
            labelClassName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(659, 263);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Hit Die";
            // 
            // labelPrimaryAbility
            // 
            labelPrimaryAbility.AutoSize = true;
            labelPrimaryAbility.Location = new Point(659, 320);
            labelPrimaryAbility.Name = "labelPrimaryAbility";
            labelPrimaryAbility.Size = new Size(83, 15);
            labelPrimaryAbility.TabIndex = 3;
            labelPrimaryAbility.Text = "Primary ability";
            // 
            // textBoxClassName
            // 
            textBoxClassName.Location = new Point(657, 231);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(100, 23);
            textBoxClassName.TabIndex = 4;
            // 
            // numericUpDownHitDie
            // 
            numericUpDownHitDie.Location = new Point(658, 293);
            numericUpDownHitDie.Name = "numericUpDownHitDie";
            numericUpDownHitDie.Size = new Size(120, 23);
            numericUpDownHitDie.TabIndex = 5;
            // 
            // comboBoxPrimaryAbility
            // 
            comboBoxPrimaryAbility.FormattingEnabled = true;
            comboBoxPrimaryAbility.Location = new Point(657, 338);
            comboBoxPrimaryAbility.Name = "comboBoxPrimaryAbility";
            comboBoxPrimaryAbility.Size = new Size(121, 23);
            comboBoxPrimaryAbility.TabIndex = 6;
            // 
            // dataGridViewViewClasses
            // 
            dataGridViewViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewViewClasses.Location = new Point(122, 155);
            dataGridViewViewClasses.Name = "dataGridViewViewClasses";
            dataGridViewViewClasses.Size = new Size(240, 150);
            dataGridViewViewClasses.TabIndex = 7;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(356, 375);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(75, 23);
            buttonSaveChanges.TabIndex = 8;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(451, 375);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 602);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveChanges);
            Controls.Add(dataGridViewViewClasses);
            Controls.Add(comboBoxPrimaryAbility);
            Controls.Add(numericUpDownHitDie);
            Controls.Add(textBoxClassName);
            Controls.Add(labelPrimaryAbility);
            Controls.Add(label2);
            Controls.Add(labelClassName);
            Controls.Add(labelClassesTitle);
            Name = "FormClasses";
            Text = "FormClasses";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHitDie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewViewClasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClassesTitle;
        private Label labelClassName;
        private Label label2;
        private Label labelPrimaryAbility;
        private TextBox textBoxClassName;
        private NumericUpDown numericUpDownHitDie;
        private ComboBox comboBoxPrimaryAbility;
        private DataGridView dataGridViewViewClasses;
        private BindingSource bindingSourceClasses;
        private Button buttonSaveChanges;
        private Button buttonClose;
    }
}
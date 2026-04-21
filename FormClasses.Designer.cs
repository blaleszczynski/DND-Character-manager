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
            dataGridViewClasses = new DataGridView();
            bindingSourceClasses = new BindingSource(components);
            buttonSaveChanges = new Button();
            buttonClose = new Button();
            buttonAddClass = new Button();
            buttonDeleteClass = new Button();
            errorProviderClasses = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownHitDie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderClasses).BeginInit();
            SuspendLayout();
            // 
            // labelClassesTitle
            // 
            labelClassesTitle.AutoSize = true;
            labelClassesTitle.Location = new Point(1259, 586);
            labelClassesTitle.Margin = new Padding(4, 0, 4, 0);
            labelClassesTitle.Name = "labelClassesTitle";
            labelClassesTitle.Size = new Size(69, 25);
            labelClassesTitle.TabIndex = 0;
            labelClassesTitle.Text = "Classes";
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Location = new Point(131, 289);
            labelClassName.Margin = new Padding(4, 0, 4, 0);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new Size(59, 25);
            labelClassName.TabIndex = 1;
            labelClassName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 289);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Hit Die";
            // 
            // labelPrimaryAbility
            // 
            labelPrimaryAbility.AutoSize = true;
            labelPrimaryAbility.Location = new Point(548, 289);
            labelPrimaryAbility.Margin = new Padding(4, 0, 4, 0);
            labelPrimaryAbility.Name = "labelPrimaryAbility";
            labelPrimaryAbility.Size = new Size(124, 25);
            labelPrimaryAbility.TabIndex = 3;
            labelPrimaryAbility.Text = "Primary ability";
            // 
            // textBoxClassName
            // 
            textBoxClassName.Location = new Point(131, 331);
            textBoxClassName.Margin = new Padding(4, 5, 4, 5);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(141, 31);
            textBoxClassName.TabIndex = 4;
            // 
            // numericUpDownHitDie
            // 
            numericUpDownHitDie.Location = new Point(313, 331);
            numericUpDownHitDie.Margin = new Padding(4, 5, 4, 5);
            numericUpDownHitDie.Name = "numericUpDownHitDie";
            numericUpDownHitDie.Size = new Size(171, 31);
            numericUpDownHitDie.TabIndex = 5;
            // 
            // comboBoxPrimaryAbility
            // 
            comboBoxPrimaryAbility.FormattingEnabled = true;
            comboBoxPrimaryAbility.Location = new Point(548, 331);
            comboBoxPrimaryAbility.Margin = new Padding(4, 5, 4, 5);
            comboBoxPrimaryAbility.Name = "comboBoxPrimaryAbility";
            comboBoxPrimaryAbility.Size = new Size(171, 33);
            comboBoxPrimaryAbility.TabIndex = 6;
            // 
            // dataGridViewClasses
            // 
            dataGridViewClasses.BackgroundColor = SystemColors.Control;
            dataGridViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClasses.Location = new Point(76, 14);
            dataGridViewClasses.Margin = new Padding(4, 5, 4, 5);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.RowHeadersWidth = 62;
            dataGridViewClasses.Size = new Size(712, 250);
            dataGridViewClasses.TabIndex = 7;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(255, 192, 128);
            buttonSaveChanges.Location = new Point(246, 446);
            buttonSaveChanges.Margin = new Padding(4, 5, 4, 5);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(107, 38);
            buttonSaveChanges.TabIndex = 8;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(255, 128, 128);
            buttonClose.Location = new Point(391, 446);
            buttonClose.Margin = new Padding(4, 5, 4, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(107, 38);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonAddClass
            // 
            buttonAddClass.BackColor = Color.FromArgb(255, 192, 255);
            buttonAddClass.Location = new Point(246, 501);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(107, 34);
            buttonAddClass.TabIndex = 10;
            buttonAddClass.Text = "Add";
            buttonAddClass.UseVisualStyleBackColor = false;
            buttonAddClass.Click += buttonAddClass_Click;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.BackColor = Color.Red;
            buttonDeleteClass.Location = new Point(391, 501);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(107, 34);
            buttonDeleteClass.TabIndex = 11;
            buttonDeleteClass.Text = "Delete";
            buttonDeleteClass.UseVisualStyleBackColor = false;
            buttonDeleteClass.Click += buttonDeleteClass_Click;
            // 
            // errorProviderClasses
            // 
            errorProviderClasses.ContainerControl = this;
            // 
            // FormClasses
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1464, 1003);
            Controls.Add(buttonDeleteClass);
            Controls.Add(buttonAddClass);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveChanges);
            Controls.Add(dataGridViewClasses);
            Controls.Add(comboBoxPrimaryAbility);
            Controls.Add(numericUpDownHitDie);
            Controls.Add(textBoxClassName);
            Controls.Add(labelPrimaryAbility);
            Controls.Add(label2);
            Controls.Add(labelClassName);
            Controls.Add(labelClassesTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormClasses";
            Text = "FormClasses";
            Load += FormClasses_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHitDie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderClasses).EndInit();
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
        private DataGridView dataGridViewClasses;
        private BindingSource bindingSourceClasses;
        private Button buttonSaveChanges;
        private Button buttonClose;
        private Button buttonAddClass;
        private Button buttonDeleteClass;
        private ErrorProvider errorProviderClasses;
    }
}
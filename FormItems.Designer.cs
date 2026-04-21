namespace DND_Character_manager
{
    partial class FormItems
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
            labelItemsTitle = new Label();
            labelItemName = new Label();
            labelItemType = new Label();
            labelItemDescription = new Label();
            labelItemWeight = new Label();
            textBoxItemName = new TextBox();
            textBoxItemType = new TextBox();
            textBoxItemDescription = new TextBox();
            numericUpDownItemWeight = new NumericUpDown();
            dataGridViewItems = new DataGridView();
            bindingSourceItems = new BindingSource(components);
            errorProviderItems = new ErrorProvider(components);
            buttonSaveChanges = new Button();
            buttonClose = new Button();
            buttonAddItems = new Button();
            buttonDeleteItems = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownItemWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderItems).BeginInit();
            SuspendLayout();
            // 
            // labelItemsTitle
            // 
            labelItemsTitle.AutoSize = true;
            labelItemsTitle.Font = new Font("Segoe UI", 20F);
            labelItemsTitle.Location = new Point(594, 9);
            labelItemsTitle.Margin = new Padding(4, 0, 4, 0);
            labelItemsTitle.Name = "labelItemsTitle";
            labelItemsTitle.Size = new Size(120, 54);
            labelItemsTitle.TabIndex = 0;
            labelItemsTitle.Text = "Items";
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Location = new Point(96, 341);
            labelItemName.Margin = new Padding(4, 0, 4, 0);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(59, 25);
            labelItemName.TabIndex = 1;
            labelItemName.Text = "Name";
            // 
            // labelItemType
            // 
            labelItemType.AutoSize = true;
            labelItemType.Location = new Point(267, 341);
            labelItemType.Margin = new Padding(4, 0, 4, 0);
            labelItemType.Name = "labelItemType";
            labelItemType.Size = new Size(49, 25);
            labelItemType.TabIndex = 2;
            labelItemType.Text = "Type";
            // 
            // labelItemDescription
            // 
            labelItemDescription.AutoSize = true;
            labelItemDescription.Location = new Point(96, 438);
            labelItemDescription.Margin = new Padding(4, 0, 4, 0);
            labelItemDescription.Name = "labelItemDescription";
            labelItemDescription.Size = new Size(102, 25);
            labelItemDescription.TabIndex = 3;
            labelItemDescription.Text = "Description";
            // 
            // labelItemWeight
            // 
            labelItemWeight.AutoSize = true;
            labelItemWeight.Location = new Point(430, 341);
            labelItemWeight.Margin = new Padding(4, 0, 4, 0);
            labelItemWeight.Name = "labelItemWeight";
            labelItemWeight.Size = new Size(68, 25);
            labelItemWeight.TabIndex = 4;
            labelItemWeight.Text = "Weight";
            // 
            // textBoxItemName
            // 
            textBoxItemName.Location = new Point(96, 383);
            textBoxItemName.Margin = new Padding(4, 5, 4, 5);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(141, 31);
            textBoxItemName.TabIndex = 5;
            // 
            // textBoxItemType
            // 
            textBoxItemType.Location = new Point(267, 383);
            textBoxItemType.Margin = new Padding(4, 5, 4, 5);
            textBoxItemType.Name = "textBoxItemType";
            textBoxItemType.Size = new Size(141, 31);
            textBoxItemType.TabIndex = 6;
            // 
            // textBoxItemDescription
            // 
            textBoxItemDescription.Location = new Point(95, 469);
            textBoxItemDescription.Margin = new Padding(4, 5, 4, 5);
            textBoxItemDescription.Multiline = true;
            textBoxItemDescription.Name = "textBoxItemDescription";
            textBoxItemDescription.Size = new Size(505, 134);
            textBoxItemDescription.TabIndex = 7;
            // 
            // numericUpDownItemWeight
            // 
            numericUpDownItemWeight.Location = new Point(430, 383);
            numericUpDownItemWeight.Margin = new Padding(4, 5, 4, 5);
            numericUpDownItemWeight.Name = "numericUpDownItemWeight";
            numericUpDownItemWeight.Size = new Size(171, 31);
            numericUpDownItemWeight.TabIndex = 8;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(75, 86);
            dataGridViewItems.Margin = new Padding(4, 5, 4, 5);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 62;
            dataGridViewItems.Size = new Size(639, 250);
            dataGridViewItems.TabIndex = 9;
            // 
            // errorProviderItems
            // 
            errorProviderItems.ContainerControl = this;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.FromArgb(255, 192, 128);
            buttonSaveChanges.Location = new Point(89, 649);
            buttonSaveChanges.Margin = new Padding(4, 5, 4, 5);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(153, 38);
            buttonSaveChanges.TabIndex = 10;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(255, 128, 128);
            buttonClose.Location = new Point(267, 649);
            buttonClose.Margin = new Padding(4, 5, 4, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(107, 38);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click_1;
            // 
            // buttonAddItems
            // 
            buttonAddItems.BackColor = Color.FromArgb(255, 192, 255);
            buttonAddItems.Location = new Point(89, 695);
            buttonAddItems.Name = "buttonAddItems";
            buttonAddItems.Size = new Size(153, 40);
            buttonAddItems.TabIndex = 12;
            buttonAddItems.Text = "Add";
            buttonAddItems.UseVisualStyleBackColor = false;
            buttonAddItems.Click += buttonAddItems_Click;
            // 
            // buttonDeleteItems
            // 
            buttonDeleteItems.BackColor = Color.Red;
            buttonDeleteItems.Location = new Point(267, 698);
            buttonDeleteItems.Name = "buttonDeleteItems";
            buttonDeleteItems.Size = new Size(107, 37);
            buttonDeleteItems.TabIndex = 13;
            buttonDeleteItems.Text = "Delete";
            buttonDeleteItems.UseVisualStyleBackColor = false;
            buttonDeleteItems.Click += buttonDeleteItems_Click;
            // 
            // FormItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 1050);
            Controls.Add(buttonDeleteItems);
            Controls.Add(buttonAddItems);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveChanges);
            Controls.Add(dataGridViewItems);
            Controls.Add(numericUpDownItemWeight);
            Controls.Add(textBoxItemDescription);
            Controls.Add(textBoxItemType);
            Controls.Add(textBoxItemName);
            Controls.Add(labelItemWeight);
            Controls.Add(labelItemDescription);
            Controls.Add(labelItemType);
            Controls.Add(labelItemName);
            Controls.Add(labelItemsTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormItems";
            Text = "FormItems";
            FormClosing += FormItems_FormClosing_1;
            Load += FormItems_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDownItemWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelItemsTitle;
        private Label labelItemName;
        private Label labelItemType;
        private Label labelItemDescription;
        private Label labelItemWeight;
        private TextBox textBoxItemName;
        private TextBox textBoxItemType;
        private TextBox textBoxItemDescription;
        private NumericUpDown numericUpDownItemWeight;
        private DataGridView dataGridViewItems;
        private BindingSource bindingSourceItems;
        private ErrorProvider errorProviderItems;
        private Button buttonClose;
        private Button buttonSaveChanges;
        private Button buttonDeleteItems;
        private Button buttonAddItems;
    }
}
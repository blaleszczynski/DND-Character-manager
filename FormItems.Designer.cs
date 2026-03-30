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
            ((System.ComponentModel.ISupportInitialize)numericUpDownItemWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderItems).BeginInit();
            SuspendLayout();
            // 
            // labelItemsTitle
            // 
            labelItemsTitle.AutoSize = true;
            labelItemsTitle.Location = new Point(396, 74);
            labelItemsTitle.Name = "labelItemsTitle";
            labelItemsTitle.Size = new Size(36, 15);
            labelItemsTitle.TabIndex = 0;
            labelItemsTitle.Text = "Items";
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Location = new Point(809, 218);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(39, 15);
            labelItemName.TabIndex = 1;
            labelItemName.Text = "Name";
            // 
            // labelItemType
            // 
            labelItemType.AutoSize = true;
            labelItemType.Location = new Point(809, 264);
            labelItemType.Name = "labelItemType";
            labelItemType.Size = new Size(32, 15);
            labelItemType.TabIndex = 2;
            labelItemType.Text = "Type";
            // 
            // labelItemDescription
            // 
            labelItemDescription.AutoSize = true;
            labelItemDescription.Location = new Point(809, 319);
            labelItemDescription.Name = "labelItemDescription";
            labelItemDescription.Size = new Size(67, 15);
            labelItemDescription.TabIndex = 3;
            labelItemDescription.Text = "Description";
            // 
            // labelItemWeight
            // 
            labelItemWeight.AutoSize = true;
            labelItemWeight.Location = new Point(809, 380);
            labelItemWeight.Name = "labelItemWeight";
            labelItemWeight.Size = new Size(45, 15);
            labelItemWeight.TabIndex = 4;
            labelItemWeight.Text = "Weight";
            // 
            // textBoxItemName
            // 
            textBoxItemName.Location = new Point(809, 238);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(100, 23);
            textBoxItemName.TabIndex = 5;
            // 
            // textBoxItemType
            // 
            textBoxItemType.Location = new Point(809, 293);
            textBoxItemType.Name = "textBoxItemType";
            textBoxItemType.Size = new Size(100, 23);
            textBoxItemType.TabIndex = 6;
            // 
            // textBoxItemDescription
            // 
            textBoxItemDescription.Location = new Point(809, 337);
            textBoxItemDescription.Name = "textBoxItemDescription";
            textBoxItemDescription.Size = new Size(100, 23);
            textBoxItemDescription.TabIndex = 7;
            // 
            // numericUpDownItemWeight
            // 
            numericUpDownItemWeight.Location = new Point(809, 398);
            numericUpDownItemWeight.Name = "numericUpDownItemWeight";
            numericUpDownItemWeight.Size = new Size(120, 23);
            numericUpDownItemWeight.TabIndex = 8;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(90, 148);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.Size = new Size(240, 150);
            dataGridViewItems.TabIndex = 9;
            // 
            // errorProviderItems
            // 
            errorProviderItems.ContainerControl = this;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new Point(347, 425);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(107, 23);
            buttonSaveChanges.TabIndex = 10;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(508, 425);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // FormItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 670);
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
            Name = "FormItems";
            Text = "FormItems";
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
    }
}
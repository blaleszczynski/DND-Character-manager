namespace DND_Character_manager
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCharacters = new Button();
            labelTitle = new Label();
            labelSubtitle = new Label();
            buttonExit = new Button();
            buttonItems = new Button();
            buttonClasses = new Button();
            buttonRaces = new Button();
            SuspendLayout();
            // 
            // buttonCharacters
            // 
            buttonCharacters.Location = new Point(523, 187);
            buttonCharacters.Name = "buttonCharacters";
            buttonCharacters.Size = new Size(130, 23);
            buttonCharacters.TabIndex = 0;
            buttonCharacters.Text = "Open Characters";
            buttonCharacters.UseVisualStyleBackColor = true;
            buttonCharacters.Click += buttonCharacters_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(596, 41);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(134, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "DnD Character Manager";
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Location = new Point(523, 562);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(358, 15);
            labelSubtitle.TabIndex = 5;
            labelSubtitle.Text = "Aplikacja do zarządzania danymi postaci w Dungeons and Dragons";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(523, 329);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(130, 23);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonItems
            // 
            buttonItems.Location = new Point(523, 274);
            buttonItems.Name = "buttonItems";
            buttonItems.Size = new Size(130, 23);
            buttonItems.TabIndex = 7;
            buttonItems.Text = "Open Items";
            buttonItems.UseVisualStyleBackColor = true;
            buttonItems.Click += buttonItems_Click;
            // 
            // buttonClasses
            // 
            buttonClasses.Location = new Point(523, 245);
            buttonClasses.Name = "buttonClasses";
            buttonClasses.Size = new Size(130, 23);
            buttonClasses.TabIndex = 8;
            buttonClasses.Text = "Open Classes";
            buttonClasses.UseVisualStyleBackColor = true;
            buttonClasses.Click += buttonClasses_Click;
            // 
            // buttonRaces
            // 
            buttonRaces.Location = new Point(523, 216);
            buttonRaces.Name = "buttonRaces";
            buttonRaces.Size = new Size(130, 23);
            buttonRaces.TabIndex = 9;
            buttonRaces.Text = "Open Races";
            buttonRaces.UseVisualStyleBackColor = true;
            buttonRaces.Click += buttonRaces_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 713);
            Controls.Add(buttonRaces);
            Controls.Add(buttonClasses);
            Controls.Add(buttonItems);
            Controls.Add(buttonExit);
            Controls.Add(labelSubtitle);
            Controls.Add(labelTitle);
            Controls.Add(buttonCharacters);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCharacters;
        private Label labelTitle;
        private Label labelSubtitle;
        private Button buttonExit;
        private Button buttonItems;
        private Button buttonClasses;
        private Button buttonRaces;
    }
}

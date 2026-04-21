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
            buttonCharacters.FlatAppearance.BorderSize = 0;
            buttonCharacters.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            buttonCharacters.FlatStyle = FlatStyle.Flat;
            buttonCharacters.Font = new Font("Segoe UI", 12F);
            buttonCharacters.Location = new Point(747, 312);
            buttonCharacters.Margin = new Padding(4, 5, 4, 5);
            buttonCharacters.Name = "buttonCharacters";
            buttonCharacters.Size = new Size(186, 38);
            buttonCharacters.TabIndex = 0;
            buttonCharacters.Text = "Open Characters";
            buttonCharacters.UseVisualStyleBackColor = true;
            buttonCharacters.Click += buttonCharacters_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.FlatStyle = FlatStyle.System;
            labelTitle.Font = new Font("Segoe UI", 20F);
            labelTitle.Location = new Point(622, 127);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(451, 54);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "DnD Character Manager";
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.FlatStyle = FlatStyle.System;
            labelSubtitle.Font = new Font("Segoe UI", 12F);
            labelSubtitle.Location = new Point(478, 65);
            labelSubtitle.Margin = new Padding(4, 0, 4, 0);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(725, 32);
            labelSubtitle.TabIndex = 5;
            labelSubtitle.Text = "Aplikacja do zarządzania danymi postaci w Dungeons and Dragons";
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.Location = new Point(747, 548);
            buttonExit.Margin = new Padding(4, 5, 4, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(186, 38);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonItems
            // 
            buttonItems.FlatAppearance.BorderSize = 0;
            buttonItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            buttonItems.FlatStyle = FlatStyle.Flat;
            buttonItems.Font = new Font("Segoe UI", 12F);
            buttonItems.Location = new Point(747, 457);
            buttonItems.Margin = new Padding(4, 5, 4, 5);
            buttonItems.Name = "buttonItems";
            buttonItems.Size = new Size(186, 38);
            buttonItems.TabIndex = 7;
            buttonItems.Text = "Open Items";
            buttonItems.UseVisualStyleBackColor = true;
            buttonItems.Click += buttonItems_Click;
            // 
            // buttonClasses
            // 
            buttonClasses.FlatAppearance.BorderSize = 0;
            buttonClasses.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            buttonClasses.FlatStyle = FlatStyle.Flat;
            buttonClasses.Font = new Font("Segoe UI", 12F);
            buttonClasses.Location = new Point(747, 408);
            buttonClasses.Margin = new Padding(4, 5, 4, 5);
            buttonClasses.Name = "buttonClasses";
            buttonClasses.Size = new Size(186, 38);
            buttonClasses.TabIndex = 8;
            buttonClasses.Text = "Open Classes";
            buttonClasses.UseVisualStyleBackColor = true;
            buttonClasses.Click += buttonClasses_Click;
            // 
            // buttonRaces
            // 
            buttonRaces.FlatAppearance.BorderSize = 0;
            buttonRaces.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            buttonRaces.FlatStyle = FlatStyle.Flat;
            buttonRaces.Font = new Font("Segoe UI", 12F);
            buttonRaces.Location = new Point(747, 360);
            buttonRaces.Margin = new Padding(4, 5, 4, 5);
            buttonRaces.Name = "buttonRaces";
            buttonRaces.Size = new Size(186, 38);
            buttonRaces.TabIndex = 9;
            buttonRaces.Text = "Open Races";
            buttonRaces.UseVisualStyleBackColor = true;
            buttonRaces.Click += buttonRaces_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1924, 1050);
            Controls.Add(buttonRaces);
            Controls.Add(buttonClasses);
            Controls.Add(buttonItems);
            Controls.Add(buttonExit);
            Controls.Add(labelSubtitle);
            Controls.Add(labelTitle);
            Controls.Add(buttonCharacters);
            Margin = new Padding(4, 5, 4, 5);
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

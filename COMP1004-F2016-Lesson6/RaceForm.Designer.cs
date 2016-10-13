namespace COMP1004_F2016_Lesson6
{
    partial class RaceForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.RaceListBox = new System.Windows.Forms.ListBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.RaceSelectedLabel = new System.Windows.Forms.Label();
            this.RaceSelectedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(15, 286);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(146, 37);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(190, 286);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(146, 37);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // RaceListBox
            // 
            this.RaceListBox.FormattingEnabled = true;
            this.RaceListBox.ItemHeight = 22;
            this.RaceListBox.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Half-Elf",
            "Half-Ogre",
            "Half-Orc",
            "Halfling",
            "Human",
            "Tiefling"});
            this.RaceListBox.Location = new System.Drawing.Point(29, 50);
            this.RaceListBox.Name = "RaceListBox";
            this.RaceListBox.Size = new System.Drawing.Size(126, 202);
            this.RaceListBox.Sorted = true;
            this.RaceListBox.TabIndex = 16;
            this.RaceListBox.SelectedIndexChanged += new System.EventHandler(this.RaceListBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(25, 13);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(145, 22);
            this.RaceLabel.TabIndex = 17;
            this.RaceLabel.Text = "Pick Your Race";
            // 
            // RaceSelectedLabel
            // 
            this.RaceSelectedLabel.AutoSize = true;
            this.RaceSelectedLabel.Location = new System.Drawing.Point(186, 182);
            this.RaceSelectedLabel.Name = "RaceSelectedLabel";
            this.RaceSelectedLabel.Size = new System.Drawing.Size(134, 22);
            this.RaceSelectedLabel.TabIndex = 18;
            this.RaceSelectedLabel.Text = "Race Selected";
            // 
            // RaceSelectedTextBox
            // 
            this.RaceSelectedTextBox.Location = new System.Drawing.Point(190, 222);
            this.RaceSelectedTextBox.Name = "RaceSelectedTextBox";
            this.RaceSelectedTextBox.Size = new System.Drawing.Size(139, 30);
            this.RaceSelectedTextBox.TabIndex = 19;
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 355);
            this.Controls.Add(this.RaceSelectedTextBox);
            this.Controls.Add(this.RaceSelectedLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RaceListBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaceForm_FormClosing);
            this.Load += new System.EventHandler(this.RaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListBox RaceListBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label RaceSelectedLabel;
        private System.Windows.Forms.TextBox RaceSelectedTextBox;
    }
}
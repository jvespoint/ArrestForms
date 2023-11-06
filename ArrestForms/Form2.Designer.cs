namespace ArrestForms
{
    partial class Form2
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
            this.newCrimeTitleLabel = new System.Windows.Forms.Label();
            this.newCrimeTitle = new System.Windows.Forms.TextBox();
            this.newCrimeDescription = new System.Windows.Forms.TextBox();
            this.newCrimeDescriptionTitle = new System.Windows.Forms.Label();
            this.saveNewCrime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCrimeTitleLabel
            // 
            this.newCrimeTitleLabel.AutoSize = true;
            this.newCrimeTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.newCrimeTitleLabel.Name = "newCrimeTitleLabel";
            this.newCrimeTitleLabel.Size = new System.Drawing.Size(81, 13);
            this.newCrimeTitleLabel.TabIndex = 0;
            this.newCrimeTitleLabel.Text = "New Crime Title";
            // 
            // newCrimeTitle
            // 
            this.newCrimeTitle.AcceptsReturn = true;
            this.newCrimeTitle.AcceptsTab = true;
            this.newCrimeTitle.AllowDrop = true;
            this.newCrimeTitle.Location = new System.Drawing.Point(16, 30);
            this.newCrimeTitle.Multiline = true;
            this.newCrimeTitle.Name = "newCrimeTitle";
            this.newCrimeTitle.Size = new System.Drawing.Size(300, 100);
            this.newCrimeTitle.TabIndex = 1;
            // 
            // newCrimeDescription
            // 
            this.newCrimeDescription.AcceptsReturn = true;
            this.newCrimeDescription.AcceptsTab = true;
            this.newCrimeDescription.AllowDrop = true;
            this.newCrimeDescription.Location = new System.Drawing.Point(16, 153);
            this.newCrimeDescription.Multiline = true;
            this.newCrimeDescription.Name = "newCrimeDescription";
            this.newCrimeDescription.Size = new System.Drawing.Size(300, 200);
            this.newCrimeDescription.TabIndex = 2;
            // 
            // newCrimeDescriptionTitle
            // 
            this.newCrimeDescriptionTitle.AutoSize = true;
            this.newCrimeDescriptionTitle.Location = new System.Drawing.Point(16, 137);
            this.newCrimeDescriptionTitle.Name = "newCrimeDescriptionTitle";
            this.newCrimeDescriptionTitle.Size = new System.Drawing.Size(114, 13);
            this.newCrimeDescriptionTitle.TabIndex = 3;
            this.newCrimeDescriptionTitle.Text = "New Crime Description";
            // 
            // saveNewCrime
            // 
            this.saveNewCrime.Location = new System.Drawing.Point(13, 360);
            this.saveNewCrime.Name = "saveNewCrime";
            this.saveNewCrime.Size = new System.Drawing.Size(75, 23);
            this.saveNewCrime.TabIndex = 4;
            this.saveNewCrime.Text = "Save Crime";
            this.saveNewCrime.UseVisualStyleBackColor = true;
            this.saveNewCrime.Click += new System.EventHandler(this.saveNewCrime_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveNewCrime);
            this.Controls.Add(this.newCrimeDescriptionTitle);
            this.Controls.Add(this.newCrimeDescription);
            this.Controls.Add(this.newCrimeTitle);
            this.Controls.Add(this.newCrimeTitleLabel);
            this.Name = "Form2";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCrimeTitleLabel;
        private System.Windows.Forms.TextBox newCrimeTitle;
        private System.Windows.Forms.TextBox newCrimeDescription;
        private System.Windows.Forms.Label newCrimeDescriptionTitle;
        private System.Windows.Forms.Button saveNewCrime;
    }
}
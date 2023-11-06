namespace ArrestForms
{
    partial class Form1
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
            this.newCrime = new System.Windows.Forms.Button();
            this.crimeSelector = new System.Windows.Forms.ComboBox();
            this.labelCrime = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateOfCrime = new System.Windows.Forms.DateTimePicker();
            this.cateofcrimeLabel = new System.Windows.Forms.Label();
            this.courtdateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.crimeTitle = new System.Windows.Forms.Label();
            this.crimeDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCrime
            // 
            this.newCrime.Location = new System.Drawing.Point(13, 71);
            this.newCrime.Name = "newCrime";
            this.newCrime.Size = new System.Drawing.Size(75, 23);
            this.newCrime.TabIndex = 0;
            this.newCrime.Text = "New";
            this.newCrime.UseVisualStyleBackColor = true;
            this.newCrime.Click += new System.EventHandler(this.newCrime_Click);
            // 
            // crimeSelector
            // 
            this.crimeSelector.FormattingEnabled = true;
            this.crimeSelector.Location = new System.Drawing.Point(13, 44);
            this.crimeSelector.Name = "crimeSelector";
            this.crimeSelector.Size = new System.Drawing.Size(199, 21);
            this.crimeSelector.TabIndex = 1;
            // 
            // labelCrime
            // 
            this.labelCrime.AutoSize = true;
            this.labelCrime.Location = new System.Drawing.Point(13, 25);
            this.labelCrime.Name = "labelCrime";
            this.labelCrime.Size = new System.Drawing.Size(33, 13);
            this.labelCrime.TabIndex = 2;
            this.labelCrime.Text = "Crime";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 114);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(13, 130);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(199, 20);
            this.name.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(13, 158);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(30, 13);
            this.dobLabel.TabIndex = 6;
            this.dobLabel.Text = "DOB";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 201);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(12, 218);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 20);
            this.address.TabIndex = 8;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(12, 245);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(23, 13);
            this.ssnLabel.TabIndex = 9;
            this.ssnLabel.Text = "ssn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dateOfCrime
            // 
            this.dateOfCrime.Location = new System.Drawing.Point(12, 305);
            this.dateOfCrime.Name = "dateOfCrime";
            this.dateOfCrime.Size = new System.Drawing.Size(200, 20);
            this.dateOfCrime.TabIndex = 11;
            // 
            // cateofcrimeLabel
            // 
            this.cateofcrimeLabel.AutoSize = true;
            this.cateofcrimeLabel.Location = new System.Drawing.Point(12, 289);
            this.cateofcrimeLabel.Name = "cateofcrimeLabel";
            this.cateofcrimeLabel.Size = new System.Drawing.Size(71, 13);
            this.cateofcrimeLabel.TabIndex = 12;
            this.cateofcrimeLabel.Text = "Date of Crime";
            // 
            // courtdateLabel
            // 
            this.courtdateLabel.AutoSize = true;
            this.courtdateLabel.Location = new System.Drawing.Point(12, 332);
            this.courtdateLabel.Name = "courtdateLabel";
            this.courtdateLabel.Size = new System.Drawing.Size(58, 13);
            this.courtdateLabel.TabIndex = 13;
            this.courtdateLabel.Text = "Court Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 349);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(113, 376);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(99, 23);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // crimeTitle
            // 
            this.crimeTitle.AutoSize = true;
            this.crimeTitle.Location = new System.Drawing.Point(239, 44);
            this.crimeTitle.Name = "crimeTitle";
            this.crimeTitle.Size = new System.Drawing.Size(88, 13);
            this.crimeTitle.TabIndex = 17;
            this.crimeTitle.Text = "Make a selection";
            // 
            // crimeDescription
            // 
            this.crimeDescription.AutoSize = true;
            this.crimeDescription.Location = new System.Drawing.Point(239, 81);
            this.crimeDescription.Name = "crimeDescription";
            this.crimeDescription.Size = new System.Drawing.Size(88, 13);
            this.crimeDescription.TabIndex = 18;
            this.crimeDescription.Text = "Make a selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crimeDescription);
            this.Controls.Add(this.crimeTitle);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.courtdateLabel);
            this.Controls.Add(this.cateofcrimeLabel);
            this.Controls.Add(this.dateOfCrime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.labelCrime);
            this.Controls.Add(this.crimeSelector);
            this.Controls.Add(this.newCrime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCrime;
        private System.Windows.Forms.ComboBox crimeSelector;
        private System.Windows.Forms.Label labelCrime;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateOfCrime;
        private System.Windows.Forms.Label cateofcrimeLabel;
        private System.Windows.Forms.Label courtdateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label crimeTitle;
        private System.Windows.Forms.Label crimeDescription;
    }
}


namespace RestaurantDB.Presenetation
{
    partial class EmployeeEdit
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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmployeeEditTitle = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BirthYearLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(210, 51);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 16;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 54);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "New name:";
            // 
            // EmployeeEditTitle
            // 
            this.EmployeeEditTitle.AutoSize = true;
            this.EmployeeEditTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeEditTitle.Location = new System.Drawing.Point(12, 9);
            this.EmployeeEditTitle.Name = "EmployeeEditTitle";
            this.EmployeeEditTitle.Size = new System.Drawing.Size(146, 26);
            this.EmployeeEditTitle.TabIndex = 14;
            this.EmployeeEditTitle.Text = "EMPLOYEE EDIT";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(141, 226);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(235, 226);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 24;
            // 
            // BirthYearLabel
            // 
            this.BirthYearLabel.AutoSize = true;
            this.BirthYearLabel.Location = new System.Drawing.Point(17, 179);
            this.BirthYearLabel.Name = "BirthYearLabel";
            this.BirthYearLabel.Size = new System.Drawing.Size(67, 13);
            this.BirthYearLabel.TabIndex = 23;
            this.BirthYearLabel.Text = "Year of birth:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lead Chef",
            "Assistant Chef",
            "Waiter"});
            this.comboBox1.Location = new System.Drawing.Point(189, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(17, 132);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(35, 13);
            this.RoleLabel.TabIndex = 21;
            this.RoleLabel.Text = "Role: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 20;
            // 
            // IdNumberLabel
            // 
            this.IdNumberLabel.AutoSize = true;
            this.IdNumberLabel.Location = new System.Drawing.Point(17, 92);
            this.IdNumberLabel.Name = "IdNumberLabel";
            this.IdNumberLabel.Size = new System.Drawing.Size(100, 13);
            this.IdNumberLabel.TabIndex = 19;
            this.IdNumberLabel.Text = "Personal id number:";
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BirthYearLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmployeeEditTitle);
            this.Name = "EmployeeEdit";
            this.Text = "EmployeeEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmployeeEditTitle;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label BirthYearLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label IdNumberLabel;
    }
}
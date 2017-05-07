﻿namespace RestaurantDB.Presenetation
{
    partial class EmployeeCreation
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
            this.EmployeeCreationTitle = new System.Windows.Forms.Label();
            this.EmplyoeeNameInput = new System.Windows.Forms.TextBox();
            this.NameAdding = new System.Windows.Forms.Label();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BirthYearLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeCreationTitle
            // 
            this.EmployeeCreationTitle.AutoSize = true;
            this.EmployeeCreationTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeCreationTitle.Location = new System.Drawing.Point(12, 9);
            this.EmployeeCreationTitle.Name = "EmployeeCreationTitle";
            this.EmployeeCreationTitle.Size = new System.Drawing.Size(193, 26);
            this.EmployeeCreationTitle.TabIndex = 1;
            this.EmployeeCreationTitle.Text = "EMPLOYEE CREATION";
            // 
            // EmplyoeeNameInput
            // 
            this.EmplyoeeNameInput.Location = new System.Drawing.Point(132, 54);
            this.EmplyoeeNameInput.Name = "EmplyoeeNameInput";
            this.EmplyoeeNameInput.Size = new System.Drawing.Size(175, 20);
            this.EmplyoeeNameInput.TabIndex = 12;
            // 
            // NameAdding
            // 
            this.NameAdding.AutoSize = true;
            this.NameAdding.Location = new System.Drawing.Point(14, 57);
            this.NameAdding.Name = "NameAdding";
            this.NameAdding.Size = new System.Drawing.Size(38, 13);
            this.NameAdding.TabIndex = 11;
            this.NameAdding.Text = "Name:";
            // 
            // IdNumberLabel
            // 
            this.IdNumberLabel.AutoSize = true;
            this.IdNumberLabel.Location = new System.Drawing.Point(14, 101);
            this.IdNumberLabel.Name = "IdNumberLabel";
            this.IdNumberLabel.Size = new System.Drawing.Size(100, 13);
            this.IdNumberLabel.TabIndex = 13;
            this.IdNumberLabel.Text = "Personal id number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 14;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(14, 149);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(35, 13);
            this.RoleLabel.TabIndex = 15;
            this.RoleLabel.Text = "Role: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lead Chef",
            "Assistant Chef",
            "Waiter"});
            this.comboBox1.Location = new System.Drawing.Point(186, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // BirthYearLabel
            // 
            this.BirthYearLabel.AutoSize = true;
            this.BirthYearLabel.Location = new System.Drawing.Point(14, 196);
            this.BirthYearLabel.Name = "BirthYearLabel";
            this.BirthYearLabel.Size = new System.Drawing.Size(67, 13);
            this.BirthYearLabel.TabIndex = 17;
            this.BirthYearLabel.Text = "Year of birth:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 18;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(232, 236);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(130, 236);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EmployeeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 271);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BirthYearLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.EmplyoeeNameInput);
            this.Controls.Add(this.NameAdding);
            this.Controls.Add(this.EmployeeCreationTitle);
            this.Name = "EmployeeCreation";
            this.Text = "EmployeeCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeCreationTitle;
        private System.Windows.Forms.TextBox EmplyoeeNameInput;
        private System.Windows.Forms.Label NameAdding;
        private System.Windows.Forms.Label IdNumberLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BirthYearLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
    }
}
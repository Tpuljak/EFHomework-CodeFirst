namespace RestaurantDB.Presenetation
{
    partial class RestaurantEdit
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
            this.RestaurantEditTitle = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.KitchenModelLabel = new System.Windows.Forms.Label();
            this.KitchenModelComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeesLabel = new System.Windows.Forms.Label();
            this.RecipesLabel = new System.Windows.Forms.Label();
            this.RecipesComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.RestaurantNameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestaurantEditTitle
            // 
            this.RestaurantEditTitle.AutoSize = true;
            this.RestaurantEditTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantEditTitle.Location = new System.Drawing.Point(12, 9);
            this.RestaurantEditTitle.Name = "RestaurantEditTitle";
            this.RestaurantEditTitle.Size = new System.Drawing.Size(166, 26);
            this.RestaurantEditTitle.TabIndex = 2;
            this.RestaurantEditTitle.Text = "RESTAURANT EDIT";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(102, 244);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(196, 244);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // KitchenModelLabel
            // 
            this.KitchenModelLabel.AutoSize = true;
            this.KitchenModelLabel.Location = new System.Drawing.Point(14, 196);
            this.KitchenModelLabel.Name = "KitchenModelLabel";
            this.KitchenModelLabel.Size = new System.Drawing.Size(77, 13);
            this.KitchenModelLabel.TabIndex = 24;
            this.KitchenModelLabel.Text = "Kitchen model:";
            // 
            // KitchenModelComboBox
            // 
            this.KitchenModelComboBox.FormattingEnabled = true;
            this.KitchenModelComboBox.Location = new System.Drawing.Point(150, 193);
            this.KitchenModelComboBox.Name = "KitchenModelComboBox";
            this.KitchenModelComboBox.Size = new System.Drawing.Size(121, 21);
            this.KitchenModelComboBox.TabIndex = 23;
            // 
            // EmployeesLabel
            // 
            this.EmployeesLabel.AutoSize = true;
            this.EmployeesLabel.Location = new System.Drawing.Point(14, 96);
            this.EmployeesLabel.Name = "EmployeesLabel";
            this.EmployeesLabel.Size = new System.Drawing.Size(61, 13);
            this.EmployeesLabel.TabIndex = 22;
            this.EmployeesLabel.Text = "Employees:";
            // 
            // RecipesLabel
            // 
            this.RecipesLabel.AutoSize = true;
            this.RecipesLabel.Location = new System.Drawing.Point(14, 147);
            this.RecipesLabel.Name = "RecipesLabel";
            this.RecipesLabel.Size = new System.Drawing.Size(49, 13);
            this.RecipesLabel.TabIndex = 21;
            this.RecipesLabel.Text = "Recipes:";
            // 
            // RecipesComboBox
            // 
            this.RecipesComboBox.FormattingEnabled = true;
            this.RecipesComboBox.Location = new System.Drawing.Point(150, 144);
            this.RecipesComboBox.Name = "RecipesComboBox";
            this.RecipesComboBox.Size = new System.Drawing.Size(121, 21);
            this.RecipesComboBox.TabIndex = 20;
            // 
            // EmployeesComboBox
            // 
            this.EmployeesComboBox.FormattingEnabled = true;
            this.EmployeesComboBox.Location = new System.Drawing.Point(150, 93);
            this.EmployeesComboBox.Name = "EmployeesComboBox";
            this.EmployeesComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeesComboBox.TabIndex = 19;
            // 
            // RestaurantNameInput
            // 
            this.RestaurantNameInput.Location = new System.Drawing.Point(96, 46);
            this.RestaurantNameInput.Name = "RestaurantNameInput";
            this.RestaurantNameInput.Size = new System.Drawing.Size(175, 20);
            this.RestaurantNameInput.TabIndex = 18;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(14, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "New name:";
            // 
            // RestaurantEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 279);
            this.Controls.Add(this.KitchenModelLabel);
            this.Controls.Add(this.KitchenModelComboBox);
            this.Controls.Add(this.EmployeesLabel);
            this.Controls.Add(this.RecipesLabel);
            this.Controls.Add(this.RecipesComboBox);
            this.Controls.Add(this.EmployeesComboBox);
            this.Controls.Add(this.RestaurantNameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RestaurantEditTitle);
            this.Name = "RestaurantEdit";
            this.Text = "RestaurantEdit";
            this.Load += new System.EventHandler(this.RestaurantEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantEditTitle;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label KitchenModelLabel;
        private System.Windows.Forms.ComboBox KitchenModelComboBox;
        private System.Windows.Forms.Label EmployeesLabel;
        private System.Windows.Forms.Label RecipesLabel;
        private System.Windows.Forms.ComboBox RecipesComboBox;
        private System.Windows.Forms.ComboBox EmployeesComboBox;
        private System.Windows.Forms.TextBox RestaurantNameInput;
        private System.Windows.Forms.Label NameLabel;
    }
}
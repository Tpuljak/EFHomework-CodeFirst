namespace RestaurantDB.Presenetation
{
    partial class RestaurantCreation
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
            this.RestaurantCreationTitle = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RestaurantNameInput = new System.Windows.Forms.TextBox();
            this.NameAdding = new System.Windows.Forms.Label();
            this.EmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.RecipesComboBox = new System.Windows.Forms.ComboBox();
            this.RecipesLabel = new System.Windows.Forms.Label();
            this.EmployeesLabel = new System.Windows.Forms.Label();
            this.KitchenModelComboBox = new System.Windows.Forms.ComboBox();
            this.KitchenModelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestaurantCreationTitle
            // 
            this.RestaurantCreationTitle.AutoSize = true;
            this.RestaurantCreationTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantCreationTitle.Location = new System.Drawing.Point(12, 9);
            this.RestaurantCreationTitle.Name = "RestaurantCreationTitle";
            this.RestaurantCreationTitle.Size = new System.Drawing.Size(213, 26);
            this.RestaurantCreationTitle.TabIndex = 1;
            this.RestaurantCreationTitle.Text = "RESTAURANT CREATION";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(196, 266);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(94, 266);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RestaurantNameInput
            // 
            this.RestaurantNameInput.Location = new System.Drawing.Point(96, 50);
            this.RestaurantNameInput.Name = "RestaurantNameInput";
            this.RestaurantNameInput.Size = new System.Drawing.Size(175, 20);
            this.RestaurantNameInput.TabIndex = 10;
            // 
            // NameAdding
            // 
            this.NameAdding.AutoSize = true;
            this.NameAdding.Location = new System.Drawing.Point(14, 53);
            this.NameAdding.Name = "NameAdding";
            this.NameAdding.Size = new System.Drawing.Size(38, 13);
            this.NameAdding.TabIndex = 9;
            this.NameAdding.Text = "Name:";
            // 
            // EmployeesComboBox
            // 
            this.EmployeesComboBox.FormattingEnabled = true;
            this.EmployeesComboBox.Location = new System.Drawing.Point(150, 97);
            this.EmployeesComboBox.Name = "EmployeesComboBox";
            this.EmployeesComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeesComboBox.TabIndex = 11;
            // 
            // RecipesComboBox
            // 
            this.RecipesComboBox.FormattingEnabled = true;
            this.RecipesComboBox.Location = new System.Drawing.Point(150, 148);
            this.RecipesComboBox.Name = "RecipesComboBox";
            this.RecipesComboBox.Size = new System.Drawing.Size(121, 21);
            this.RecipesComboBox.TabIndex = 12;
            // 
            // RecipesLabel
            // 
            this.RecipesLabel.AutoSize = true;
            this.RecipesLabel.Location = new System.Drawing.Point(14, 151);
            this.RecipesLabel.Name = "RecipesLabel";
            this.RecipesLabel.Size = new System.Drawing.Size(49, 13);
            this.RecipesLabel.TabIndex = 13;
            this.RecipesLabel.Text = "Recipes:";
            // 
            // EmployeesLabel
            // 
            this.EmployeesLabel.AutoSize = true;
            this.EmployeesLabel.Location = new System.Drawing.Point(14, 100);
            this.EmployeesLabel.Name = "EmployeesLabel";
            this.EmployeesLabel.Size = new System.Drawing.Size(61, 13);
            this.EmployeesLabel.TabIndex = 14;
            this.EmployeesLabel.Text = "Employees:";
            // 
            // KitchenModelComboBox
            // 
            this.KitchenModelComboBox.FormattingEnabled = true;
            this.KitchenModelComboBox.Location = new System.Drawing.Point(150, 197);
            this.KitchenModelComboBox.Name = "KitchenModelComboBox";
            this.KitchenModelComboBox.Size = new System.Drawing.Size(121, 21);
            this.KitchenModelComboBox.TabIndex = 15;
            // 
            // KitchenModelLabel
            // 
            this.KitchenModelLabel.AutoSize = true;
            this.KitchenModelLabel.Location = new System.Drawing.Point(14, 200);
            this.KitchenModelLabel.Name = "KitchenModelLabel";
            this.KitchenModelLabel.Size = new System.Drawing.Size(77, 13);
            this.KitchenModelLabel.TabIndex = 16;
            this.KitchenModelLabel.Text = "Kitchen model:";
            this.KitchenModelLabel.Click += new System.EventHandler(this.KitchenModelLabel_Click);
            // 
            // RestaurantCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 301);
            this.Controls.Add(this.KitchenModelLabel);
            this.Controls.Add(this.KitchenModelComboBox);
            this.Controls.Add(this.EmployeesLabel);
            this.Controls.Add(this.RecipesLabel);
            this.Controls.Add(this.RecipesComboBox);
            this.Controls.Add(this.EmployeesComboBox);
            this.Controls.Add(this.RestaurantNameInput);
            this.Controls.Add(this.NameAdding);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RestaurantCreationTitle);
            this.Name = "RestaurantCreation";
            this.Text = "RestaurantCreation";
            this.Load += new System.EventHandler(this.RestaurantCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantCreationTitle;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox RestaurantNameInput;
        private System.Windows.Forms.Label NameAdding;
        private System.Windows.Forms.ComboBox EmployeesComboBox;
        private System.Windows.Forms.ComboBox RecipesComboBox;
        private System.Windows.Forms.Label RecipesLabel;
        private System.Windows.Forms.Label EmployeesLabel;
        private System.Windows.Forms.ComboBox KitchenModelComboBox;
        private System.Windows.Forms.Label KitchenModelLabel;
    }
}
namespace RestaurantDB.Presenetation
{
    partial class RecipeCreation
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
            this.RecipeCreationTitle = new System.Windows.Forms.Label();
            this.NameAdding = new System.Windows.Forms.Label();
            this.AddingIngredients = new System.Windows.Forms.Label();
            this.RecipeName = new System.Windows.Forms.TextBox();
            this.IngredientsComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecipeCreationTitle
            // 
            this.RecipeCreationTitle.AutoSize = true;
            this.RecipeCreationTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeCreationTitle.Location = new System.Drawing.Point(22, 9);
            this.RecipeCreationTitle.Name = "RecipeCreationTitle";
            this.RecipeCreationTitle.Size = new System.Drawing.Size(160, 26);
            this.RecipeCreationTitle.TabIndex = 0;
            this.RecipeCreationTitle.Text = "RECIPE CREATION";
            this.RecipeCreationTitle.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameAdding
            // 
            this.NameAdding.AutoSize = true;
            this.NameAdding.Location = new System.Drawing.Point(27, 58);
            this.NameAdding.Name = "NameAdding";
            this.NameAdding.Size = new System.Drawing.Size(38, 13);
            this.NameAdding.TabIndex = 1;
            this.NameAdding.Text = "Name:";
            // 
            // AddingIngredients
            // 
            this.AddingIngredients.AutoSize = true;
            this.AddingIngredients.Location = new System.Drawing.Point(30, 93);
            this.AddingIngredients.Name = "AddingIngredients";
            this.AddingIngredients.Size = new System.Drawing.Size(95, 13);
            this.AddingIngredients.TabIndex = 2;
            this.AddingIngredients.Text = "Ingredients to add:";
            // 
            // RecipeName
            // 
            this.RecipeName.Location = new System.Drawing.Point(82, 55);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(202, 20);
            this.RecipeName.TabIndex = 3;
            this.RecipeName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IngredientsComboBox
            // 
            this.IngredientsComboBox.FormattingEnabled = true;
            this.IngredientsComboBox.Location = new System.Drawing.Point(132, 93);
            this.IngredientsComboBox.Name = "IngredientsComboBox";
            this.IngredientsComboBox.Size = new System.Drawing.Size(152, 21);
            this.IngredientsComboBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(50, 148);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(168, 148);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RecipeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 193);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.IngredientsComboBox);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.AddingIngredients);
            this.Controls.Add(this.NameAdding);
            this.Controls.Add(this.RecipeCreationTitle);
            this.Name = "RecipeCreation";
            this.Text = "RecipeCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecipeCreationTitle;
        private System.Windows.Forms.Label NameAdding;
        private System.Windows.Forms.Label AddingIngredients;
        private System.Windows.Forms.TextBox RecipeName;
        private System.Windows.Forms.ComboBox IngredientsComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
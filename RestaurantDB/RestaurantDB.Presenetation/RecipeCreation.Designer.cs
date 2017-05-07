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
            this.RecipeNameInput = new System.Windows.Forms.TextBox();
            this.IngredientsComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TimeToMakeLabel = new System.Windows.Forms.Label();
            this.TimeToMakeInput = new System.Windows.Forms.TextBox();
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
            this.AddingIngredients.Location = new System.Drawing.Point(27, 137);
            this.AddingIngredients.Name = "AddingIngredients";
            this.AddingIngredients.Size = new System.Drawing.Size(95, 13);
            this.AddingIngredients.TabIndex = 2;
            this.AddingIngredients.Text = "Ingredients to add:";
            // 
            // RecipeNameInput
            // 
            this.RecipeNameInput.Location = new System.Drawing.Point(82, 55);
            this.RecipeNameInput.Name = "RecipeNameInput";
            this.RecipeNameInput.Size = new System.Drawing.Size(202, 20);
            this.RecipeNameInput.TabIndex = 3;
            this.RecipeNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IngredientsComboBox
            // 
            this.IngredientsComboBox.FormattingEnabled = true;
            this.IngredientsComboBox.Location = new System.Drawing.Point(132, 134);
            this.IngredientsComboBox.Name = "IngredientsComboBox";
            this.IngredientsComboBox.Size = new System.Drawing.Size(152, 21);
            this.IngredientsComboBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(107, 187);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(209, 187);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TimeToMakeLabel
            // 
            this.TimeToMakeLabel.AutoSize = true;
            this.TimeToMakeLabel.Location = new System.Drawing.Point(27, 96);
            this.TimeToMakeLabel.Name = "TimeToMakeLabel";
            this.TimeToMakeLabel.Size = new System.Drawing.Size(123, 13);
            this.TimeToMakeLabel.TabIndex = 17;
            this.TimeToMakeLabel.Text = "Time to make (seconds):";
            // 
            // TimeToMakeInput
            // 
            this.TimeToMakeInput.Location = new System.Drawing.Point(184, 93);
            this.TimeToMakeInput.Name = "TimeToMakeInput";
            this.TimeToMakeInput.Size = new System.Drawing.Size(100, 20);
            this.TimeToMakeInput.TabIndex = 16;
            // 
            // RecipeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 222);
            this.Controls.Add(this.TimeToMakeLabel);
            this.Controls.Add(this.TimeToMakeInput);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.IngredientsComboBox);
            this.Controls.Add(this.RecipeNameInput);
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
        private System.Windows.Forms.TextBox RecipeNameInput;
        private System.Windows.Forms.ComboBox IngredientsComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TimeToMakeLabel;
        private System.Windows.Forms.TextBox TimeToMakeInput;
    }
}
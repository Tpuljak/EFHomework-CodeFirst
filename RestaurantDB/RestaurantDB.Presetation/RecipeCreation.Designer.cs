namespace RestaurantDB.Presentation
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
            this.components = new System.ComponentModel.Container();
            this.RecipeCreationTitle = new System.Windows.Forms.Label();
            this.NameAdding = new System.Windows.Forms.Label();
            this.AddingIngredients = new System.Windows.Forms.Label();
            this.RecipeNameInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TimeToMakeLabel = new System.Windows.Forms.Label();
            this.TimeToMakeInput = new System.Windows.Forms.TextBox();
            this.IngredientsListBox = new System.Windows.Forms.ListBox();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDbDataSet = new RestaurantDB.Presetation.RestaurantDbDataSet();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.ingredientsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.IngredientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).BeginInit();
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
            this.AddingIngredients.Size = new System.Drawing.Size(62, 13);
            this.AddingIngredients.TabIndex = 2;
            this.AddingIngredients.Text = "Ingredients:";
            // 
            // RecipeNameInput
            // 
            this.RecipeNameInput.Location = new System.Drawing.Point(82, 55);
            this.RecipeNameInput.Name = "RecipeNameInput";
            this.RecipeNameInput.Size = new System.Drawing.Size(202, 20);
            this.RecipeNameInput.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(107, 260);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(209, 260);
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
            this.TimeToMakeLabel.Size = new System.Drawing.Size(119, 13);
            this.TimeToMakeLabel.TabIndex = 17;
            this.TimeToMakeLabel.Text = "Time to make (minutes):";
            // 
            // TimeToMakeInput
            // 
            this.TimeToMakeInput.Location = new System.Drawing.Point(184, 93);
            this.TimeToMakeInput.Name = "TimeToMakeInput";
            this.TimeToMakeInput.Size = new System.Drawing.Size(100, 20);
            this.TimeToMakeInput.TabIndex = 16;
            // 
            // IngredientsListBox
            // 
            this.IngredientsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ingredientsBindingSource, "Name", true));
            this.IngredientsListBox.DataSource = this.ingredientsBindingSource;
            this.IngredientsListBox.DisplayMember = "Name";
            this.IngredientsListBox.FormattingEnabled = true;
            this.IngredientsListBox.Location = new System.Drawing.Point(164, 137);
            this.IngredientsListBox.Name = "IngredientsListBox";
            this.IngredientsListBox.Size = new System.Drawing.Size(120, 95);
            this.IngredientsListBox.TabIndex = 18;
            this.IngredientsListBox.ValueMember = "Name";
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // restaurantDbDataSet
            // 
            this.restaurantDbDataSet.DataSetName = "RestaurantDbDataSet";
            this.restaurantDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(30, 168);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(107, 23);
            this.AddIngredientButton.TabIndex = 19;
            this.AddIngredientButton.Text = "Add ingredient";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // RecipeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 295);
            this.Controls.Add(this.AddIngredientButton);
            this.Controls.Add(this.IngredientsListBox);
            this.Controls.Add(this.TimeToMakeLabel);
            this.Controls.Add(this.TimeToMakeInput);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RecipeNameInput);
            this.Controls.Add(this.AddingIngredients);
            this.Controls.Add(this.NameAdding);
            this.Controls.Add(this.RecipeCreationTitle);
            this.Name = "RecipeCreation";
            this.Text = "RecipeCreation";
            this.Load += new System.EventHandler(this.RecipeCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecipeCreationTitle;
        private System.Windows.Forms.Label NameAdding;
        private System.Windows.Forms.Label AddingIngredients;
        private System.Windows.Forms.TextBox RecipeNameInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TimeToMakeLabel;
        private System.Windows.Forms.TextBox TimeToMakeInput;
        private System.Windows.Forms.ListBox IngredientsListBox;
        private System.Windows.Forms.Button AddIngredientButton;
        private Presetation.RestaurantDbDataSet restaurantDbDataSet;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
    }
}
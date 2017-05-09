namespace RestaurantDB.Presentation
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
            this.components = new System.ComponentModel.Container();
            this.RestaurantCreationTitle = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RestaurantNameInput = new System.Windows.Forms.TextBox();
            this.NameAdding = new System.Windows.Forms.Label();
            this.RecipesLabel = new System.Windows.Forms.Label();
            this.KitchenModelComboBox = new System.Windows.Forms.ComboBox();
            this.kitchenModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDbDataSet = new RestaurantDB.Presetation.RestaurantDbDataSet();
            this.KitchenModelLabel = new System.Windows.Forms.Label();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.RecipeListBox = new System.Windows.Forms.ListBox();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.RecipesTableAdapter();
            this.kitchenModelsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.KitchenModelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
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
            this.CancelButton.Location = new System.Drawing.Point(196, 254);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(94, 254);
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
            // RecipesLabel
            // 
            this.RecipesLabel.AutoSize = true;
            this.RecipesLabel.Location = new System.Drawing.Point(14, 147);
            this.RecipesLabel.Name = "RecipesLabel";
            this.RecipesLabel.Size = new System.Drawing.Size(49, 13);
            this.RecipesLabel.TabIndex = 13;
            this.RecipesLabel.Text = "Recipes:";
            // 
            // KitchenModelComboBox
            // 
            this.KitchenModelComboBox.DataSource = this.kitchenModelsBindingSource;
            this.KitchenModelComboBox.DisplayMember = "Name";
            this.KitchenModelComboBox.FormattingEnabled = true;
            this.KitchenModelComboBox.Location = new System.Drawing.Point(150, 94);
            this.KitchenModelComboBox.Name = "KitchenModelComboBox";
            this.KitchenModelComboBox.Size = new System.Drawing.Size(121, 21);
            this.KitchenModelComboBox.TabIndex = 15;
            this.KitchenModelComboBox.ValueMember = "Id";
            // 
            // kitchenModelsBindingSource
            // 
            this.kitchenModelsBindingSource.DataMember = "KitchenModels";
            this.kitchenModelsBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // restaurantDbDataSet
            // 
            this.restaurantDbDataSet.DataSetName = "RestaurantDbDataSet";
            this.restaurantDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KitchenModelLabel
            // 
            this.KitchenModelLabel.AutoSize = true;
            this.KitchenModelLabel.Location = new System.Drawing.Point(14, 97);
            this.KitchenModelLabel.Name = "KitchenModelLabel";
            this.KitchenModelLabel.Size = new System.Drawing.Size(77, 13);
            this.KitchenModelLabel.TabIndex = 16;
            this.KitchenModelLabel.Text = "Kitchen model:";
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(291, 147);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.AddRecipeButton.TabIndex = 17;
            this.AddRecipeButton.Text = "Add recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // RecipeListBox
            // 
            this.RecipeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.recipesBindingSource, "Name", true));
            this.RecipeListBox.DataSource = this.recipesBindingSource;
            this.RecipeListBox.DisplayMember = "Name";
            this.RecipeListBox.FormattingEnabled = true;
            this.RecipeListBox.Location = new System.Drawing.Point(151, 147);
            this.RecipeListBox.Name = "RecipeListBox";
            this.RecipeListBox.Size = new System.Drawing.Size(120, 82);
            this.RecipeListBox.TabIndex = 18;
            this.RecipeListBox.ValueMember = "Name";
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // kitchenModelsTableAdapter
            // 
            this.kitchenModelsTableAdapter.ClearBeforeFill = true;
            // 
            // RestaurantCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 289);
            this.Controls.Add(this.RecipeListBox);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.KitchenModelLabel);
            this.Controls.Add(this.KitchenModelComboBox);
            this.Controls.Add(this.RecipesLabel);
            this.Controls.Add(this.RestaurantNameInput);
            this.Controls.Add(this.NameAdding);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RestaurantCreationTitle);
            this.Name = "RestaurantCreation";
            this.Text = "RestaurantCreation";
            this.Load += new System.EventHandler(this.RestaurantCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantCreationTitle;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox RestaurantNameInput;
        private System.Windows.Forms.Label NameAdding;
        private System.Windows.Forms.Label RecipesLabel;
        private System.Windows.Forms.ComboBox KitchenModelComboBox;
        private System.Windows.Forms.Label KitchenModelLabel;
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.ListBox RecipeListBox;
        private Presetation.RestaurantDbDataSet restaurantDbDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingSource kitchenModelsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.KitchenModelsTableAdapter kitchenModelsTableAdapter;
    }
}
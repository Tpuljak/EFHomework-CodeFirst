namespace RestaurantDB.Presentation
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
            this.components = new System.ComponentModel.Container();
            this.RestaurantEditTitle = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.KitchenModelLabel = new System.Windows.Forms.Label();
            this.KitchenModelComboBox = new System.Windows.Forms.ComboBox();
            this.RecipesLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RecipeListBox = new System.Windows.Forms.ListBox();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.restaurantDbDataSet = new RestaurantDB.Presetation.RestaurantDbDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.EmployeesTableAdapter();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.RecipesTableAdapter();
            this.kitchenModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenModelsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.KitchenModelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenModelsBindingSource)).BeginInit();
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
            this.EditButton.Location = new System.Drawing.Point(83, 267);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(172, 267);
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
            this.KitchenModelLabel.Location = new System.Drawing.Point(14, 87);
            this.KitchenModelLabel.Name = "KitchenModelLabel";
            this.KitchenModelLabel.Size = new System.Drawing.Size(77, 13);
            this.KitchenModelLabel.TabIndex = 24;
            this.KitchenModelLabel.Text = "Kitchen model:";
            // 
            // KitchenModelComboBox
            // 
            this.KitchenModelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kitchenModelsBindingSource, "Name", true));
            this.KitchenModelComboBox.DataSource = this.kitchenModelsBindingSource;
            this.KitchenModelComboBox.DisplayMember = "Name";
            this.KitchenModelComboBox.FormattingEnabled = true;
            this.KitchenModelComboBox.Location = new System.Drawing.Point(110, 84);
            this.KitchenModelComboBox.Name = "KitchenModelComboBox";
            this.KitchenModelComboBox.Size = new System.Drawing.Size(133, 21);
            this.KitchenModelComboBox.TabIndex = 23;
            this.KitchenModelComboBox.ValueMember = "Name";
            // 
            // RecipesLabel
            // 
            this.RecipesLabel.AutoSize = true;
            this.RecipesLabel.Location = new System.Drawing.Point(14, 138);
            this.RecipesLabel.Name = "RecipesLabel";
            this.RecipesLabel.Size = new System.Drawing.Size(49, 13);
            this.RecipesLabel.TabIndex = 21;
            this.RecipesLabel.Text = "Recipes:";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(110, 46);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(133, 20);
            this.NameInput.TabIndex = 18;
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
            // RecipeListBox
            // 
            this.RecipeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.recipesBindingSource, "Name", true));
            this.RecipeListBox.DataSource = this.recipesBindingSource;
            this.RecipeListBox.DisplayMember = "Name";
            this.RecipeListBox.FormattingEnabled = true;
            this.RecipeListBox.Location = new System.Drawing.Point(110, 138);
            this.RecipeListBox.Name = "RecipeListBox";
            this.RecipeListBox.Size = new System.Drawing.Size(132, 95);
            this.RecipeListBox.TabIndex = 26;
            this.RecipeListBox.ValueMember = "Name";
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(17, 167);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.AddRecipeButton.TabIndex = 28;
            this.AddRecipeButton.Text = "Add recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // restaurantDbDataSet
            // 
            this.restaurantDbDataSet.DataSetName = "RestaurantDbDataSet";
            this.restaurantDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
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
            // kitchenModelsBindingSource
            // 
            this.kitchenModelsBindingSource.DataMember = "KitchenModels";
            this.kitchenModelsBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // kitchenModelsTableAdapter
            // 
            this.kitchenModelsTableAdapter.ClearBeforeFill = true;
            // 
            // RestaurantEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 301);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.RecipeListBox);
            this.Controls.Add(this.KitchenModelLabel);
            this.Controls.Add(this.KitchenModelComboBox);
            this.Controls.Add(this.RecipesLabel);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RestaurantEditTitle);
            this.Name = "RestaurantEdit";
            this.Text = "RestaurantEdit";
            this.Load += new System.EventHandler(this.RestaurantEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantEditTitle;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label KitchenModelLabel;
        private System.Windows.Forms.ComboBox KitchenModelComboBox;
        private System.Windows.Forms.Label RecipesLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListBox RecipeListBox;
        private System.Windows.Forms.Button AddRecipeButton;
        private Presetation.RestaurantDbDataSet restaurantDbDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingSource kitchenModelsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.KitchenModelsTableAdapter kitchenModelsTableAdapter;
    }
}
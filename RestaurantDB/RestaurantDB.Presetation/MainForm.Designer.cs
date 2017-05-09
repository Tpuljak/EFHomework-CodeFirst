namespace RestaurantDB.Presentation
{
    partial class MainForm
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
            this.RecipesButton = new System.Windows.Forms.Button();
            this.KitchenModelsButton = new System.Windows.Forms.Button();
            this.RestaurantsButton = new System.Windows.Forms.Button();
            this.restaurantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDbDataSet = new RestaurantDB.Presetation.RestaurantDbDataSet();
            this.kitchenModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KitchenModelLabel = new System.Windows.Forms.Label();
            this.KitchenModelText = new System.Windows.Forms.TextBox();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolPanel1 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.IngredientsGrid = new System.Windows.Forms.ListBox();
            this.RecipesGrid = new System.Windows.Forms.ListBox();
            this.ToolPanel2 = new System.Windows.Forms.Panel();
            this.EditButton2 = new System.Windows.Forms.Button();
            this.AddButton2 = new System.Windows.Forms.Button();
            this.DeleteButton2 = new System.Windows.Forms.Button();
            this.RestaurantsPanel = new System.Windows.Forms.Panel();
            this.RestaurantsGrid = new System.Windows.Forms.ListBox();
            this.ToolPanel3 = new System.Windows.Forms.Panel();
            this.EditButton3 = new System.Windows.Forms.Button();
            this.AddButton3 = new System.Windows.Forms.Button();
            this.DeleteButton3 = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.ListBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.EmployeesTableAdapter();
            this.kitchenModelsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.KitchenModelsTableAdapter();
            this.ingredientsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.IngredientsTableAdapter();
            this.recipesTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.RecipesTableAdapter();
            this.restaurantsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.RestaurantsTableAdapter();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitchenModelGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            this.ToolPanel1.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.ToolPanel2.SuspendLayout();
            this.RestaurantsPanel.SuspendLayout();
            this.ToolPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenModelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipesButton
            // 
            this.RecipesButton.Location = new System.Drawing.Point(486, 2);
            this.RecipesButton.Name = "RecipesButton";
            this.RecipesButton.Size = new System.Drawing.Size(238, 38);
            this.RecipesButton.TabIndex = 4;
            this.RecipesButton.Text = "Recipes";
            this.RecipesButton.UseVisualStyleBackColor = true;
            this.RecipesButton.Click += new System.EventHandler(this.RecipesButton_Click);
            // 
            // KitchenModelsButton
            // 
            this.KitchenModelsButton.Location = new System.Drawing.Point(240, 2);
            this.KitchenModelsButton.Name = "KitchenModelsButton";
            this.KitchenModelsButton.Size = new System.Drawing.Size(240, 38);
            this.KitchenModelsButton.TabIndex = 5;
            this.KitchenModelsButton.Text = "Kitchen Models";
            this.KitchenModelsButton.UseVisualStyleBackColor = true;
            this.KitchenModelsButton.Click += new System.EventHandler(this.KitchenModelsButton_Click);
            // 
            // RestaurantsButton
            // 
            this.RestaurantsButton.Location = new System.Drawing.Point(2, 2);
            this.RestaurantsButton.Name = "RestaurantsButton";
            this.RestaurantsButton.Size = new System.Drawing.Size(230, 38);
            this.RestaurantsButton.TabIndex = 6;
            this.RestaurantsButton.Text = "Restaurants";
            this.RestaurantsButton.UseVisualStyleBackColor = true;
            this.RestaurantsButton.Click += new System.EventHandler(this.RestaurantsButton_Click);
            // 
            // restaurantsBindingSource
            // 
            this.restaurantsBindingSource.DataMember = "Restaurants";
            this.restaurantsBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // restaurantDbDataSet
            // 
            this.restaurantDbDataSet.DataSetName = "RestaurantDbDataSet";
            this.restaurantDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitchenModelsBindingSource
            // 
            this.kitchenModelsBindingSource.DataMember = "KitchenModels";
            this.kitchenModelsBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // KitchenModelLabel
            // 
            this.KitchenModelLabel.AutoSize = true;
            this.KitchenModelLabel.Location = new System.Drawing.Point(233, 70);
            this.KitchenModelLabel.Name = "KitchenModelLabel";
            this.KitchenModelLabel.Size = new System.Drawing.Size(78, 13);
            this.KitchenModelLabel.TabIndex = 15;
            this.KitchenModelLabel.Text = "Kitchen Model:";
            // 
            // KitchenModelText
            // 
            this.KitchenModelText.Location = new System.Drawing.Point(314, 67);
            this.KitchenModelText.Name = "KitchenModelText";
            this.KitchenModelText.ReadOnly = true;
            this.KitchenModelText.Size = new System.Drawing.Size(159, 20);
            this.KitchenModelText.TabIndex = 16;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // ToolPanel1
            // 
            this.ToolPanel1.Controls.Add(this.EditButton);
            this.ToolPanel1.Controls.Add(this.AddButton);
            this.ToolPanel1.Controls.Add(this.DeleteButton);
            this.ToolPanel1.Location = new System.Drawing.Point(236, 0);
            this.ToolPanel1.Name = "ToolPanel1";
            this.ToolPanel1.Size = new System.Drawing.Size(240, 50);
            this.ToolPanel1.TabIndex = 24;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(81, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 46);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditRestaurantButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(0, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 46);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddRestaurantButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(162, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 46);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteRestaurantButton_Click);
            // 
            // RecipePanel
            // 
            this.RecipePanel.Controls.Add(this.AddIngredientButton);
            this.RecipePanel.Controls.Add(this.IngredientsGrid);
            this.RecipePanel.Controls.Add(this.RecipesGrid);
            this.RecipePanel.Controls.Add(this.ToolPanel2);
            this.RecipePanel.Location = new System.Drawing.Point(12, 46);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(720, 300);
            this.RecipePanel.TabIndex = 25;
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(388, 262);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(106, 23);
            this.AddIngredientButton.TabIndex = 29;
            this.AddIngredientButton.Text = "Add Ingredient";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddNewIngredientButton_Click);
            // 
            // IngredientsGrid
            // 
            this.IngredientsGrid.DataSource = this.ingredientsBindingSource;
            this.IngredientsGrid.DisplayMember = "Name";
            this.IngredientsGrid.FormattingEnabled = true;
            this.IngredientsGrid.Location = new System.Drawing.Point(500, 6);
            this.IngredientsGrid.Name = "IngredientsGrid";
            this.IngredientsGrid.Size = new System.Drawing.Size(220, 290);
            this.IngredientsGrid.TabIndex = 28;
            this.IngredientsGrid.ValueMember = "Name";
            // 
            // RecipesGrid
            // 
            this.RecipesGrid.DataSource = this.recipesBindingSource;
            this.RecipesGrid.DisplayMember = "Name";
            this.RecipesGrid.FormattingEnabled = true;
            this.RecipesGrid.Location = new System.Drawing.Point(0, 7);
            this.RecipesGrid.Name = "RecipesGrid";
            this.RecipesGrid.Size = new System.Drawing.Size(220, 290);
            this.RecipesGrid.TabIndex = 27;
            this.RecipesGrid.ValueMember = "Name";
            this.RecipesGrid.SelectedIndexChanged += new System.EventHandler(this.RecipeGrid_SelectionChanged);
            // 
            // ToolPanel2
            // 
            this.ToolPanel2.Controls.Add(this.EditButton2);
            this.ToolPanel2.Controls.Add(this.AddButton2);
            this.ToolPanel2.Controls.Add(this.DeleteButton2);
            this.ToolPanel2.Location = new System.Drawing.Point(236, 85);
            this.ToolPanel2.Name = "ToolPanel2";
            this.ToolPanel2.Size = new System.Drawing.Size(240, 50);
            this.ToolPanel2.TabIndex = 25;
            // 
            // EditButton2
            // 
            this.EditButton2.Enabled = false;
            this.EditButton2.Location = new System.Drawing.Point(84, 4);
            this.EditButton2.Name = "EditButton2";
            this.EditButton2.Size = new System.Drawing.Size(75, 46);
            this.EditButton2.TabIndex = 21;
            this.EditButton2.Text = "Edit";
            this.EditButton2.UseVisualStyleBackColor = true;
            this.EditButton2.Click += new System.EventHandler(this.EditRecipeButton_Click);
            // 
            // AddButton2
            // 
            this.AddButton2.Location = new System.Drawing.Point(0, 4);
            this.AddButton2.Name = "AddButton2";
            this.AddButton2.Size = new System.Drawing.Size(75, 46);
            this.AddButton2.TabIndex = 20;
            this.AddButton2.Text = "Add";
            this.AddButton2.UseVisualStyleBackColor = true;
            this.AddButton2.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DeleteButton2
            // 
            this.DeleteButton2.Enabled = false;
            this.DeleteButton2.Location = new System.Drawing.Point(165, 4);
            this.DeleteButton2.Name = "DeleteButton2";
            this.DeleteButton2.Size = new System.Drawing.Size(75, 46);
            this.DeleteButton2.TabIndex = 22;
            this.DeleteButton2.Text = "Delete";
            this.DeleteButton2.UseVisualStyleBackColor = true;
            this.DeleteButton2.Click += new System.EventHandler(this.DeleteRecipeButton_Click);
            // 
            // RestaurantsPanel
            // 
            this.RestaurantsPanel.Controls.Add(this.RestaurantsGrid);
            this.RestaurantsPanel.Controls.Add(this.ToolPanel3);
            this.RestaurantsPanel.Controls.Add(this.KitchenModelText);
            this.RestaurantsPanel.Controls.Add(this.KitchenModelLabel);
            this.RestaurantsPanel.Controls.Add(this.ToolPanel1);
            this.RestaurantsPanel.Controls.Add(this.EmployeeGrid);
            this.RestaurantsPanel.Location = new System.Drawing.Point(2, 49);
            this.RestaurantsPanel.Name = "RestaurantsPanel";
            this.RestaurantsPanel.Size = new System.Drawing.Size(720, 300);
            this.RestaurantsPanel.TabIndex = 24;
            // 
            // RestaurantsGrid
            // 
            this.RestaurantsGrid.DataSource = this.restaurantsBindingSource;
            this.RestaurantsGrid.DisplayMember = "Name";
            this.RestaurantsGrid.FormattingEnabled = true;
            this.RestaurantsGrid.Location = new System.Drawing.Point(3, 7);
            this.RestaurantsGrid.Name = "RestaurantsGrid";
            this.RestaurantsGrid.Size = new System.Drawing.Size(230, 290);
            this.RestaurantsGrid.TabIndex = 29;
            this.RestaurantsGrid.ValueMember = "Name";
            this.RestaurantsGrid.SelectedIndexChanged += new System.EventHandler(this.RestaurantGrid_SelectionChanged);
            // 
            // ToolPanel3
            // 
            this.ToolPanel3.Controls.Add(this.EditButton3);
            this.ToolPanel3.Controls.Add(this.AddButton3);
            this.ToolPanel3.Controls.Add(this.DeleteButton3);
            this.ToolPanel3.Location = new System.Drawing.Point(238, 243);
            this.ToolPanel3.Name = "ToolPanel3";
            this.ToolPanel3.Size = new System.Drawing.Size(238, 50);
            this.ToolPanel3.TabIndex = 26;
            // 
            // EditButton3
            // 
            this.EditButton3.Enabled = false;
            this.EditButton3.Location = new System.Drawing.Point(81, 4);
            this.EditButton3.Name = "EditButton3";
            this.EditButton3.Size = new System.Drawing.Size(75, 46);
            this.EditButton3.TabIndex = 21;
            this.EditButton3.Text = "Edit";
            this.EditButton3.UseVisualStyleBackColor = true;
            this.EditButton3.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // AddButton3
            // 
            this.AddButton3.Location = new System.Drawing.Point(0, 4);
            this.AddButton3.Name = "AddButton3";
            this.AddButton3.Size = new System.Drawing.Size(75, 46);
            this.AddButton3.TabIndex = 20;
            this.AddButton3.Text = "Add";
            this.AddButton3.UseVisualStyleBackColor = true;
            this.AddButton3.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DeleteButton3
            // 
            this.DeleteButton3.Enabled = false;
            this.DeleteButton3.Location = new System.Drawing.Point(160, 4);
            this.DeleteButton3.Name = "DeleteButton3";
            this.DeleteButton3.Size = new System.Drawing.Size(75, 46);
            this.DeleteButton3.TabIndex = 22;
            this.DeleteButton3.Text = "Delete";
            this.DeleteButton3.UseVisualStyleBackColor = true;
            this.DeleteButton3.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "Name", true));
            this.EmployeeGrid.DataSource = this.employeesBindingSource;
            this.EmployeeGrid.DisplayMember = "Name";
            this.EmployeeGrid.FormattingEnabled = true;
            this.EmployeeGrid.Location = new System.Drawing.Point(482, 0);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(237, 290);
            this.EmployeeGrid.TabIndex = 27;
            this.EmployeeGrid.ValueMember = "Name";
            this.EmployeeGrid.SelectedIndexChanged += new System.EventHandler(this.EmployeeGrid_SelectionChanged);
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
            // kitchenModelsTableAdapter
            // 
            this.kitchenModelsTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantsTableAdapter
            // 
            this.restaurantsTableAdapter.ClearBeforeFill = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // KitchenModelGrid
            // 
            this.KitchenModelGrid.AllowUserToAddRows = false;
            this.KitchenModelGrid.AllowUserToDeleteRows = false;
            this.KitchenModelGrid.AutoGenerateColumns = false;
            this.KitchenModelGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.KitchenModelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitchenModelGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.KitchenModelGrid.DataSource = this.kitchenModelsBindingSource;
            this.KitchenModelGrid.Location = new System.Drawing.Point(137, 49);
            this.KitchenModelGrid.MultiSelect = false;
            this.KitchenModelGrid.Name = "KitchenModelGrid";
            this.KitchenModelGrid.ReadOnly = true;
            this.KitchenModelGrid.Size = new System.Drawing.Size(409, 300);
            this.KitchenModelGrid.TabIndex = 13;
            this.KitchenModelGrid.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 372);
            this.Controls.Add(this.RestaurantsButton);
            this.Controls.Add(this.KitchenModelsButton);
            this.Controls.Add(this.RecipesButton);
            this.Controls.Add(this.RecipePanel);
            this.Controls.Add(this.KitchenModelGrid);
            this.Controls.Add(this.RestaurantsPanel);
            this.Name = "MainForm";
            this.Text = "Restaurant Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            this.ToolPanel1.ResumeLayout(false);
            this.RecipePanel.ResumeLayout(false);
            this.ToolPanel2.ResumeLayout(false);
            this.RestaurantsPanel.ResumeLayout(false);
            this.RestaurantsPanel.PerformLayout();
            this.ToolPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenModelGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RecipesButton;
        private System.Windows.Forms.Button KitchenModelsButton;
        private System.Windows.Forms.Button RestaurantsButton;
        private System.Windows.Forms.Label KitchenModelLabel;
        private System.Windows.Forms.TextBox KitchenModelText;
        private System.Windows.Forms.Panel ToolPanel1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel RecipePanel;
        private System.Windows.Forms.Panel RestaurantsPanel;
        private System.Windows.Forms.Panel ToolPanel2;
        private System.Windows.Forms.Button EditButton2;
        private System.Windows.Forms.Button AddButton2;
        private System.Windows.Forms.Button DeleteButton2;
        private System.Windows.Forms.Panel ToolPanel3;
        private System.Windows.Forms.Button EditButton3;
        private System.Windows.Forms.Button AddButton3;
        private System.Windows.Forms.Button DeleteButton3;
        private Presetation.RestaurantDbDataSet restaurantDbDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource kitchenModelsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.KitchenModelsTableAdapter kitchenModelsTableAdapter;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingSource restaurantsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.RestaurantsTableAdapter restaurantsTableAdapter;
        private System.Windows.Forms.ListBox RecipesGrid;
        private System.Windows.Forms.ListBox IngredientsGrid;
        private System.Windows.Forms.ListBox RestaurantsGrid;
        private System.Windows.Forms.ListBox EmployeeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView KitchenModelGrid;
        private System.Windows.Forms.Button AddIngredientButton;
    }
}
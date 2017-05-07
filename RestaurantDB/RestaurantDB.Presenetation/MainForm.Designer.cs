namespace RestaurantDB.Presenetation
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
            this.RecipesButton = new System.Windows.Forms.Button();
            this.KitchenModelsButton = new System.Windows.Forms.Button();
            this.RestaurantsButton = new System.Windows.Forms.Button();
            this.RestaurantsGrid = new System.Windows.Forms.DataGridView();
            this.EmployeesCheckBox = new System.Windows.Forms.CheckBox();
            this.KitchenModelGrid = new System.Windows.Forms.DataGridView();
            this.RecipesCheckBox = new System.Windows.Forms.CheckBox();
            this.KitchenModelLabel = new System.Windows.Forms.Label();
            this.KitchenModelText = new System.Windows.Forms.TextBox();
            this.RecipesGrid2 = new System.Windows.Forms.DataGridView();
            this.RecipesGrid = new System.Windows.Forms.DataGridView();
            this.IngredientsGrid = new System.Windows.Forms.DataGridView();
            this.ToolPanel1 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.ToolPanel2 = new System.Windows.Forms.Panel();
            this.EditButton2 = new System.Windows.Forms.Button();
            this.AddButton2 = new System.Windows.Forms.Button();
            this.DeleteButton2 = new System.Windows.Forms.Button();
            this.RestaurantsPanel = new System.Windows.Forms.Panel();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.ToolPanel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenModelGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsGrid)).BeginInit();
            this.ToolPanel1.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.ToolPanel2.SuspendLayout();
            this.RestaurantsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.ToolPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecipesButton
            // 
            this.RecipesButton.Location = new System.Drawing.Point(484, 2);
            this.RecipesButton.Name = "RecipesButton";
            this.RecipesButton.Size = new System.Drawing.Size(238, 38);
            this.RecipesButton.TabIndex = 4;
            this.RecipesButton.Text = "Recipes";
            this.RecipesButton.UseVisualStyleBackColor = true;
            this.RecipesButton.Click += new System.EventHandler(this.RecipesButton_Click);
            // 
            // KitchenModelsButton
            // 
            this.KitchenModelsButton.Location = new System.Drawing.Point(238, 2);
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
            // RestaurantsGrid
            // 
            this.RestaurantsGrid.AllowUserToAddRows = false;
            this.RestaurantsGrid.AllowUserToDeleteRows = false;
            this.RestaurantsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RestaurantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantsGrid.Location = new System.Drawing.Point(0, 0);
            this.RestaurantsGrid.Name = "RestaurantsGrid";
            this.RestaurantsGrid.ReadOnly = true;
            this.RestaurantsGrid.Size = new System.Drawing.Size(230, 300);
            this.RestaurantsGrid.TabIndex = 7;
            this.RestaurantsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestaurantGrid_CellClick);
            // 
            // EmployeesCheckBox
            // 
            this.EmployeesCheckBox.AutoSize = true;
            this.EmployeesCheckBox.Enabled = false;
            this.EmployeesCheckBox.Location = new System.Drawing.Point(368, 99);
            this.EmployeesCheckBox.Name = "EmployeesCheckBox";
            this.EmployeesCheckBox.Size = new System.Drawing.Size(77, 17);
            this.EmployeesCheckBox.TabIndex = 11;
            this.EmployeesCheckBox.Text = "Employees";
            this.EmployeesCheckBox.UseVisualStyleBackColor = true;
            this.EmployeesCheckBox.CheckedChanged += new System.EventHandler(this.EmployeesCheckBox_CheckedChanged);
            // 
            // KitchenModelGrid
            // 
            this.KitchenModelGrid.AllowUserToAddRows = false;
            this.KitchenModelGrid.AllowUserToDeleteRows = false;
            this.KitchenModelGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.KitchenModelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitchenModelGrid.Location = new System.Drawing.Point(137, 49);
            this.KitchenModelGrid.Name = "KitchenModelGrid";
            this.KitchenModelGrid.ReadOnly = true;
            this.KitchenModelGrid.Size = new System.Drawing.Size(409, 300);
            this.KitchenModelGrid.TabIndex = 13;
            this.KitchenModelGrid.Visible = false;
            // 
            // RecipesCheckBox
            // 
            this.RecipesCheckBox.AutoSize = true;
            this.RecipesCheckBox.Enabled = false;
            this.RecipesCheckBox.Location = new System.Drawing.Point(262, 99);
            this.RecipesCheckBox.Name = "RecipesCheckBox";
            this.RecipesCheckBox.Size = new System.Drawing.Size(65, 17);
            this.RecipesCheckBox.TabIndex = 14;
            this.RecipesCheckBox.Text = "Recipes";
            this.RecipesCheckBox.UseVisualStyleBackColor = true;
            this.RecipesCheckBox.CheckedChanged += new System.EventHandler(this.RecipesCheckBox_CheckedChange);
            // 
            // KitchenModelLabel
            // 
            this.KitchenModelLabel.AutoSize = true;
            this.KitchenModelLabel.Location = new System.Drawing.Point(236, 63);
            this.KitchenModelLabel.Name = "KitchenModelLabel";
            this.KitchenModelLabel.Size = new System.Drawing.Size(78, 13);
            this.KitchenModelLabel.TabIndex = 15;
            this.KitchenModelLabel.Text = "Kitchen Model:";
            // 
            // KitchenModelText
            // 
            this.KitchenModelText.Location = new System.Drawing.Point(317, 60);
            this.KitchenModelText.Name = "KitchenModelText";
            this.KitchenModelText.ReadOnly = true;
            this.KitchenModelText.Size = new System.Drawing.Size(159, 20);
            this.KitchenModelText.TabIndex = 16;
            // 
            // RecipesGrid2
            // 
            this.RecipesGrid2.AllowUserToAddRows = false;
            this.RecipesGrid2.AllowUserToDeleteRows = false;
            this.RecipesGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RecipesGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipesGrid2.Location = new System.Drawing.Point(236, 132);
            this.RecipesGrid2.Name = "RecipesGrid2";
            this.RecipesGrid2.ReadOnly = true;
            this.RecipesGrid2.Size = new System.Drawing.Size(240, 168);
            this.RecipesGrid2.TabIndex = 17;
            this.RecipesGrid2.Visible = false;
            // 
            // RecipesGrid
            // 
            this.RecipesGrid.AllowUserToAddRows = false;
            this.RecipesGrid.AllowUserToDeleteRows = false;
            this.RecipesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RecipesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipesGrid.GridColor = System.Drawing.SystemColors.Control;
            this.RecipesGrid.Location = new System.Drawing.Point(0, 0);
            this.RecipesGrid.Name = "RecipesGrid";
            this.RecipesGrid.ReadOnly = true;
            this.RecipesGrid.Size = new System.Drawing.Size(230, 300);
            this.RecipesGrid.TabIndex = 18;
            this.RecipesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipesGrid_CellClick);
            // 
            // IngredientsGrid
            // 
            this.IngredientsGrid.AllowUserToAddRows = false;
            this.IngredientsGrid.AllowUserToDeleteRows = false;
            this.IngredientsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.IngredientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientsGrid.GridColor = System.Drawing.SystemColors.Control;
            this.IngredientsGrid.Location = new System.Drawing.Point(482, 0);
            this.IngredientsGrid.Name = "IngredientsGrid";
            this.IngredientsGrid.ReadOnly = true;
            this.IngredientsGrid.Size = new System.Drawing.Size(238, 300);
            this.IngredientsGrid.TabIndex = 19;
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
            this.EditButton.Location = new System.Drawing.Point(84, 4);
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
            this.AddButton.Click += new System.EventHandler(this.AddRestarurantButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(165, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 46);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteRestaurantButton_Click);
            // 
            // RecipePanel
            // 
            this.RecipePanel.Controls.Add(this.ToolPanel2);
            this.RecipePanel.Controls.Add(this.RecipesGrid);
            this.RecipePanel.Controls.Add(this.IngredientsGrid);
            this.RecipePanel.Location = new System.Drawing.Point(12, 46);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(720, 300);
            this.RecipePanel.TabIndex = 25;
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
            this.RestaurantsPanel.Controls.Add(this.ToolPanel3);
            this.RestaurantsPanel.Controls.Add(this.EmployeeGrid);
            this.RestaurantsPanel.Controls.Add(this.RecipesGrid2);
            this.RestaurantsPanel.Controls.Add(this.KitchenModelText);
            this.RestaurantsPanel.Controls.Add(this.KitchenModelLabel);
            this.RestaurantsPanel.Controls.Add(this.RecipesCheckBox);
            this.RestaurantsPanel.Controls.Add(this.EmployeesCheckBox);
            this.RestaurantsPanel.Controls.Add(this.ToolPanel1);
            this.RestaurantsPanel.Controls.Add(this.RestaurantsGrid);
            this.RestaurantsPanel.Location = new System.Drawing.Point(2, 49);
            this.RestaurantsPanel.Name = "RestaurantsPanel";
            this.RestaurantsPanel.Size = new System.Drawing.Size(720, 300);
            this.RestaurantsPanel.TabIndex = 24;
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AllowUserToAddRows = false;
            this.EmployeeGrid.AllowUserToDeleteRows = false;
            this.EmployeeGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.GridColor = System.Drawing.SystemColors.Control;
            this.EmployeeGrid.Location = new System.Drawing.Point(482, 0);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.Size = new System.Drawing.Size(237, 238);
            this.EmployeeGrid.TabIndex = 25;
            this.EmployeeGrid.Visible = false;
            // 
            // ToolPanel3
            // 
            this.ToolPanel3.Controls.Add(this.button1);
            this.ToolPanel3.Controls.Add(this.button2);
            this.ToolPanel3.Controls.Add(this.button3);
            this.ToolPanel3.Location = new System.Drawing.Point(485, 244);
            this.ToolPanel3.Name = "ToolPanel3";
            this.ToolPanel3.Size = new System.Drawing.Size(235, 50);
            this.ToolPanel3.TabIndex = 26;
            this.ToolPanel3.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(84, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 20;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(165, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 22;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 372);
            this.Controls.Add(this.RestaurantsPanel);
            this.Controls.Add(this.RecipePanel);
            this.Controls.Add(this.KitchenModelGrid);
            this.Controls.Add(this.RestaurantsButton);
            this.Controls.Add(this.KitchenModelsButton);
            this.Controls.Add(this.RecipesButton);
            this.Name = "MainForm";
            this.Text = "Restaurant Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenModelGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsGrid)).EndInit();
            this.ToolPanel1.ResumeLayout(false);
            this.RecipePanel.ResumeLayout(false);
            this.ToolPanel2.ResumeLayout(false);
            this.RestaurantsPanel.ResumeLayout(false);
            this.RestaurantsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.ToolPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RecipesButton;
        private System.Windows.Forms.Button KitchenModelsButton;
        private System.Windows.Forms.Button RestaurantsButton;
        private System.Windows.Forms.DataGridView RestaurantsGrid;
        private System.Windows.Forms.CheckBox EmployeesCheckBox;
        private System.Windows.Forms.DataGridView KitchenModelGrid;
        private System.Windows.Forms.CheckBox RecipesCheckBox;
        private System.Windows.Forms.Label KitchenModelLabel;
        private System.Windows.Forms.TextBox KitchenModelText;
        private System.Windows.Forms.DataGridView RecipesGrid2;
        private System.Windows.Forms.DataGridView RecipesGrid;
        private System.Windows.Forms.DataGridView IngredientsGrid;
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
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.Panel ToolPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


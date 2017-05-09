namespace RestaurantDB.Presentation
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
            this.components = new System.ComponentModel.Container();
            this.EmployeeCreationTitle = new System.Windows.Forms.Label();
            this.EmployeeNameInput = new System.Windows.Forms.TextBox();
            this.NameAdding = new System.Windows.Forms.Label();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.IdNumberInput = new System.Windows.Forms.TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleSelection = new System.Windows.Forms.ComboBox();
            this.BirthYearLabel = new System.Windows.Forms.Label();
            this.YearOfBirthInput = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RestaurantLabel = new System.Windows.Forms.Label();
            this.RestaurantListBox = new System.Windows.Forms.ListBox();
            this.restaurantDbDataSet = new RestaurantDB.Presetation.RestaurantDbDataSet();
            this.restaurantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.RestaurantsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).BeginInit();
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
            // EmployeeNameInput
            // 
            this.EmployeeNameInput.Location = new System.Drawing.Point(132, 54);
            this.EmployeeNameInput.Name = "EmployeeNameInput";
            this.EmployeeNameInput.Size = new System.Drawing.Size(175, 20);
            this.EmployeeNameInput.TabIndex = 12;
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
            // IdNumberInput
            // 
            this.IdNumberInput.Location = new System.Drawing.Point(132, 98);
            this.IdNumberInput.Name = "IdNumberInput";
            this.IdNumberInput.Size = new System.Drawing.Size(175, 20);
            this.IdNumberInput.TabIndex = 14;
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
            // RoleSelection
            // 
            this.RoleSelection.FormattingEnabled = true;
            this.RoleSelection.Items.AddRange(new object[] {
            "Lead Chef",
            "Assistant Chef",
            "Waiter"});
            this.RoleSelection.Location = new System.Drawing.Point(186, 146);
            this.RoleSelection.Name = "RoleSelection";
            this.RoleSelection.Size = new System.Drawing.Size(121, 21);
            this.RoleSelection.TabIndex = 16;
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
            // YearOfBirthInput
            // 
            this.YearOfBirthInput.Location = new System.Drawing.Point(186, 193);
            this.YearOfBirthInput.Name = "YearOfBirthInput";
            this.YearOfBirthInput.Size = new System.Drawing.Size(121, 20);
            this.YearOfBirthInput.TabIndex = 18;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(444, 193);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(342, 193);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RestaurantLabel
            // 
            this.RestaurantLabel.AutoSize = true;
            this.RestaurantLabel.Location = new System.Drawing.Point(339, 38);
            this.RestaurantLabel.Name = "RestaurantLabel";
            this.RestaurantLabel.Size = new System.Drawing.Size(53, 13);
            this.RestaurantLabel.TabIndex = 21;
            this.RestaurantLabel.Text = "Works at:";
            // 
            // RestaurantListBox
            // 
            this.RestaurantListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.restaurantsBindingSource, "Id", true));
            this.RestaurantListBox.DataSource = this.restaurantsBindingSource;
            this.RestaurantListBox.DisplayMember = "Name";
            this.RestaurantListBox.FormattingEnabled = true;
            this.RestaurantListBox.Location = new System.Drawing.Point(342, 54);
            this.RestaurantListBox.Name = "RestaurantListBox";
            this.RestaurantListBox.Size = new System.Drawing.Size(177, 95);
            this.RestaurantListBox.TabIndex = 22;
            this.RestaurantListBox.ValueMember = "Name";
            // 
            // restaurantDbDataSet
            // 
            this.restaurantDbDataSet.DataSetName = "RestaurantDbDataSet";
            this.restaurantDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantsBindingSource
            // 
            this.restaurantsBindingSource.DataMember = "Restaurants";
            this.restaurantsBindingSource.DataSource = this.restaurantDbDataSet;
            // 
            // restaurantsTableAdapter
            // 
            this.restaurantsTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 240);
            this.Controls.Add(this.RestaurantListBox);
            this.Controls.Add(this.RestaurantLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.YearOfBirthInput);
            this.Controls.Add(this.BirthYearLabel);
            this.Controls.Add(this.RoleSelection);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.IdNumberInput);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.EmployeeNameInput);
            this.Controls.Add(this.NameAdding);
            this.Controls.Add(this.EmployeeCreationTitle);
            this.Name = "EmployeeCreation";
            this.Text = "EmployeeCreation";
            this.Load += new System.EventHandler(this.EmployeeCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeCreationTitle;
        private System.Windows.Forms.TextBox EmployeeNameInput;
        private System.Windows.Forms.Label NameAdding;
        private System.Windows.Forms.Label IdNumberLabel;
        private System.Windows.Forms.TextBox IdNumberInput;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.ComboBox RoleSelection;
        private System.Windows.Forms.Label BirthYearLabel;
        private System.Windows.Forms.TextBox YearOfBirthInput;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label RestaurantLabel;
        private System.Windows.Forms.ListBox RestaurantListBox;
        private Presetation.RestaurantDbDataSet restaurantDbDataSet;
        private System.Windows.Forms.BindingSource restaurantsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.RestaurantsTableAdapter restaurantsTableAdapter;
    }
}
namespace RestaurantDB.Presentation
{
    partial class EmployeeEdit
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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmployeeEditTitle = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BirthYearInput = new System.Windows.Forms.TextBox();
            this.BirthYearLabel = new System.Windows.Forms.Label();
            this.RoleSelection = new System.Windows.Forms.ComboBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RestaurantListBox = new System.Windows.Forms.ListBox();
            this.restaurantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDbDataSet = new RestaurantDB.Presetation.RestaurantDbDataSet();
            this.RestaurantLabel = new System.Windows.Forms.Label();
            this.restaurantsTableAdapter = new RestaurantDB.Presetation.RestaurantDbDataSetTableAdapters.RestaurantsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(210, 51);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 16;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 54);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "New name:";
            // 
            // EmployeeEditTitle
            // 
            this.EmployeeEditTitle.AutoSize = true;
            this.EmployeeEditTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeEditTitle.Location = new System.Drawing.Point(12, 9);
            this.EmployeeEditTitle.Name = "EmployeeEditTitle";
            this.EmployeeEditTitle.Size = new System.Drawing.Size(146, 26);
            this.EmployeeEditTitle.TabIndex = 14;
            this.EmployeeEditTitle.Text = "EMPLOYEE EDIT";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(354, 176);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(448, 176);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BirthYearInput
            // 
            this.BirthYearInput.Location = new System.Drawing.Point(189, 135);
            this.BirthYearInput.Name = "BirthYearInput";
            this.BirthYearInput.Size = new System.Drawing.Size(121, 20);
            this.BirthYearInput.TabIndex = 24;
            // 
            // BirthYearLabel
            // 
            this.BirthYearLabel.AutoSize = true;
            this.BirthYearLabel.Location = new System.Drawing.Point(17, 138);
            this.BirthYearLabel.Name = "BirthYearLabel";
            this.BirthYearLabel.Size = new System.Drawing.Size(67, 13);
            this.BirthYearLabel.TabIndex = 23;
            this.BirthYearLabel.Text = "Year of birth:";
            // 
            // RoleSelection
            // 
            this.RoleSelection.FormattingEnabled = true;
            this.RoleSelection.Items.AddRange(new object[] {
            "Lead Chef",
            "Assistant Chef",
            "Waiter"});
            this.RoleSelection.Location = new System.Drawing.Point(189, 93);
            this.RoleSelection.Name = "RoleSelection";
            this.RoleSelection.Size = new System.Drawing.Size(121, 21);
            this.RoleSelection.TabIndex = 22;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(17, 96);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(35, 13);
            this.RoleLabel.TabIndex = 21;
            this.RoleLabel.Text = "Role: ";
            // 
            // RestaurantListBox
            // 
            this.RestaurantListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.restaurantsBindingSource, "Name", true));
            this.RestaurantListBox.DataSource = this.restaurantsBindingSource;
            this.RestaurantListBox.DisplayMember = "Name";
            this.RestaurantListBox.FormattingEnabled = true;
            this.RestaurantListBox.Location = new System.Drawing.Point(346, 55);
            this.RestaurantListBox.Name = "RestaurantListBox";
            this.RestaurantListBox.Size = new System.Drawing.Size(177, 95);
            this.RestaurantListBox.TabIndex = 26;
            this.RestaurantListBox.ValueMember = "Name";
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
            // RestaurantLabel
            // 
            this.RestaurantLabel.AutoSize = true;
            this.RestaurantLabel.Location = new System.Drawing.Point(343, 39);
            this.RestaurantLabel.Name = "RestaurantLabel";
            this.RestaurantLabel.Size = new System.Drawing.Size(53, 13);
            this.RestaurantLabel.TabIndex = 25;
            this.RestaurantLabel.Text = "Works at:";
            // 
            // restaurantsTableAdapter
            // 
            this.restaurantsTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 212);
            this.Controls.Add(this.RestaurantListBox);
            this.Controls.Add(this.RestaurantLabel);
            this.Controls.Add(this.BirthYearInput);
            this.Controls.Add(this.BirthYearLabel);
            this.Controls.Add(this.RoleSelection);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmployeeEditTitle);
            this.Name = "EmployeeEdit";
            this.Text = "EmployeeEdit";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmployeeEditTitle;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox BirthYearInput;
        private System.Windows.Forms.Label BirthYearLabel;
        private System.Windows.Forms.ComboBox RoleSelection;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.ListBox RestaurantListBox;
        private System.Windows.Forms.Label RestaurantLabel;
        private Presetation.RestaurantDbDataSet restaurantDbDataSet;
        private System.Windows.Forms.BindingSource restaurantsBindingSource;
        private Presetation.RestaurantDbDataSetTableAdapters.RestaurantsTableAdapter restaurantsTableAdapter;
    }
}
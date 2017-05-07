namespace RestaurantDB.Presenetation
{
    partial class RecipeEdit
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
            this.RecipeEditTitle = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.IngredientsComboBox = new System.Windows.Forms.ComboBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.TimeToMakeInput = new System.Windows.Forms.TextBox();
            this.TimeToMakeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecipeEditTitle
            // 
            this.RecipeEditTitle.AutoSize = true;
            this.RecipeEditTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeEditTitle.Location = new System.Drawing.Point(12, 9);
            this.RecipeEditTitle.Name = "RecipeEditTitle";
            this.RecipeEditTitle.Size = new System.Drawing.Size(113, 26);
            this.RecipeEditTitle.TabIndex = 1;
            this.RecipeEditTitle.Text = "RECIPE EDIT";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(174, 205);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(80, 205);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // IngredientsComboBox
            // 
            this.IngredientsComboBox.FormattingEnabled = true;
            this.IngredientsComboBox.Location = new System.Drawing.Point(128, 153);
            this.IngredientsComboBox.Name = "IngredientsComboBox";
            this.IngredientsComboBox.Size = new System.Drawing.Size(121, 21);
            this.IngredientsComboBox.TabIndex = 10;
            this.IngredientsComboBox.SelectedIndexChanged += new System.EventHandler(this.IngredientsComboBox_SelectedIndexChanged);
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(17, 153);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(62, 13);
            this.IngredientsLabel.TabIndex = 11;
            this.IngredientsLabel.Text = "Ingredients:";
            this.IngredientsLabel.Click += new System.EventHandler(this.IngredientsLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 54);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "New name:";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(149, 51);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 13;
            // 
            // TimeToMakeInput
            // 
            this.TimeToMakeInput.Location = new System.Drawing.Point(149, 95);
            this.TimeToMakeInput.Name = "TimeToMakeInput";
            this.TimeToMakeInput.Size = new System.Drawing.Size(100, 20);
            this.TimeToMakeInput.TabIndex = 14;
            // 
            // TimeToMakeLabel
            // 
            this.TimeToMakeLabel.AutoSize = true;
            this.TimeToMakeLabel.Location = new System.Drawing.Point(17, 98);
            this.TimeToMakeLabel.Name = "TimeToMakeLabel";
            this.TimeToMakeLabel.Size = new System.Drawing.Size(123, 13);
            this.TimeToMakeLabel.TabIndex = 15;
            this.TimeToMakeLabel.Text = "Time to make (seconds):";
            // 
            // RecipeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 240);
            this.Controls.Add(this.TimeToMakeLabel);
            this.Controls.Add(this.TimeToMakeInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.IngredientsComboBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RecipeEditTitle);
            this.Name = "RecipeEdit";
            this.Text = "RecipeEdit";
            this.Load += new System.EventHandler(this.RecipeEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecipeEditTitle;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox IngredientsComboBox;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox TimeToMakeInput;
        private System.Windows.Forms.Label TimeToMakeLabel;
    }
}
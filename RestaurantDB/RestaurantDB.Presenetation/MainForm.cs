using Restaurant.DB;
using System;
using System.Windows.Forms;
using System.Configuration;

using System.Linq;
using Restaurant.DB.Models;

namespace RestaurantDB.Presenetation
{
    public partial class MainForm : Form
    {
        public MainForm(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private readonly RestaurantContext _context;

        private void Form1_Load(object sender, EventArgs e)
        {
            KitchenModelGrid.Visible = false;
            RestaurantsPanel.Visible = false;
            RecipePanel.Visible = false;
        }

        private void RecipesButton_Click(object sender, EventArgs e)
        {
            KitchenModelGrid.Visible = false;
            RestaurantsPanel.Visible = false;
            RecipePanel.Visible = !RecipePanel.Visible;
            RecipePanel.BringToFront();
            
        }

        private void KitchenModelsButton_Click(object sender, EventArgs e)
        {
            RecipePanel.Visible = false;
            RestaurantsPanel.Visible = false;
            KitchenModelGrid.Visible = !KitchenModelGrid.Visible;
            KitchenModelGrid.BringToFront();
        }

        private void RestaurantsButton_Click(object sender, EventArgs e)
        {
            KitchenModelGrid.Visible = false;
            RecipePanel.Visible = false;
            RestaurantsPanel.Visible = !RestaurantsPanel.Visible;
            RestaurantsPanel.BringToFront();
        }

        private void EmployeesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmployeesCheckBox.Checked)
            {
                EmployeeGrid.Visible = true;
                ToolPanel3.Visible = true;
            }
            else
            {
                EmployeeGrid.Visible = false;
                ToolPanel3.Visible = false;
            }
        }

        private void RecipesCheckBox_CheckedChange(object sender, EventArgs e)
        {
            if (RecipesCheckBox.Checked) RecipesGrid2.Visible = true;
            else RecipesGrid2.Visible = false;
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeCreation newRecipeCreation = new RecipeCreation(_context);
            newRecipeCreation.ShowDialog();
        }

        private void recipesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void EditRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeEdit newRecipeEdit = new RecipeEdit(_context);
            newRecipeEdit.ShowDialog();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {

        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            RestaurantEdit newRestaurantEdit = new RestaurantEdit(_context);
            newRestaurantEdit.ShowDialog();
        }

        private void AddRestarurantButton_Click(object sender, EventArgs e)
        {
            RestaurantCreation newRestaurantCreation = new RestaurantCreation(_context);
            newRestaurantCreation.ShowDialog();
        }

        private void DeleteRestaurantButton_Click(object sender, EventArgs e)
        {

        }

        private void RestaurantGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton.Enabled = true;
            EditButton.Enabled = true;
            RecipesCheckBox.Enabled = true;
            EmployeesCheckBox.Enabled = true;
        }

        private void RecipesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton2.Enabled = true;
            EditButton2.Enabled = true;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeCreation newEmployeeCreation = new EmployeeCreation();
            newEmployeeCreation.ShowDialog();
        }
    }
}

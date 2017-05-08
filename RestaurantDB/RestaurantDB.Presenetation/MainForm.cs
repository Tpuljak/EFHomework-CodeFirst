using Restaurant.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using Restaurant.DB.Models;

namespace RestaurantDB.Presenetation
{
    public partial class MainForm : Form
    {
        public MainForm(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            selectedRestaurantNames = new List<string>();
        }

        private readonly RestaurantContext _context;
        private List<string> selectedRestaurantNames;
        private List<string> selectedEmployeeNames;
        private List<string> selectedRecipeNames;

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

        private void EditRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeEdit newRecipeEdit = new RecipeEdit(_context);
            newRecipeEdit.ShowDialog();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach (var name in selectedRecipeNames)
            {
                recipes.Add(_context.Recepies.FirstOrDefault(x => x.Name == name));
            }

            _context.Recepies.RemoveRange(recipes);
            _context.SaveChanges();
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
            List<Restaurant.DB.Models.Restaurant> restaurants = new List<Restaurant.DB.Models.Restaurant>();
            foreach (var name in selectedRestaurantNames)
            {
                restaurants.Add(_context.Restaurants.FirstOrDefault(x => x.Name == name));
            }

            _context.Restaurants.RemoveRange(restaurants);
            _context.SaveChanges();
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

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeEdit newEmployeeEdit = new EmployeeEdit();
            newEmployeeEdit.ShowDialog();
        }

        private void RestaurantGrid_SelectionChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            RecipesCheckBox.Enabled = true;
            EmployeesCheckBox.Enabled = true;
            DeleteButton.Enabled = true;
            List<string> restaurantNames = new List<string>();

            foreach (DataGridViewRow row in RestaurantsGrid.SelectedRows)
            {
                restaurantNames.Add(row.Cells["Name"].Value.ToString());
            }

            selectedRestaurantNames = restaurantNames;
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            foreach (var name in selectedEmployeeNames)
            {
                employees.Add(_context.Employees.FirstOrDefault(x => x.Name == name));
            }

            _context.Employees.RemoveRange(employees);
            _context.SaveChanges();
        }

        private void RecipeGrid_SelectionChanged(object sender, EventArgs e)
        {
            EditButton2.Enabled = true;
            DeleteButton2.Enabled = true;
            List<string> recipeNames = new List<string>();

            foreach (DataGridViewRow row in RecipesGrid.SelectedRows)
            {
                recipeNames.Add(row.Cells["Name"].Value.ToString());
            }

            selectedRecipeNames = recipeNames;
        }

        private void EmployeeGrid_SelectionChanged(object sender, EventArgs e)
        {
            EditButton3.Enabled = true;
            DeleteButton3.Enabled = true;
            List<string> employeeNames = new List<string>();

            foreach (DataGridViewRow row in EmployeeGrid.SelectedRows)
            {
                employeeNames.Add(row.Cells["Name"].Value.ToString());
            }

            selectedEmployeeNames = employeeNames;
        }
    }
}

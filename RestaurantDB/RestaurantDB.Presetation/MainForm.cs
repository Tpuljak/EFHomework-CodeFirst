using RestaurantDB.Data;
using RestaurantDB.Data.Models;
using RestaurantDB.Presetation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDB.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();
            var a = _context.KitchenModels.ToList();
        }

        private readonly RestaurantContext _context;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDbDataSet.Restaurants' table. You can move, or remove it, as needed.
            this.restaurantsTableAdapter.Fill(this.restaurantDbDataSet.Restaurants);
            // TODO: This line of code loads data into the 'restaurantDbDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.restaurantDbDataSet.Recipes);
            // TODO: This line of code loads data into the 'restaurantDbDataSet.Ingredients' table. You can move, or remove it, as needed.
            this.ingredientsTableAdapter.Fill(this.restaurantDbDataSet.Ingredients);
            // TODO: This line of code loads data into the 'restaurantDbDataSet.KitchenModels' table. You can move, or remove it, as needed.
            this.kitchenModelsTableAdapter.Fill(this.restaurantDbDataSet.KitchenModels);
            // TODO: This line of code loads data into the 'restaurantDbDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.restaurantDbDataSet.Employees);
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

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            if(_context.Ingredients.Count() == 0)
            {
                MessageBox.Show("No ingredients created yet...");
                return;
            }
            RecipeCreation newRecipeCreation = new RecipeCreation(_context);
            newRecipeCreation.ShowDialog();
            IngredientsGrid.DataSource = _context.Ingredients.ToList();
            RecipesGrid.DataSource = _context.Recepies.ToList();
        }

        private void EditRecipeButton_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipeToEdit = new Recipe();
            selectedRecipeToEdit = _context.Recepies.First(x => x.Name == RecipesGrid.SelectedValue.ToString());
            RecipeEdit newRecipeEdit = new RecipeEdit(selectedRecipeToEdit, _context);
            newRecipeEdit.ShowDialog();
            RecipesGrid.DataSource = _context.Recepies.ToList();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            Recipe recipeToDel = new Recipe();
            recipeToDel = _context.Recepies.First(x => x.Name == RecipesGrid.SelectedValue.ToString());

            _context.Recepies.Remove(recipeToDel);
            _context.SaveChanges();
            RecipesGrid.DataSource = _context.Recepies.ToList();
        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            RestaurantEdit newRestaurantEdit = new RestaurantEdit(_context);
            newRestaurantEdit.ShowDialog();
        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            if(_context.Recepies.Count() == 0)
            {
                MessageBox.Show("No recipes created yet...");
                return;
            }
            RestaurantCreation newRestaurantCreation = new RestaurantCreation(_context);
            newRestaurantCreation.ShowDialog();
            RestaurantsGrid.DataSource = _context.Restaurants.ToList();
        }

        private void DeleteRestaurantButton_Click(object sender, EventArgs e)
        {
            Restaurant restaurantToDel = new Restaurant();
            restaurantToDel = _context.Restaurants.First(x => x.Name == RestaurantsGrid.SelectedValue.ToString());

            _context.Restaurants.Remove(restaurantToDel);
            _context.SaveChanges();
            RestaurantsGrid.DataSource = _context.Restaurants.ToList();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if(_context.Restaurants.Count() == 0)
            {
                MessageBox.Show("No restaurants available, can't add employees without restaurants first!");
                return;
            }

            EmployeeCreation newEmployeeCreation = new EmployeeCreation(_context);
            newEmployeeCreation.ShowDialog();

            EmployeeGrid.DataSource = _context.Employees.ToList();
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee emplToEdit = new Employee();

            string selectedEmlName = EmployeeGrid.SelectedValue.ToString();
            emplToEdit = _context.Employees.First(x => x.Name == selectedEmlName);
            EmployeeEdit newEmployeeEdit = new EmployeeEdit(emplToEdit, _context);
            newEmployeeEdit.ShowDialog();

            EmployeeGrid.DataSource = _context.Employees.ToList();
        }

        private void RestaurantGrid_SelectionChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
            string selectedRestaurantName = RestaurantsGrid.SelectedValue.ToString();
            KitchenModelText.Text = _context.Restaurants.FirstOrDefault(x => x.Name == selectedRestaurantName).KitchenModel.Name;
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employeeToDel = new Employee();
            employeeToDel = _context.Employees.FirstOrDefault(x => x.Name == EmployeeGrid.SelectedValue.ToString());

            _context.Employees.Remove(employeeToDel);
            _context.SaveChanges();
            EmployeeGrid.DataSource = _context.Employees.ToList();
        }

        private void RecipeGrid_SelectionChanged(object sender, EventArgs e)
        {
            EditButton2.Enabled = true;
            DeleteButton2.Enabled = true;
        }

        private void EmployeeGrid_SelectionChanged(object sender, EventArgs e)
        {
            EditButton3.Enabled = true;
            DeleteButton3.Enabled = true;
        }


        private void AddNewIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientCreation newIngredientCreation = new IngredientCreation(_context);
            newIngredientCreation.ShowDialog();
            IngredientsGrid.DataSource = _context.Ingredients.ToList();
        }
    }
}

using RestaurantDB.Data;
using RestaurantDB.Data.Models;
using RestaurantDB.Presetation;
using System;
using System.Linq;
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
            
            RestaurantsGrid.DataSource = _context.Restaurants.ToList();
            RecipesGrid.DataSource = _context.Recepies.ToList();
            IngredientsGrid.DataSource = _context.Ingredients.ToList();
            EmployeeGrid.DataSource = _context.Employees.ToList();
        }

        private readonly RestaurantContext _context;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDbDataSet.KitchenModels' table. You can move, or remove it, as needed.
            this.kitchenModelsTableAdapter.Fill(this.restaurantDbDataSet.KitchenModels);
            KitchenModelGrid.Visible = false;
            RestaurantsPanel.Visible = false;
            RecipePanel.Visible = false;
            RestaurantsGrid.ClearSelected();
            EmployeeGrid.ClearSelected();
            RecipesGrid.ClearSelected();
            IngredientsGrid.ClearSelected();
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
            Restaurant selectedRestToEdit = new Restaurant();
            selectedRestToEdit = _context.Restaurants.First(x => x.Name == RestaurantsGrid.SelectedValue.ToString());
            
            RestaurantEdit newRestaurantEdit = new RestaurantEdit(selectedRestToEdit, _context);
            newRestaurantEdit.ShowDialog();
            RestaurantsGrid.DataSource = _context.Restaurants.ToList();
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
            
            if (_context.Restaurants.Count() == 0) KitchenModelText.Text = " ";
            RestaurantsGrid.DataSource = _context.Restaurants.ToList();
            EmployeeGrid.DataSource = _context.Employee.ToList();
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
            emplToEdit = _context.Employees.First(x => x.Name == EmployeeGrid.SelectedValue.ToString());
            
            EmployeeEdit newEmployeeEdit = new EmployeeEdit(emplToEdit, _context);
            newEmployeeEdit.ShowDialog();

            EmployeeGrid.DataSource = _context.Employees.ToList();
        }

        private void RestaurantGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (RestaurantsGrid.SelectedValue != null)
            {
                KitchenModelText.Text = _context.Restaurants.FirstOrDefault(x => x.Name == RestaurantsGrid.SelectedValue.ToString()).KitchenModel.Name;
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
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
            if(RecipesGrid.SelectedValue != null)
            {
                EditButton2.Enabled = true;
                DeleteButton2.Enabled = true;
            }       
        }

        private void EmployeeGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(EmployeeGrid.SelectedValue != null)
            {
                EditButton3.Enabled = true;
                DeleteButton3.Enabled = true;
            }
        }


        private void AddNewIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientCreation newIngredientCreation = new IngredientCreation(_context);
            newIngredientCreation.ShowDialog();
            IngredientsGrid.DataSource = _context.Ingredients.ToList();
        }
    }
}

using RestaurantDB.Data;
using RestaurantDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantDB.Presentation
{
    public partial class RestaurantEdit : Form
    {
        public RestaurantEdit(Restaurant restaurant, RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _restaurant = _context.Restaurants.First(x => x.Id == restaurant.Id);
            _restaurant.Employees.Clear();
            _restaurant.Recipes.Clear();
            _recipes = _context.Recepies.ToList();
            RecipeListBox.DataSource = _recipes;
        }

        private readonly RestaurantContext _context;
        private Restaurant _restaurant;
        private List<Recipe> _recipes;

        private void RestaurantEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDbDataSet.KitchenModels' table. You can move, or remove it, as needed.
            this.kitchenModelsTableAdapter.Fill(this.restaurantDbDataSet.KitchenModels);
            NameInput.Text = _restaurant.Name;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameInput.Text != null)
                _restaurant.Name = NameInput.Text;
            else
                MessageBox.Show("All fields are required!");

            _context.SaveChanges();
            Close();
            return;
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = new Recipe();
            selectedRecipe = (_context.Recepies.FirstOrDefault(x => x.Name == RecipeListBox.SelectedValue.ToString()));
            _restaurant.Recipes.Add(selectedRecipe);
            _recipes.Remove(selectedRecipe);

            if (_recipes.Count() == 0) AddRecipeButton.Enabled = false;
            RecipeListBox.DataSource = _recipes.ToList();
            RecipeListBox.DisplayMember = "Name";
        }
    }
}

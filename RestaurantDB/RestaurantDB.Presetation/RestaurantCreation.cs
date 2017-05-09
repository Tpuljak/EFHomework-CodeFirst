using RestaurantDB.Data;
using RestaurantDB.Data.Models;
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
    public partial class RestaurantCreation : Form
    {
        public RestaurantCreation(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _restaurant = new Restaurant();
            _recipes = new List<Recipe>();
            _recipes = _context.Recepies.ToList();
        }

        private readonly RestaurantContext _context;
        private Restaurant _restaurant;
        private List<Recipe> _recipes;

        private void RestaurantCreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDbDataSet.KitchenModels' table. You can move, or remove it, as needed.
            this.kitchenModelsTableAdapter.Fill(this.restaurantDbDataSet.KitchenModels);
            // TODO: This line of code loads data into the 'restaurantDbDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.restaurantDbDataSet.Recipes);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(RestaurantNameInput.Text != null && KitchenModelComboBox.SelectedItem != null)
            {
                _restaurant.Name = RestaurantNameInput.Text;
                _restaurant.KitchenModelId = KitchenModelComboBox.SelectedIndex + 1;
            }

            _context.Restaurants.Add(_restaurant);
            _context.SaveChanges();
            Close();
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
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

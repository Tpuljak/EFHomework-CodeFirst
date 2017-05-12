using RestaurantDB.Data;
using RestaurantDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantDB.Presentation
{
    public partial class RecipeCreation : Form
    {
        public RecipeCreation(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _recipe = new Recipe();
            _ingredients = new List<Ingredient>();
            _ingredients = _context.Ingredients.ToList();
            
            IngredientsListBox.DataSource = _ingredients;
        }

        private readonly RestaurantContext _context;
        private Recipe _recipe;
        private List<Ingredient> _ingredients;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(RecipeNameInput.Text != null && TimeToMakeInput.Text != null)
            {
                _recipe.Name = RecipeNameInput.Text;
                _recipe.TimeToMake = TimeToMakeInput.Text;
            }
            else
            {
                MessageBox.Show("All fields required!");
                return;
            }
            
            _context.Recepies.Add(_recipe);
            _context.SaveChanges();
            Close();
            return;
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            Ingredient selectedIngredient = new Ingredient();
            selectedIngredient = _context.Ingredients.FirstOrDefault(x => x.Name == IngredientsListBox.SelectedValue.ToString());
            _recipe.Ingredients.Add(selectedIngredient);
            _ingredients.Remove(selectedIngredient);

            if (_ingredients.Count() == 0) AddIngredientButton.Enabled = false;

            IngredientsListBox.DataSource = _ingredients.ToList();
        }

        private void RecipeCreation_Load(object sender, EventArgs e)
        {
        }
    }
}

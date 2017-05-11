using RestaurantDB.Data;
using RestaurantDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantDB.Presentation
{
    public partial class RecipeEdit : Form
    {
        public RecipeEdit(Recipe recipe, RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _recipe = _context.Recepies.Find(recipe.Id);

            foreach (var ingredient in _context.Ingredients)
            {
                if(ingredient.Recipes.Contains(_recipe))
                {
                    ingredient.Recipes.Remove(_recipe);
                }
            }

            _recipe.Ingredients.Clear();
            _ingredients = new List<Ingredient>();
            _ingredients = _context.Ingredients.ToList();
            IngredientsListBox.DataSource = _ingredients;
        }

        private readonly RestaurantContext _context;
        private Recipe _recipe;
        private List<Ingredient> _ingredients;

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameInput.Text != null && TimeToMakeInput.Text != null)
            {
                _recipe.Name = NameInput.Text;
                _recipe.TimeToMake = TimeToMakeInput.Text;
            }
            else
            {
                MessageBox.Show("All fields required!");
                return;
            }

            _context.SaveChanges();
            Close();
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void RecipeEdit_Load(object sender, EventArgs e)
        {
            NameInput.Text = _recipe.Name;
            TimeToMakeInput.Text = _recipe.TimeToMake;
            
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            Ingredient selectedIngredient = new Ingredient();
            selectedIngredient = (_context.Ingredients.FirstOrDefault(x => x.Name == IngredientsListBox.SelectedValue.ToString()));
            _recipe.Ingredients.Add(selectedIngredient);
            _ingredients.Remove(selectedIngredient);

            if (_ingredients.Count() == 0) AddIngredientButton.Enabled = false;

            IngredientsListBox.DisplayMember = "Name";
            IngredientsListBox.DataSource = _ingredients.ToList();
            
        }
    }
}

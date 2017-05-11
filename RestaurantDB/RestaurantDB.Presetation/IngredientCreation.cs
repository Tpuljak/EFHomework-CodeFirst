using RestaurantDB.Data;
using RestaurantDB.Data.Models;
using System;
using System.Windows.Forms;

namespace RestaurantDB.Presetation
{
    public partial class IngredientCreation : Form
    {
        public IngredientCreation(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _ingredient = new Ingredient();
        }

        private readonly RestaurantContext _context;
        private Ingredient _ingredient;
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(NameInput.Text != null)
            {
                _ingredient.Name = NameInput.Text;
            }

            _context.Ingredients.Add(_ingredient);
            _context.SaveChanges();
            Close();
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }
    }
}

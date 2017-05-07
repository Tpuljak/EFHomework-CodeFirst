using Restaurant.DB;
using System;
using System.Windows.Forms;

namespace RestaurantDB.Presenetation
{
    public partial class RecipeCreation : Form
    {
        public RecipeCreation(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private readonly RestaurantContext _context;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }
    }
}

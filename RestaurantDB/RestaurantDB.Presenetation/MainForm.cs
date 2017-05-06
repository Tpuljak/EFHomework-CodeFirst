using Restaurant.DB;
using System;
using System.Windows.Forms;
using System.Configuration;

using System.Linq;

namespace RestaurantDB.Presenetation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           _context = new RestaurantContext(ConfigurationManager.AppSettings["DbConnectionString"]);
		}

        private readonly RestaurantContext _context;

        private void Form1_Load(object sender, EventArgs e)
        {
            KitchenModelGrid.Visible = false;
            RestaurantsPanel.Visible = false;
            RecipePanel.Visible = false;
			var restoutrans = _context.Restaurants.ToList();
			MessageBox.Show(restoutrans.Count.ToString());
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
            if (EmployeesCheckBox.Checked) EmployeeGrid.Visible = true;
            else EmployeeGrid.Visible = false;
        }

        private void RecipesCheckBox_CheckedChange(object sender, EventArgs e)
        {
            if (RecipesCheckBox.Checked) RecipesGrid2.Visible = true;
            else RecipesGrid2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void ToolPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeCreation newRecipeCreation = new RecipeCreation();
            newRecipeCreation.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void recipesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RestaurantsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void RecipesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

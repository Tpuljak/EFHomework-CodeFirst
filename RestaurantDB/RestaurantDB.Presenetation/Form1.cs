using Restaurant.DB;
using System.Windows.Forms;
using System;

namespace RestaurantDB.Presenetation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //_context = new RestaurantContext();
        }

        private readonly RestaurantContext _context;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDBDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.restaurantDBDataSet.Recipes);
            // TODO: This line of code loads data into the 'restaurantDBDataSet1.KitchenModels' table. You can move, or remove it, as needed.
            this.kitchenModelsTableAdapter.Fill(this.restaurantDBDataSet1.KitchenModels);
            // TODO: This line of code loads data into the 'restaurantDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.restaurantDBDataSet.Employees);
            // TODO: This line of code loads data into the 'restaurantDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.restaurantDBDataSet.Employees);
            // TODO: This line of code loads data into the 'restaurantDBDataSet.Restaurants' table. You can move, or remove it, as needed.
            this.restaurantsTableAdapter.Fill(this.restaurantDBDataSet.Restaurants);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            checkBox1.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            label1.Visible = false;
            textBox1.Visible = false;
            dataGridView4.Visible = false;
            dataGridView3.Visible = !dataGridView3.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            dataGridView1.Visible = !dataGridView1.Visible;
            button4.Visible = !button4.Visible;
            button5.Visible = !button5.Visible;
            button6.Visible = !button6.Visible;
            checkBox1.Visible = !checkBox1.Visible;
            checkBox2.Visible = !checkBox2.Visible;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            label1.Visible = !label1.Visible;
            textBox1.Visible = !textBox1.Visible;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) dataGridView2.Visible = true;
            else dataGridView2.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) dataGridView4.Visible = true;
            else dataGridView4.Visible = false;
        }
    }
}

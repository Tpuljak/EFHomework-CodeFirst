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
    public partial class EmployeeCreation : Form
    {
        public EmployeeCreation(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _employee = new Employee();
        }

        private readonly RestaurantContext _context;
        private Employee _employee;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (EmployeeNameInput.Text != null && RoleSelection.SelectedItem != null && IdNumberInput.Text != null && YearOfBirthInput.Text != null)
            {
                _employee.Name = EmployeeNameInput.Text;
                _employee.Role = (Role)RoleSelection.SelectedIndex;
                _employee.PersonalIdNumber = IdNumberInput.Text;
                _employee.BirthYear = int.Parse(YearOfBirthInput.Text);
            }
            else
                MessageBox.Show("All fields are required!");

            string selectedRestName = RestaurantListBox.SelectedValue.ToString();
            _employee.Restaurant = _context.Restaurants.FirstOrDefault(x => x.Name == selectedRestName);
            _context.Employees.Add(_employee);
            _context.SaveChanges();
            Close();
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void EmployeeCreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDbDataSet.Restaurants' table. You can move, or remove it, as needed.
            this.restaurantsTableAdapter.Fill(this.restaurantDbDataSet.Restaurants);

        }
    }
}

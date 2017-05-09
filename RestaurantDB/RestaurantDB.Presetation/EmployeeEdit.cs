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
    public partial class EmployeeEdit : Form
    {
        public EmployeeEdit(Employee employee, RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _employee = _context.Employees.Find(employee.PersonalIdNumber);
            RestaurantListBox.DataSource = _context.Restaurants.ToList();
        }

        private readonly RestaurantContext _context;
        private Employee _employee;

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EmployeeNameInput.Text != null && RoleSelection.SelectedItem != null && BirthYearInput.Text != null)
            {
                _employee.Name = EmployeeNameInput.Text;
                _employee.Role = (Role)RoleSelection.SelectedIndex;
                string selectedRestName = RestaurantListBox.SelectedValue.ToString();
                _employee.Restaurant = _context.Restaurants.First(x => x.Name == selectedRestName);
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

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDbDataSet.Restaurants' table. You can move, or remove it, as needed.
            this.restaurantsTableAdapter.Fill(this.restaurantDbDataSet.Restaurants);

        }
    }
}

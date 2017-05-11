using RestaurantDB.Data;
using RestaurantDB.Data.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantDB.Presentation
{
    public partial class EmployeeEdit : Form
    {
        public EmployeeEdit(Employee employee, RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
            _employee = _context.Employees.First(x => x.PersonalIdNumber == employee.PersonalIdNumber);
            RestaurantListBox.DataSource = _context.Restaurants.ToList();
        }

        private readonly RestaurantContext _context;
        private Employee _employee;

        private void EditButton_Click(object sender, EventArgs e)
        {
            RestaurantListBox.ClearSelected();
            if (NameInput.Text != null && RoleSelection.SelectedItem != null && BirthYearInput.Text != null && RestaurantListBox.SelectedItem != null)
            {
                _employee.Name = NameInput.Text;
                _employee.Role = (Role)RoleSelection.SelectedIndex;
                string selectedRestName = RestaurantListBox.SelectedValue.ToString();
                _employee.Restaurant = _context.Restaurants.First(x => x.Name == selectedRestName);
            }

            else
            {
                MessageBox.Show("All fields are required!");
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

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            NameInput.Text = _employee.Name;
        }
    }
}

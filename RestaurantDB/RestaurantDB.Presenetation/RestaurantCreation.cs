using Restaurant.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDB.Presenetation
{
    public partial class RestaurantCreation : Form
    {
        public RestaurantCreation(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private readonly RestaurantContext _context;

        private void RestaurantCreation_Load(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void KitchenModelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

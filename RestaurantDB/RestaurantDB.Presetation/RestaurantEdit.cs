using RestaurantDB.Data;
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
    public partial class RestaurantEdit : Form
    {
        public RestaurantEdit(RestaurantContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private readonly RestaurantContext _context;

        private void RestaurantEdit_Load(object sender, EventArgs e)
        {
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }
    }
}

using Restaurant.DB;
using System.Windows.Forms;

namespace RestaurantDB.Presenetation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _context = new RestaurantContext();
        }

        private readonly RestaurantContext _context;
    }
}

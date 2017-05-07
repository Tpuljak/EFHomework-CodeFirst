using Restaurant.DB;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantDB.Presenetation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RestaurantContext _context = new RestaurantContext();

            Application.Run(new MainForm(_context));
        }
    }
}

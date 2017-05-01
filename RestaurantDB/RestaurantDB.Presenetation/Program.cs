using System;
using System.Windows.Forms;
using Restaurant.DB;

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
            RestaurantContext context = new RestaurantContext();
            context.SaveChanges();
            Application.Run(new Form1());
        }
    }
}

using Restaurant.DB;
using System;
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
            var a = new RestaurantContext();
            var b = a.KitchenModels.ToList();
            Application.Run(new Form1());
        }
    }
}

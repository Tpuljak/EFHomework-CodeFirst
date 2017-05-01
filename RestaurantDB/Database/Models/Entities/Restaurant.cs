using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DB.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public KitchenModel KitchenModel { get; set; }
    }
}

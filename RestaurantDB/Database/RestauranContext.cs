using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Restaurant.DB.Models;

namespace Restaurant.DB
{
    class RestauranContext : DbContext
    {
        public RestauranContext() : base()
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recepies { get; set; }
        public DbSet<KitchenModel> KitchenModels { get; set; }
        public DbSet<Restaurant.DB.Models.Restaurant> Restaurants { get; set; }
    }
}

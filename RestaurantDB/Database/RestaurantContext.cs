using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Restaurant.DB.Models;
using Restaurant.DB.Initialization;

namespace Restaurant.DB
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("Restaurant")
        {
            Database.SetInitializer(new KitchenModelDBInitialization());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recepies { get; set; }
        public DbSet<KitchenModel> KitchenModels { get; set; }
        public DbSet<Models.Restaurant> Restaurants { get; set; }
    }
}

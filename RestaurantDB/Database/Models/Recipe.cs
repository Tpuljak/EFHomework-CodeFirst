using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DB.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TimeToMake { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

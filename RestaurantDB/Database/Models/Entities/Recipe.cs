using System.Collections.Generic;

namespace Restaurant.DB.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Ingredients = new HashSet<Ingredient>();
            Restaurants = new HashSet<Restaurant>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string TimeToMake { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}

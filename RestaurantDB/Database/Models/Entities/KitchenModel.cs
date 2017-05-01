using System.Collections.Generic;

namespace Restaurant.DB.Models
{
    public class KitchenModel
    {
        public KitchenModel()
        {
            Restaurants = new HashSet<Restaurant>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public ICollection<Restaurant> Restaurants { get; set; }
    }
}

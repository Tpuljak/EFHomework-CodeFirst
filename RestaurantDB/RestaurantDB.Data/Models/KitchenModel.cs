using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDB.Data.Models
{
    public class KitchenModel
    {
        public KitchenModel()
        {
            Restaurants = new HashSet<Restaurant>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ICollection<Restaurant> Restaurants { get; set; }
    }
}

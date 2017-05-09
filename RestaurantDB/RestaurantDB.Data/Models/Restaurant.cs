using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDB.Data.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            Employees = new HashSet<Employee>();
            Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
        public int KitchenModelId { get; set; }
        public virtual KitchenModel KitchenModel { get; set; }
    }
}

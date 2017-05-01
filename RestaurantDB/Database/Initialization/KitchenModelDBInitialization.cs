using Restaurant.DB.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Restaurant.DB.Initialization
{
    public class KitchenModelDBInitialization : DropCreateDatabaseAlways<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var kichenModels = new List<KitchenModel>()
            {
                new KitchenModel()
                {
                    Name = "Italian",
                    Price = "9999.99"
                },

                new KitchenModel()
                {
                    Name = "German",
                    Price = "100000.01"
                },

                new KitchenModel()
                {
                    Name = "Chinese",
                    Price = "8.00"
                },

                new KitchenModel()
                {
                    Name = "English",
                    Price = "132952.12"
                }
            };

            context.KitchenModels.AddRange(kichenModels);
            base.Seed(context);
        }
    }
}

using RestaurantDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDB.Data.Initialization
{
    public class KitchenModelDBInitialization : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var kichenModels = new List<KitchenModel>()
            {
                new KitchenModel()
                {
                    Name = "Italian",
                    Price = 9999.99
                },

                new KitchenModel()
                {
                    Name = "German",
                    Price = 100000.01
                },

                new KitchenModel()
                {
                    Name = "Chinese",
                    Price = 8.00
                },

                new KitchenModel()
                {
                    Name = "English",
                    Price = 132952.12
                },

                new KitchenModel()
                {
                    Name = "Croatian",
                    Price = 1234.56
                }
            };

            context.KitchenModels.AddRange(kichenModels);
            base.Seed(context);
        }
    }
}

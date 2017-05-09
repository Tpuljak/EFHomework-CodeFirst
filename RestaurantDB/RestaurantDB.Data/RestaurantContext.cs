using RestaurantDB.Data.Initialization;
using RestaurantDB.Data.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace RestaurantDB.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("RestaurantDb")
        {
            Database.SetInitializer(new KitchenModelDBInitialization());
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Recipe> Recepies { get; set; }
        public virtual DbSet<KitchenModel> KitchenModels { get; set; }
        public virtual DbSet<Models.Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasRequired(x => x.Restaurant)
                .WithMany(x => x.Employees).HasForeignKey(x => x.RestaurantId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Restaurant>().HasRequired(x => x.KitchenModel)
                .WithMany(x => x.Restaurants).HasForeignKey(x => x.KitchenModelId)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}
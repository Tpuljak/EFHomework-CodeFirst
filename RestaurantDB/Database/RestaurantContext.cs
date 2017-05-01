using System.Data.Entity;
using Restaurant.DB.Models;
using Restaurant.DB.Initialization;

namespace Restaurant.DB
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("RestaurantDB")
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
            modelBuilder.Entity<Models.Restaurant>().HasRequired(x => x.KitchenModel)
                .WithMany(x => x.Restaurants).HasForeignKey(x => x.KitchenModelId)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}
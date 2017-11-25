using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace UniStore.Models
{
    using UniStore.Models.EntityModels;
    public class UniStoreDbContext : IdentityDbContext<User>
    {
        public UniStoreDbContext():base("UniStore",false)
        {

        }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Order> Orders { get; set; }

        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasOptional(x => x.Department)
                .WithMany(x => x.Categories)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<SubCategory>()
                .HasOptional(x => x.Category)
                .WithMany(x => x.SubCategories)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Product>()
                .HasOptional(x => x.SubCategory)
                .WithMany(x => x.Products)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }

        public static UniStoreDbContext Create()
        {
            return new UniStoreDbContext();
        }
    }
}
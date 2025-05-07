using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Rodney_Stock_WindowsFormApp.Models
{
    public partial class RodneyStockDB : DbContext
    {
        public RodneyStockDB()
            : base("name=RodneyStockDB")
        {
        }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<DealerType> DealerTypes { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>()
            //    .HasOptional(k => k.UpCategory)
            //    .WithMany(k => k.SubCategories)
            //    .HasForeignKey(k => k.UpCategory)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithRequired(p => p.Category)
                .HasForeignKey(p => p.CategoryID);
        }
        
    }
}

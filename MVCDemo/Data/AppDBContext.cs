using Microsoft.EntityFrameworkCore;
using MVCDemo.Models;

namespace MVCDemo.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users {  get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=Tillayep.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

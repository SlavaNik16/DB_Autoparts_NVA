using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using Keys = DB_Autoparts_NVA.Models.Keys;

namespace DB_Autoparts_NVA.DB
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Набор сущностей класса Users
        /// </summary>
        public DbSet<Users> UserDB { get; set; }
        /// <summary>
        /// Набор сущностей класса Autoparts
        /// </summary>
        public DbSet<Autoparts> AutopartDB { get; set; }
        /// <summary>
        /// Набор сущностей класса Products
        /// </summary>
        public DbSet<Product> ProductDB { get; set; }
        /// <summary>
        /// Набор сущностей класса Keys
        /// </summary>
        public DbSet<Keys> KeyDB { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(x => x.user_id);
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Autoparts>().HasKey(x => x.parts_id);
            modelBuilder.Entity<Autoparts>().ToTable("Autoparts");
            modelBuilder.Entity<Product>().HasKey(x => x.id_product);
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Keys>().HasKey(x => x.id);
            modelBuilder.Entity<Keys>().ToTable("Key");

        }

    }
}

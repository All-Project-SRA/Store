using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Models;
namespace Store.Models.DB
{
   public class AppDbContext : IdentityDbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        { }

    
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Categorie_M> Categories_M { get; set; }
        public DbSet<Categorie_D> Categories_D { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Propertie> Properties { get; set; }
        public DbSet<Value_Propertie> Value_Properties { get; set; }


    }
   
}

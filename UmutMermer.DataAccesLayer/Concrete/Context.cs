using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.DataAccesLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole , int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MUHAMMED;initial catalog=CurrentUmutMermer;integrated security=true ");
           
        }
        public DbSet <Category> Categories { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}

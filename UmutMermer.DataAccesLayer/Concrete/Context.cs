﻿using Microsoft.EntityFrameworkCore;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MUHAMMED;initial catalog=UmutMermer;integrated security=true ");
        }
        public DbSet <Category> Categorys { get; set; }
        public DbSet<Companyİnfo> Companyİnfos { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Products> Product { get; set; }
    }
}
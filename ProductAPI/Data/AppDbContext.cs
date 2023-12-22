﻿using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;

namespace ProductAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Product).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}

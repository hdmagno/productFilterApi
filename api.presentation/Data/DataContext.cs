using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.presentation.Models;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace api.presentation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product 
                    {
                        Id = i,
                        Title = new Bogus.DataSets.Lorem().Word(),
                        Description = new Bogus.DataSets.Lorem().Paragraph(),
                        Image = new Bogus.DataSets.Images().LoremPixelUrl(),
                        Price = new Bogus.Randomizer().Number(10, 100)
                    }
                );
            }
        }
    }
}

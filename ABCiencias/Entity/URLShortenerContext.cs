using ABCiencias.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCiencias.Entity
{
    public class URLShortenerContext : DbContext, IURLShortenerContext
    {
        public DbSet<URLShortener> Urls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=abcdb.cwg2u9ksin9u.us-east-2.rds.amazonaws.com,1433;Initial Catalog=db_abc_dev;Persist Security Info=True;User ID=sansone;Password=MSP#1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<URLShortener>()
                .HasIndex(x => x.Guid)
                .IsUnique();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}

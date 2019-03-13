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
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B9MSDME\SQLEXPRESS;Initial Catalog=UrlDbContext;Integrated Security=True");
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

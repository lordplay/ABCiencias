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
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}

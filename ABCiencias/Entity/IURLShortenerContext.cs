using ABCiencias.Models;
using Microsoft.EntityFrameworkCore;

namespace ABCiencias.Entity
{
    public interface IURLShortenerContext
    {
        DbSet<URLShortener> Urls { get; set; }

        int SaveChanges();
    }
}
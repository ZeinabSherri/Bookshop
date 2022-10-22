using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Bookshop.Models
{
    public class BookshopDbContext : DbContext
    {
        public BookshopDbContext(DbContextOptions<BookshopDbContext> options)
           : base(options)
        {
        }

        public DbSet<Client> Client { get; set; } = null!;
    }
}

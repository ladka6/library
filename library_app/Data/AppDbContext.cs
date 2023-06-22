using library_app.Models;
using Microsoft.EntityFrameworkCore;

namespace library_app.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Models.Domain
{
    public class DatabaseContext:IdentityDbContext 
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base (options) {
            //Database.EnsureCreated();
        }
    
        public DbSet<Genre> Genre { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}

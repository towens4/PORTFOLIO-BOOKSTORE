using Microsoft.EntityFrameworkCore;
using WellsBookstore.Models.DataModels;


namespace WellsBookstore.Models.DBContexts
{
    public class WellsBookstoreDBContext : DbContext
    {
        public WellsBookstoreDBContext(DbContextOptions<WellsBookstoreDBContext> options) : base(options)
        {
                Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public  DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
    }
}

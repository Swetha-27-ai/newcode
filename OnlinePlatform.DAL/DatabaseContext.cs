using OnlinePlatform.ENTITIES.Concrete;
using System.Data.Entity;

namespace OnlinePlatform.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DatabaseContext")
        {
            Database.SetInitializer<DatabaseContext>(null);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}

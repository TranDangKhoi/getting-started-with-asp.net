using Microsoft.EntityFrameworkCore;

namespace ClothingStoreAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Clothes> Clothes { get; set; }
    }
}

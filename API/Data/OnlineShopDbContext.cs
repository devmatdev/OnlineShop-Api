namespace API.Data
{
    using API.Model;
    using Microsoft.EntityFrameworkCore;

    public class OnlineShopDbContext:DbContext
    {
        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options)
            :base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

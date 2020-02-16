using Microsoft.EntityFrameworkCore;
using EasyBuyShop.Models;

namespace EasyBuyShop.Models
{
    public class ShopDBContent :DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopDBContent(DbContextOptions<ShopDBContent> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}

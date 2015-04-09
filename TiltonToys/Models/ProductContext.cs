using System.Data.Entity;
namespace TiltonToys.Models
{
    /* This class represents Entity Framework product database context, 
     * which handles fetching, storing, and updating Product class 
     * instances in the database.
     */
    public class ProductContext : DbContext
    {
        public ProductContext() : base("TiltonToys")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
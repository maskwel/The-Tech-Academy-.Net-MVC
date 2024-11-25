using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TechStoreInventory.Models;

namespace TechStoreInventory.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
           
        }

        public DbSet<Products> Products { get; set; }
    }
}

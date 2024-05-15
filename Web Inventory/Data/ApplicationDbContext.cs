using Microsoft.EntityFrameworkCore;
using Web_Inventory.Models;

namespace Web_Inventory.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Inventory> inventories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Inventory>().HasData(
				new Inventory { Id = 1, ProductName = "Ball Pen", Quantity = 150, Price = 8, TotalPrice = 1200 },
				new Inventory { Id = 2, ProductName = "Matric Math Book", Quantity = 50, Price = 400, TotalPrice = 20000 },
				new Inventory { Id = 3, ProductName = "Pencil", Quantity = 500, Price = 7, TotalPrice = 3500 }
				);
		}
	}
}

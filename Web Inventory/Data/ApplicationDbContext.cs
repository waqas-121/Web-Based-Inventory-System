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
				new Inventory { Id = 1, ProductName = "Ball Pen", Quantity = 150, Price = },
				);
		}
	}
}

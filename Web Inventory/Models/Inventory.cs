using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web_Inventory.Models
{
	public class Inventory
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[DisplayName("Product Name")]
		public string ProductName { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public int Price { get; set; }
		[Required]
		public int TotalPrice { get; set; }


		public void CalculateTotalPrice()
		{
			TotalPrice = Quantity * Price;
		}
	}

}

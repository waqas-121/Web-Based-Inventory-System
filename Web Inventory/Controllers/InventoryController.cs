using Microsoft.AspNetCore.Mvc;
using Web_Inventory.Data;
using Web_Inventory.Models;

namespace Web_Inventory.Controllers
{
	public class InventoryController : Controller
	{
		private ApplicationDbContext _db;
		public InventoryController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			List<Inventory> inventoriesObj = _db.inventories.ToList();
			return View(inventoriesObj);
		}

		public IActionResult Retrive(int? Id)
		{
			if (Id == null || Id == 0)
			{
				return NotFound();
			}
			Inventory? inventoriesObj = _db.inventories.Find(Id);
			if (inventoriesObj == null)
			{
				return NotFound();
			}

			return View(inventoriesObj);
		}

		[HttpPost]
		public IActionResult Edit(Inventory obj)
		{

			if (ModelState.IsValid)
			{
				obj.TotalPrice = obj.CalculateTotalPrice(obj.Price, obj.Quantity);
				_db.inventories.Update(obj);

				_db.SaveChanges();
				//TempData["success"] = "Category updated successfully";
				return RedirectToAction("Index");
			}
			return View("Retrive");
		}

	}
}

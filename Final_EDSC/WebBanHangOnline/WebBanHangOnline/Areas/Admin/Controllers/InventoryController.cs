using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.Common;
using WebBanHangOnline.Models.ViewModels;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InventoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Inventory
        public ActionResult Index(InventoryFilterViewModel filter)
        {
            var products = db.Products.AsQueryable();
            ViewBag.Categories = db.ProductCategories.ToList();


            if (filter.ProductCategoryId.HasValue)
            {
                products = products.Where(p => p.ProductCategoryId == filter.ProductCategoryId.Value);
            }

            if (filter.MinimumRemaining.HasValue)
            {
                products = products.Where(p => p.Quantity - p.SoldQuantity <= filter.MinimumRemaining.Value);
            }
            

            var inventory = products.Select(p => new InventoryViewModel
            {
                ProductId = p.Id,
                ProductName = p.Title,
                Quantity = p.Quantity,
                SoldQuantity = p.SoldQuantity,
                RemainingQuantity = p.Quantity - p.SoldQuantity,
                IsLowStock = p.Quantity - p.SoldQuantity <= 10,
            }).ToList();

            return View(inventory);
        }
        [HttpPost]
        public ActionResult UpdateQuantity(int productId, int additionalQuantity)
        {
            var product = db.Products.FirstOrDefault(p => p.Id == productId);

            if (product != null)
            {
                product.Quantity += additionalQuantity; // Cộng thêm số lượng nhập vào
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound("Sản phẩm không tồn tại.");
            }
        }


    }
}
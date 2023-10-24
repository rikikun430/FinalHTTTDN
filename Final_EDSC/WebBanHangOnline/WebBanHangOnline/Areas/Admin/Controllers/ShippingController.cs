using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    public class ShippingController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/Shipping
        public ActionResult Index()
        {
            var orders = db.Orders.Where(o => o.Status != 1 && o.OrderStatus == 0 || o.OrderStatus == 1).ToList();
            return View(orders);
        }
        public ActionResult UpdateOrderStatus(int orderId, int status)
        {
            var order = db.Orders.Find(orderId);
            if (order != null)
            {
                order.OrderStatus = status;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
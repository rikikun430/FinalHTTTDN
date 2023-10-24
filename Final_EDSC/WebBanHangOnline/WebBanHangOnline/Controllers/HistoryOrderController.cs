using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using WebBanHangOnline.Models.ViewModels;

namespace WebBanHangOnline.Controllers
{
    public class HistoryOrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: HistoryOrder
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var orders = db.Orders.Where(o => o.UserId == currentUserId).OrderByDescending(o => o.CreatedDate).ToList();
            return View(orders);
        }
        [Authorize]
        public ActionResult OrderDetails(int id)
        {
            string currentUserId = User.Identity.GetUserId();
            var order = db.Orders.FirstOrDefault(o => o.Id == id && o.UserId == currentUserId);
            if (order == null)
            {
                return HttpNotFound();
            }

            var orderDetails = db.OrderDetails.Include(od => od.Product).Where(od => od.OrderId == id).ToList();
            var viewModel = new OrderDetailsViewModel
            {
                OrderDetails = orderDetails,
                Order = order
            };
            return View(viewModel);
        }
    }
}
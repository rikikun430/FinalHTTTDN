using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    public class OrderHistoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/OrderHistoryController
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId(); // Thêm using Microsoft.AspNet.Identity;
            var orders = db.Orders.Where(o => o.UserId == currentUserId).OrderByDescending(o => o.CreatedDate).ToList();
            return View(orders);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public List<OrderDetail> OrderDetails { get; set; }
        public Order Order { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
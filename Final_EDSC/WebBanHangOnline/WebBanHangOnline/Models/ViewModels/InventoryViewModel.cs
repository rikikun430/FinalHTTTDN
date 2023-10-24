
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.ViewModels
{
    public class InventoryViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int SoldQuantity { get; set; }
        public int RemainingQuantity { get; set; }
        public bool IsLowStock { get; set; }
    }
}
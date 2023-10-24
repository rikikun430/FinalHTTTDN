using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.ViewModels
{
    public class InventoryFilterViewModel
    {
        public int? ProductCategoryId { get; set; }
        public int? MinimumRemaining { get; set; }
    }
}
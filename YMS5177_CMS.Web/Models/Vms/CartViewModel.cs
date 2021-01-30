
using System.Collections.Generic;
using YMS5177_CMS.Web.Models.Dtos;

namespace YMS5177_CMS.Web.Models.Vms
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            CartItems = new List<CartItem>();
        }

        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}

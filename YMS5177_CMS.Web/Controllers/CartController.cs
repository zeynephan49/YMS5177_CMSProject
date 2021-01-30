using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using YMS5177_CMS.Data.Context;
using YMS5177_CMS.Web.Models.Dtos;
using YMS5177_CMS.Web.Models.Extensions;
using YMS5177_CMS.Web.Models.Vms;

namespace YMS5177_CMS.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CartController(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;

        public IActionResult Index()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            CartViewModel cartViewModel = new CartViewModel
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Price * x.Quantity)
            };

            return View(cartViewModel);
        }
    }
}

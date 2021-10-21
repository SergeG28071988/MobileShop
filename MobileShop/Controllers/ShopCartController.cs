using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.ViewModels;
using System.Linq;

namespace MobileShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllMobiles _mobileRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllMobiles mobileRep, ShopCart shopCart)
        {
            _mobileRep = mobileRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _mobileRep.Mobiles.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}

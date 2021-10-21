using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.ViewModels;

namespace MobileShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllMobiles _mobileRep;

        public HomeController(IAllMobiles mobileRep)
        {
            _mobileRep = mobileRep;
        }

        public ViewResult Index()
        {
            var homeMobiles = new HomeViewModel()
            {
                FavMobiles = _mobileRep.GetFavMobiles
            };
            return View(homeMobiles);
        }
    }
}

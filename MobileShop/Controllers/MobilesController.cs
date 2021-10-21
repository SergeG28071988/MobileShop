using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileShop.Controllers
{
    public class MobilesController : Controller
    {
        private readonly IAllMobiles _allMobiles;
        private readonly IMobilesCategory _allCategories;

        public MobilesController(IAllMobiles mobiles, IMobilesCategory category)
        {
            _allMobiles = mobiles;
            _allCategories = category;
        }

        [Route("Mobiles/List")]
        [Route("Mobiles/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Mobile> mobiles = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                mobiles = _allMobiles.Mobiles.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("smartphone", category, StringComparison.OrdinalIgnoreCase))
                {
                    mobiles = _allMobiles.Mobiles.Where(i => i.Category.CategoryName.Equals("Смартфоны")).OrderBy(i => i.Id);
                    currCategory = "Смартфоны";
                }
                else if (string.Equals("tablet", category, StringComparison.OrdinalIgnoreCase))
                {
                    mobiles = _allMobiles.Mobiles.Where(i => i.Category.CategoryName.Equals("Планшеты")).OrderBy(i => i.Id);
                    currCategory = "Планшеты";
                }

                else if (string.Equals("tariffs", category, StringComparison.OrdinalIgnoreCase))
                {
                    mobiles = _allMobiles.Mobiles.Where(i => i.Category.CategoryName.Equals("Тарифы и номера")).OrderBy(i => i.Id);
                    currCategory = "Тарифы и номера";
                }
            }
            var mobileObj = new MobilesListViewModel
            {
                AllMobiles = mobiles,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Страница с мобильными устройствами";

            return View(mobileObj);
        }
    }
}

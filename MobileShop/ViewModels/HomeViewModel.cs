using MobileShop.Data.Models;
using System.Collections.Generic;

namespace MobileShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Mobile> FavMobiles { get; set; }
    }
}

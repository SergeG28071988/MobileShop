using MobileShop.Data.Models;
using System.Collections.Generic;


namespace MobileShop.ViewModels
{
    public class MobilesListViewModel
    {
        public IEnumerable<Mobile> AllMobiles { get; set; }
        public string CurrCategory { get; set; }
    }
}

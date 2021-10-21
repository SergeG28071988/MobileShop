using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Mobile Mobile { get; set; }
        public uint Price { get; set; }
        public string ShopCartId { get; set; }
    }
}

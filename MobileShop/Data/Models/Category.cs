using System.Collections.Generic;

namespace MobileShop.Data.Models
{
    public class Category
    {
        public int Id { set; get; }

        public string CategoryName { set; get; }

        public string Desc { set; get; }

        public List<Mobile> Mobiles { set; get; }
    }
}

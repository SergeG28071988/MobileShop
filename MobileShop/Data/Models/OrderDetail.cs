using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MobileId { get; set; }
        public uint Price { get; set; }
        public virtual Mobile Mobile { get; set; }
        public virtual Order Order { get; set; }
    }
}


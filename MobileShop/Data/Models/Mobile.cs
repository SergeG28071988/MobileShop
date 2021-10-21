using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Data.Models
{
    public class Mobile
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string ShortDesc { set; get; }        

        public string Img { set; get; }

        public uint Price { set; get; }

        public bool IsFawourite { set; get; }

        public bool Awailable { set; get; }

        public int CategoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}

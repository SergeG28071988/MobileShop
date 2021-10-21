using MobileShop.Data.Models;
using System.Collections.Generic;

namespace MobileShop.Data.Interfaces
{
    public interface IAllMobiles
    {
        IEnumerable<Mobile> Mobiles { get; }
        IEnumerable<Mobile> GetFavMobiles { get; }
        Mobile GetObjectMobile(int mobileId); 
    }
}

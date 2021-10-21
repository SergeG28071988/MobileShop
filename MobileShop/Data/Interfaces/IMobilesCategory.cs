using MobileShop.Data.Models;
using System.Collections.Generic;

namespace MobileShop.Data.Interfaces
{
    public interface IMobilesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

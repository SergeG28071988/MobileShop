using System.Collections.Generic;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;

namespace MobileShop.Data.Repository
{
    public class CategoryRepository : IMobilesCategory
    {
        private readonly AppDbContext appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => appDbContext.Category; 
    }
}

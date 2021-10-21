using System.Collections.Generic;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.Data.Repository
{
    public class MobileRepository : IAllMobiles
    {
        private readonly AppDbContext appDbContext;
        public MobileRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Mobile> Mobiles => appDbContext.Mobiles.Include(c => c.Category);

        public IEnumerable<Mobile> GetFavMobiles => appDbContext.Mobiles.Where(p => p.IsFawourite).Include(c => c.Category);

        public Mobile GetObjectMobile(int mobileId) => appDbContext.Mobiles.FirstOrDefault(p => p.Id == mobileId);
        
    }
}

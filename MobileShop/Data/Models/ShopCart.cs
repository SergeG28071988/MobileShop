using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace MobileShop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContext appDbContext;

        public ShopCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var cottext = service.GetRequiredService<AppDbContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(cottext) { ShopCartId = shopCartId };
        }

        public void AddToCart(Mobile mobile)
        {
            appDbContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Mobile = mobile,
                Price = mobile.Price
            });

            appDbContext.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return appDbContext.ShopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.Mobile).ToList();
        }
    }
}

using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileShop.Data.Mocks
{
    public class MockMobiles : IAllMobiles
    {
        private readonly IMobilesCategory _mobilesCategory = new MockCategory();
        public IEnumerable<Mobile> Mobiles
        {
            get
            {
                return new List<Mobile>
                {
                    new Mobile
                    {
                        Name="Смартфон realme C11 2021 2/32GB",
                        ShortDesc ="Хороший смартфон",                        
                        Img ="/img/realme C11.jpg",
                        Price = 11000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = _mobilesCategory.AllCategories.Last()
                    },

                    new Mobile
                    {
                        Name="Планшет Samsung Galaxy Tab A7",
                        ShortDesc ="Самый лучший планшет от компании Samsung",                        
                        Img ="/img/Samsung Galaxy Tab A7.jpg",
                        Price = 17400,
                        IsFawourite = true,
                        Awailable = true,
                        Category = _mobilesCategory.AllCategories.First()
                    },

                    new Mobile
                    {
                        Name="Смартфон Xiaomi POCO M3 4/128GB",
                        ShortDesc ="Самый лучший смартфон на рынке.",                        
                        Img ="/img/Xiaomi POCO M3.jpg",
                        Price = 30000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = _mobilesCategory.AllCategories.First()
                    },

                    new Mobile
                    {
                        Name="Смартфон realme 8 8/128GB RUB",
                        ShortDesc ="Самый лучший смартфон на рынке.",
                        Img ="/img/realme-8-pro-ofic.jpg",
                        Price = 30000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = _mobilesCategory.AllCategories.First()
                    },

                    new Mobile
                    {
                        Name = "Смартфон Xiaomi Redmi 9A 2/32GB RUB",
                        ShortDesc = "Хороший смартфон.",
                        Img = "/img/Xiaomi Redmi 9A.jpg",
                        Price = 8000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = _mobilesCategory.AllCategories.First()
                    },

                    new Mobile
                    {
                        Name = "Смартфон realme 6 Pro 6/128GB RUB",
                        ShortDesc = "Хороший смартфон.",
                        Img = "/img/realme-6-blue-128gb.jpg",
                        Price = 25000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = _mobilesCategory.AllCategories.First()
                    },
                    new Mobile
                    {
                        Name = "Тарифный план Максимум",
                        ShortDesc = "Оставайтесь всегда на связи с тарифами #БезПереплат",
                        Img = "/img/mqdefault.jpg",
                        Price = 300,
                        IsFawourite = true,
                        Awailable = true,
                        Category = _mobilesCategory.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Mobile> GetFavMobiles { get; set; }

        public Mobile GetObjectMobile(int mobileId)
        {
            throw new NotImplementedException();
        }
    }
}

using MobileShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobileShop.Data
{
    public class DbObject
    {
        public static void Initial(AppDbContext context)
        {
            // Проверка

            if(!context.Category.Any())            
                context.Category.AddRange(Categories.Select(c => c.Value));

            if (!context.Mobiles.Any())
            {
                context.AddRange(
                    new Mobile
                    {
                        Name = "Смартфон realme C11 2021 2/32GB",
                        ShortDesc = "Хороший смартфон",
                        Img = "/img/realme C11.jpg",
                        Price = 11000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = Categories["Смартфоны"]
                    },

                    new Mobile
                    {
                        Name = "Планшет Samsung Galaxy Tab A7",
                        ShortDesc = "Самый лучший планшет от компании Samsung",
                        Img = "/img/Samsung Galaxy Tab A7.jpg",
                        Price = 17400,
                        IsFawourite = true,
                        Awailable = true,
                        Category = Categories["Планшеты"]
                    },

                    new Mobile
                    {
                        Name = "Смартфон Xiaomi POCO M3 4/128GB",
                        ShortDesc = "Самый лучший смартфон на рынке.",
                        Img = "/img/Xiaomi POCO M3.jpg",
                        Price = 30000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = Categories["Смартфоны"]
                    },

                    new Mobile
                    {
                        Name = "Смартфон realme 8 8/128GB RUB",
                        ShortDesc = "Самый лучший смартфон на рынке.",
                        Img = "/img/realme-8-pro-ofic.jpg",
                        Price = 30000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = Categories["Смартфоны"]
                    },

                    new Mobile
                    {
                        Name = "Смартфон Xiaomi Redmi 9A 2/32GB RUB",
                        ShortDesc = "Хороший смартфон.",
                        Img = "/img/Xiaomi Redmi 9A.jpg",
                        Price = 8000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = Categories["Смартфоны"]
                    },

                    new Mobile
                    {
                        Name = "Смартфон realme 6 Pro 6/128GB RUB",
                        ShortDesc = "Хороший смартфон.",
                        Img = "/img/realme-6-blue-128gb.jpg",
                        Price = 25000,
                        IsFawourite = true,
                        Awailable = true,
                        Category = Categories["Смартфоны"]
                    },
                    new Mobile
                    {
                        Name = "Тарифный план Максимум",
                        ShortDesc = "Оставайтесь всегда на связи с тарифами #БезПереплат",
                        Img = "/img/mqdefault.jpg",
                        Price = 300,
                        IsFawourite = true,
                        Awailable = true,
                        Category = Categories["Тарифы и номера"]
                    }

                );
            }
            context.SaveChanges();
        }

        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                          new Category { CategoryName ="Смартфоны", Desc="Современный вид мобильных устройств." },
                          new Category { CategoryName ="Планшеты", Desc="Мобильное устройство с сенсорным экраном, позволяющее управлять программами " +
                    "посредством нажатий на дисплей." },
                          new Category { CategoryName ="Тарифы и номера", Desc="Услуги связи." }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }

                return category;
            }
        }
    }
}

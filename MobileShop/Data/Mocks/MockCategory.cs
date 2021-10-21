using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System.Collections.Generic;

namespace MobileShop.Data.Mocks
{
    public class MockCategory : IMobilesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName ="Смартфоны", Desc="Современный вид мобильных устройств." },
                    new Category { CategoryName ="Планшеты", Desc="Мобильное устройство с сенсорным экраном, позволяющее управлять программами " +
                    "посредством нажатий на дисплей." },
                    new Category { CategoryName ="Тарифы и номера", Desc="Услуги связи." }
                };
            }
        }
    }
}

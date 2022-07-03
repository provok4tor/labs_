using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public static class Products
    {
        static string[] _allProducts = new string[]
        {
            //Электроника
            "Телевизор за много денег",
            "Телефон за много денег",
            "Ноутбук за много денег",

            //Сладости
            "Торт с ягодами",
            "Чизкейк с ягодами",
            "Профитроли с ягодами",

            //Бакалея
            "Ликёр 17 градусов",
            "Водка 40 градусов",
            "Джин 8 градусов"
        };

        public static string[] AllProducts { get => _allProducts; }
    }
}

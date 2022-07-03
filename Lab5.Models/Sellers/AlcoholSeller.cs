﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models.Sellers
{
    public class AlcoholSeller : Seller
    {
        public AlcoholSeller (Action<string> Notification, float defaultX, float defaultY, List<Buyer> buyers, object buyersLocker)
          : base(Notification, defaultX, defaultY, buyers, buyersLocker)
        {
            for (int i = 0; i < Products.AllProducts.Length; i++)
                if (Products.AllProducts[i].Contains("градусов"))
                    ProductsIndexes.Add(i);
        }
    }
}

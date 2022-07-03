using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Buyer : PersonModel
    {
        public bool IsBuy { get; internal set; } //Покупает ли покупатель
        public int ProductIndex { get; internal set; } //Что он хочет купить

        public bool WaitSeller { get; internal set; }

        public Buyer(Action<string> Notification, float defaultX, float defaultY)
    : base(Notification, defaultX, defaultY)
        {

        }

        public void RandomProduct(Random random)
        {
            ProductIndex = random.Next(0, Products.AllProducts.Length);
            IsBuy = true;
            WaitSeller = false;
        }


        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                ToX = defaultX;
                ToY = defaultY;
            }
        }
    }
}

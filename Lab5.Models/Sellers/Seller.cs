using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models.Sellers
{
    public abstract class Seller : PersonModel, ISeller
    {
        private readonly List<Buyer> buyers;
        private readonly object buyersLocker;

        Buyer neededBuyer;

        public Seller(Action<string> Notification, float defaultX, float defaultY, List<Buyer> buyers, object buyersLocker)
            : base(Notification, defaultX, defaultY)
        {
            ProductsIndexes = new List<int>();

            this.buyers = buyers;
            this.buyersLocker = buyersLocker;
        }

        public List<int> ProductsIndexes { get; }

        // продажа
        void Sell()
        {
            if (IsCome())
            {
                Notification($"Продавец {LastName} {FirstName} продаёт товар " +
                        $"{neededBuyer.LastName} {neededBuyer.FirstName}");

                Task.Delay(5 * 1000).Wait();

                neededBuyer.IsBuy = false;
                neededBuyer.IsLocked = false;

                Notification($"Покупатель {neededBuyer.LastName} {neededBuyer.FirstName} купил нужный товар");

                DoSomething = null;
                IsLocked = false;

                ToX = defaultX;
                ToY = defaultY;
            }
        }

        protected override void CheckEvents()
        {
            if (IsLocked)
                return;

            lock (buyersLocker)
            {
                neededBuyer = buyers .FirstOrDefault(buyer => buyer.IsBuy && ProductsIndexes.Contains(buyer.ProductIndex) && !buyer.WaitSeller);

                if (neededBuyer != null)
                {
                    neededBuyer.WaitSeller = true;
                    ToX = neededBuyer.X;
                    ToY = neededBuyer.Y;

                    IsLocked = true;
                    DoSomething = Sell;

                    Notification($"Продавец {LastName} {FirstName} отправился для продавжи товара " +
                        $"{neededBuyer.LastName} {neededBuyer.FirstName}");
                }
            }
        }
    }
}

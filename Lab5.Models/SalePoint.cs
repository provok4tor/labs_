using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class SalePoint : Model
    {
        private readonly List<Buyer> buyers;
        private readonly object buyersLocker;

        List<Buyer> participatingBuyers;

        string Name { get; }

        int maxParticipatingBuyersNumber;

        public SalePoint(Action<string> Notification, List<Buyer> buyers, object buyersLockre,
            float x, float y, string name, int maxParticipatingBuyersNumber = 1)
            : base(Notification)
        {
            this.buyers = buyers;
            this.buyersLocker = buyersLockre;
            X = x;
            Y = y;

            participatingBuyers = new List<Buyer>();

            Name = name;

            this.maxParticipatingBuyersNumber = maxParticipatingBuyersNumber;
        }

        bool StartSalePoint()
        {
            participatingBuyers.Clear();

            lock (buyersLocker)
            {
                int participatingBuyersNumber = 0;

                for (int i = 0; i < buyers.Count && participatingBuyersNumber < maxParticipatingBuyersNumber; i++)
                {
                    // если не заблокирован
                    if (!buyers[i].IsLocked)
                    {
                        // назначем куда идти
                        buyers[i].ToX = X;
                        buyers[i].ToY = Y;

                        buyers[i].IsLocked = true;
                        participatingBuyers.Add(buyers[i]);

                        participatingBuyersNumber++;
                    }
                }
            }

            return participatingBuyers.Count != 0;
        }

        void WaitAllBuyers()
        {
            bool allBuyersCame = false; ;

            while (!allBuyersCame)
            {
                Task.Delay(100).Wait();

                lock (buyersLocker)
                {
                    allBuyersCame = participatingBuyers.FirstOrDefault(item =>
                    !item.IsCome()) == null;
                }
            }
        }

        void OpenSalePoint()
        {
            WaitAllBuyers();

            Notification($"Торговая точка {Name} открывается");
            Notification($"Торговая точка {Name} работает");

            Task.Delay(10 * 5000).Wait();
        }

        void WaitSale(List<Buyer> wantBuyBuyers)
        {
            bool allBuy = true;

            do
            {
                Task.Delay(100).Wait();

                allBuy = wantBuyBuyers.Count(buyer => buyer.IsBuy) == 0;

            } while (!allBuy);
        }

        void PrintBuyBuyers(List<Buyer> buyBuyers)
        {
            string message = "";

            foreach (var item in buyBuyers)
            {
                message += $"{item.LastName} {item.FirstName}: {Products.AllProducts[item.ProductIndex]}\r\n";
            }

            Notification(message);
        }


        int getNextBuyer(Random random, int participatingBuyersNumber, List<int> winners)
        {
            int result;

            do
            {
                result = random.Next(0, participatingBuyersNumber);
            }
            while (winners.Contains(result));

            return result;
        }

        void PrintBuyBuyer(int product, Buyer biuyer)
        {
            Notification($"{Products.AllProducts[product]} купил {biuyer.LastName} {biuyer.FirstName}");
        }


        List<int> DetermineBuyers()
        {
            List<int> buyers = new List<int>();

            if (participatingBuyers.Count == 0)
                return buyers;

            Notification($"Покупатели {Name}:");

            Random random = new Random();

            int firstBuyer = getNextBuyer(random, participatingBuyers.Count, buyers);
            buyers.Add(firstBuyer);

            PrintBuyBuyer(participatingBuyers[firstBuyer].ProductIndex, participatingBuyers[firstBuyer]);


            if (participatingBuyers.Count == 1)
                return buyers;

            int secondBuyer = getNextBuyer(random, participatingBuyers.Count, buyers);
            buyers.Add(secondBuyer);

            PrintBuyBuyer(participatingBuyers[secondBuyer].ProductIndex, participatingBuyers[secondBuyer]);

            if (participatingBuyers.Count == 2)
                return buyers;

            int thirdBuyer = getNextBuyer(random, participatingBuyers.Count, buyers);
            buyers.Add(thirdBuyer);

            PrintBuyBuyer(participatingBuyers[thirdBuyer].ProductIndex, participatingBuyers[thirdBuyer]);

            return buyers;
        }



        List<Buyer> DetermineBuyBuyers(List<int> buyers)
        {
            List<Buyer> buyBuyers = new List<Buyer>();

            Random random = new Random();

            for (int i = 0; i < participatingBuyers.Count; i++)
                if (!buyers.Contains(i))
                {
                    participatingBuyers[i].RandomProduct(random);

                    if (participatingBuyers[i].IsBuy)
                        buyBuyers.Add(participatingBuyers[i]);
                    else
                        participatingBuyers[i].IsLocked = false;
                }

            return buyBuyers;
        }

        public void CloseSalePoint()
        {
            Notification($"Торговая точка {Name} закрылась");

            List<int> buyers = DetermineBuyers();

            Notification($"Проходит цеременония награждения соревнования {Name}");

            Task.Delay(5000).Wait();

            Notification($"Церемнония награждения соревнования {Name} закончена");


            foreach (var item in buyers)
            {
                participatingBuyers[item].IsLocked = false;
            }

            Random random = new Random();

            List<Buyer> buyBuyers = DetermineBuyBuyers(buyers);

            if (buyBuyers.Count != 0)
            {
                Notification($"Во время работы торговой точки {Name} покупатели захотели что-то купить\n");

                PrintBuyBuyers(buyBuyers);
                Notification($"Пока все покупателине купят что хотят, торговая точка {Name} не откроется");
                WaitSale(buyBuyers);

                Notification($"Торговая точка {Name}: Все покупатели купили что хотели!");
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                Notification($"Скоро будет открыта торговая точка {Name}");

                Task.Delay(3 * 1000).Wait();

                if (!StartSalePoint())
                {
                    Notification($"Покупатели не пришли на открытие торговой точки {Name}, она закрывается");
                }
                else
                {
                    OpenSalePoint();

                    CloseSalePoint();
                }

                Task.Delay(5 * 5000).Wait();
            }
        }

    }
}

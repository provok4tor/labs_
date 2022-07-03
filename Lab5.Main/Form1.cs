using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputString;
using System.Reflection;
using Lab5.Models;
using Lab5.Models.Sellers;

namespace Lab5.Main
{

    //Торговая точка – смоделировать работу торговой точки.
    //    Реализовать классы – Торговая точка, Покупатель,
    //    интерфейс – служба доставки.
    //    События – покупатель покупает товар, Товар закончился.


    public partial class Form1 : Form
    {
        List<ViewObject> viewObjects;
        object viewObjectsLocker;

        List<ViewModel> viewModels;
        object viewModelsLocker;

        Painter painter;

        ViewObject SellersSpawn, BuyersSpawn;

        // покупатели
        List<Buyer> buyers;
        object buyersLocker;

        List<SalePoint> salePoints;

        int maxSalePoint;

        IEnumerable<Type> sellersTypes;
        List<string> notifications;

        private Bitmap buyerImage,
        sellerImage,
        sellersSpawnImage,
        salePointImage,
        buyersSpawnImage;

        public Form1()
        {
            InitializeComponent();

            InitImages();

            viewObjects = new List<ViewObject>();
            viewObjectsLocker = new object();

            viewModels = new List<ViewModel>();
            viewModelsLocker = new object();

            buyers = new List<Buyer>();
            buyersLocker = new object();

            sellersTypes = Assembly.Load("Lab5.Models").GetTypes()
                .Where(type => !type.IsAbstract && type.GetInterface("ISeller") != null);

            notifications = new List<string>();

            maxSalePoint = (int)(pictureBox.Height / salePointImage.Height);

            salePoints = new List<SalePoint>();
        }

     
        private void InitImages()
        {
            //buyerImage = Properties.Resources.Buyer;
            //sellerImage = Properties.Resources.Seller;
            //sellersSpawnImage = Properties.Resources.SellersSpawn;
            //salePointImage = Properties.Resources.SalePoint;
            //buyersSpawnImage = Properties.Resources.BuyersSpawn;
            buyerImage = new Bitmap(@"../../Resources/Buyer.png");
            sellerImage = new Bitmap(@"../../Resources/Seller.png");
            sellersSpawnImage = new Bitmap(@"../../Resources/SellersSpawn.jpg");
            salePointImage = new Bitmap(@"../../Resources/SalePoint.jpg");
            buyersSpawnImage = new Bitmap(@"../../Resources/BuyersSpawn.jpg");
        }
        

        void Notification(string message)
        {
            notificationTextBox.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);

                if (notifications.Count >= 15)
                {
                    notifications = notifications.GetRange(5, 9);

                    notificationTextBox.Text = "";

                    foreach (var item in notifications)
                    {
                        notificationTextBox.Text += item + "\r\n\r\n";
                    }
                }

                notificationTextBox.Text += message + "\r\n\r\n";
            });
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void InputPersonModel(PersonModel personModel)
        { 
            InputStringDialog inputLastName = new InputStringDialog(new WordValidator(), "Введите Фамилию");

            if (inputLastName.ShowDialog() == DialogResult.OK)
            {
                personModel.LastName = inputLastName.Value;
            }

            InputStringDialog inputFirstName = new InputStringDialog(new WordValidator(), "Введите Имя");

            if (inputFirstName.ShowDialog() == DialogResult.OK)
            {
                personModel.FirstName = inputFirstName.Value;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBuyerToolStripMenuItem.Enabled = true;
            addSellerToolStripMenuItem.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            addPointToolStripMenuItem.Enabled = true;

            painter = new Painter(pictureBox, Color.FromArgb(128, 255, 128),
               new Font(notificationTextBox.Font.FontFamily, 10f, notificationTextBox.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);


            SellersSpawn = new ViewObject(sellersSpawnImage);
            BuyersSpawn = new ViewObject(buyersSpawnImage);

            SetBuildingsSize();

            viewObjects.Add(SellersSpawn);
            viewObjects.Add(BuyersSpawn);

            AddSalePoint("Торговая точка 1");

            GenerateBuyers(8);

            GenerateSellers(4);

            painter.Start();
        }

        private void addBuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buyer newBuyer = new Buyer(Notification, BuyersSpawn.X, BuyersSpawn.Y);

            InputPersonModel(newBuyer);

            lock (buyersLocker)
            {
                buyers.Add(newBuyer);
            }

            lock (viewModels)
            {
                viewModels.Add(new ViewModel(newBuyer, buyerImage));
            }
            Task.Run(newBuyer.Start);
        }

        private void addSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type sellerType = typeof(AlcoholSeller);

            SelectSellerType selectSellerType = new SelectSellerType(sellersTypes);

            if (selectSellerType.ShowDialog() == DialogResult.OK)
            {
                sellerType = selectSellerType.SelectedType;
            }

            Seller doctor = Activator.CreateInstance(sellerType,
                new object[] { (Action<string>)Notification, SellersSpawn.X, SellersSpawn.Y, buyers, buyersLocker }) as Seller;

            InputPersonModel(doctor);

            lock (viewModelsLocker)
            {
                viewModels.Add(new ViewModel(doctor, sellerImage));
            }

            Task.Run(doctor.Start);
        }

        void SetBuildingsSize()
        { 
            SellersSpawn.X = pictureBox.Width - sellersSpawnImage.Width / 2;
            SellersSpawn.Y = sellersSpawnImage.Height / 2;

            BuyersSpawn.X = pictureBox.Width - buyersSpawnImage.Width / 2;
            BuyersSpawn.Y = pictureBox.Height - buyersSpawnImage.Height / 2;
        }

        void GenerateBuyers(int buyersNumber)
        {

            for (int i = 0; i < buyersNumber; i++)
            {
                var newBuyer = new Buyer(Notification, BuyersSpawn.X, BuyersSpawn.Y)
                {
                    LastName = "BuyerTop" + i.ToString(),
                    FirstName = "BuyerNoTop" + i.ToString()
                };

                buyers.Add(newBuyer);

                viewModels.Add(new ViewModel(newBuyer, buyerImage));

                Task.Run(newBuyer.Start);
            }
        }

        void GenerateSellers(int sellersNumber)
        {
            object[] sellerArgs = new object[]
            { (Action<string>)Notification,
                SellersSpawn.X,
                SellersSpawn.Y,
                buyers,
                buyersLocker
            };

            for (int i = 0; i < sellersNumber; i++)
            {
                foreach (var item in sellersTypes)
                {
                    Seller newSeller = Activator.CreateInstance(item, sellerArgs) as Seller;
                    newSeller.LastName = "SellerLast" + i.ToString();
                    newSeller.FirstName = "SellerFirst" + i.ToString();

                    viewModels.Add(new ViewModel(newSeller, sellerImage));

                    Task.Run(newSeller.Start);
                }
            }
        }

        private void addPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputCompettionName = new InputStringDialog(new WordValidator(), "Введите имя соревнования");

            string name = "";

            if (inputCompettionName.ShowDialog() == DialogResult.OK)
                name = inputCompettionName.Value;

            InputStringDialog inputMaxParticipatingBuyersNumber = new InputStringDialog(new NotNegativeIntValidator(),
                "Введите максимальное количество спортсменов на соревновании");

            if (inputMaxParticipatingBuyersNumber.ShowDialog() == DialogResult.OK)
                AddSalePoint(name, Int32.Parse(inputMaxParticipatingBuyersNumber.Value));
            else
                AddSalePoint(name);
        }

        void AddSalePoint(string salePointName, int maxParticipatingBuyersNumber = 1)
        {
            float x = salePointImage.Width / 2,
                y = salePointImage.Height / 2;

            y += salePoints.Count() * salePointImage.Height;

            salePoints.Add(new SalePoint(Notification, buyers, buyersLocker, x, y, salePointName, maxParticipatingBuyersNumber));

            lock (viewObjectsLocker)
            {
                viewObjects.Add(new ViewObject(salePointImage, x, y));
            }

            Task.Run(salePoints[salePoints.Count() - 1].Start);

            if (salePoints.Count() >= maxSalePoint)
                addPointToolStripMenuItem.Enabled = false;
        }
    }




}

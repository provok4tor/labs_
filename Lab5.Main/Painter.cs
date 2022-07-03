﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Lab5.Models;

namespace Lab5.Main
{
    //Отрисовщик
    class Painter
    {
        private readonly PictureBox pictureBox;

        Bitmap bitmap;

        List<ViewObject> viewObjects;
        private readonly object viewObjectsLocker;

        private readonly List<ViewModel> viewModels;
        private readonly object viewModelsLocker;

        private readonly Graphics graphics;
        private readonly Color backgroundColor;
        private readonly Font textFont;

        Timer timer;

        public Painter(PictureBox pictureBox, Color backgroundColor, Font textFont,
            List<ViewObject> viewObjects, object viewObjectsLocker,
            List<ViewModel> viewModels, object viewModelsLocker)
        {
            this.pictureBox = pictureBox;
            this.viewObjects = viewObjects;
            this.viewObjectsLocker = viewObjectsLocker;
            this.viewModels = viewModels;
            this.viewModelsLocker = viewModelsLocker;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            this.backgroundColor = backgroundColor;
            this.textFont = textFont;

            timer = new Timer();
            timer.Interval = 30;

            timer.Tick += new EventHandler((obj, e) =>
            {
                graphics.Clear(backgroundColor);

                lock (viewObjectsLocker)
                {
                    foreach (var item in viewObjects)
                    {
                        Draw(item);
                    }
                }

                lock (viewModelsLocker)
                {
                    foreach (var item in viewModels)
                    {
                        Draw(item);
                    }
                }

                pictureBox.Image = bitmap;
            });
        }

        void Draw(ViewObject viewObject)
        {
            graphics.DrawImage(viewObject.Image,
                viewObject.X - viewObject.Image.Width / 2, viewObject.Y - viewObject.Image.Height / 2);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}

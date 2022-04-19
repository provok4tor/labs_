using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Lab_
{
    public partial class SquareWork : Form
    {
        private Square sqr;

        public SquareWork(Square square)
        {
            InitializeComponent();
            sqr = square;
        }

        private void SquareWork_Load(object sender, EventArgs e)
        {
            Update();
        }

        /// <summary>
        /// Обновляет форму
        /// </summary>
        private void Update()
        {
            Colour.Text = sqr.colour;
            Point smd = sqr.semidiag.ConvertToVector();

            X1.Text = (sqr.center.X + smd.X).ToString();
            Y1.Text = (sqr.center.Y + smd.Y).ToString();

            X2.Text = (sqr.center.X - smd.X).ToString();
            Y2.Text = (sqr.center.Y - smd.Y).ToString();

            X3.Text = (sqr.center.X + smd.X).ToString();
            Y3.Text = (sqr.center.Y - smd.Y).ToString();

            X4.Text = (sqr.center.X - smd.X).ToString();
            Y4.Text = (sqr.center.Y + smd.Y).ToString();

            MessageBox.Show("Форма обновлена!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dec = sqr.Decrease();
            MessageBox.Show("Квадрат уменьшился в " + dec.ToString() + " раз");
            Update();
        }

        private void SetScale_Click(object sender, EventArgs e)
        {
            int sq = sqr.SetDimension();
            MessageBox.Show("Полудиагональ квадрата установлена как " + sq.ToString());
            Update();
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            int inc = sqr.Increase();
            MessageBox.Show("Квадрат Увеличился в " + inc.ToString() + " раз");
            Update();
        }

        private void Turn_Click(object sender, EventArgs e)
        {
            int angle = sqr.Turn();
            MessageBox.Show("Квадрат повернулся на " + angle.ToString() + " градусов");
            Update();
        }

        private void SetColour_Click(object sender, EventArgs e)
        {
            Colour clr = new Colour();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                sqr.colour = clr.GetColour();
                MessageBox.Show("Цвет изменён на " + sqr.colour);
                Update();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometrySquare;

namespace Lab1MAIN
{
    public partial class SquareWork : Form
    {

        private Square sqr;
        public SquareWork(Square square)
        {
            InitializeComponent();
            sqr = square;
            UpdateForm();
        }

        private void SquareWork_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        /// <summary>
        /// Обновляет форму
        /// </summary>
        private void UpdateForm()
        {
            Colour.Text = sqr.colour;
            Point smd = sqr.semidiag.ConvertToVector();

            X1.Text = (sqr.center.X + smd.X).ToString();
            Y1.Text = (sqr.center.Y + smd.Y).ToString();

            X2.Text = (sqr.center.X - smd.X).ToString();
            Y2.Text = (sqr.center.Y - smd.Y).ToString();

            X3.Text = (sqr.center.X + smd.Y).ToString();
            Y3.Text = (sqr.center.Y - smd.X).ToString();

            X4.Text = (sqr.center.X - smd.Y).ToString();
            Y4.Text = (sqr.center.Y + smd.X).ToString();

            MessageBox.Show("Форма обновлена!");
        }

        private void SetColour_Click(object sender, EventArgs e)
        {
            Colour clr = new Colour();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                sqr.colour = clr.GetColour();
                MessageBox.Show("Цвет изменён на " + sqr.colour);
                UpdateForm();
            }
        }

        private void Turn_Click(object sender, EventArgs e)
        {
            int angle = sqr.Turn();
            MessageBox.Show("Квадрат повернулся на " + angle.ToString() + " градусов");
            UpdateForm();
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            int dec = sqr.Decrease();
            MessageBox.Show("Квадрат уменьшился в " + dec.ToString() + " раз");
            UpdateForm();
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            int inc = sqr.Increase();
            MessageBox.Show("Квадрат Увеличился в " + inc.ToString() + " раз");
            UpdateForm();
        }

        private void SetScale_Click(object sender, EventArgs e)
        {
            int sq = sqr.SetDimension();
            MessageBox.Show("Полудиагональ квадрата установлена как " + sq.ToString());
            UpdateForm();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Colour_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

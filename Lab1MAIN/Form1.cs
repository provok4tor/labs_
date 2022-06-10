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
    public partial class CreateSquare : Form
    {
        public CreateSquare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string colour = ColourTXT.Text;
            Point center = new Point(Convert.ToDouble(CenterX.Text), Convert.ToDouble(CenterY.Text));
            Point vertex = new Point(Convert.ToDouble(VertexX.Text), Convert.ToDouble(VertexY.Text));
            Segment semidiag = new Segment(center, vertex);

            Square square = new Square(colour, center, semidiag);
            SquareWork form = new SquareWork(square);
            this.Hide();
            form.ShowDialog();
        }
    }
}

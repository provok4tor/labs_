using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Lab_
{
    public partial class InputForm : Form
    {
        Ship ship;
        public InputForm()
        {
            InitializeComponent();


        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void read()
        {
            string name = NameBox.Text;
            int capacity = Int32.Parse(CapacityBox.Text);
            int duration = Int32.Parse(DurationBox.Text);
            int delivers = Int32.Parse(DeliverBox.Text);

            ship = new Tanker(name, duration, capacity, delivers);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            read();
            Form1 f = this.Owner as Form1;
            f.add(ship);
            this.Close();
        }
    }
}

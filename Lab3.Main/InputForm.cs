using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Models;

namespace Lab3.Main
{
    public partial class InputForm : Form
    {
        public Tanker ship { get; private set; } 
        public InputForm()
        {
            InitializeComponent();
            NameBox.Text = "0";
            CapacityBox.Text = "0";
            DurationBox.Text = "0";
            DeliverBox.Text = "0";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ship = new Tanker();
            read();
            Form1 f = this.Owner as Form1;
            f.add(ship);
            this.Close();
        }

        private void read()
        {
            ship.Name = NameBox.Text;
            ship.Load_capacity = Int32.Parse(CapacityBox.Text);
            ship.Duration = Int32.Parse(DurationBox.Text);
            ship.Deliveries = Int32.Parse(DeliverBox.Text);
            ship.set_barrels();
        }
    }
}

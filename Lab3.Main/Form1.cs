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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int count = 0;
        List<Ship> list = new List<Ship>();
        void Print()
        {
            listBox1.Items.Clear();
            foreach (Ship d in list)
            {
                listBox1.Items.Add(d.get_name());
            }
        }

        public void add(Ship ship)
        {
            list.Add(ship);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            InputForm f2 = new InputForm();
            f2.Owner = this;
            f2.ShowDialog();
            Print();
            count++;
            Delete.Enabled = true;
        }

        private void Deliver_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                list[listBox1.SelectedIndex].deliver();
                MessageBox.Show("Доставка кораблём " + list[listBox1.SelectedIndex].get_name() + " выполнена успешно");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                list.RemoveAt(listBox1.SelectedIndex);
                Print();
                count--;
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                MessageBox.Show(list[listBox1.SelectedIndex].get_info());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                Deliver.Enabled = false;
                Data.Enabled = false;
            }
            else
            {
                Deliver.Enabled = true;
                Data.Enabled = true;
            }
        }
    }
}

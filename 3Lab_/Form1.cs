using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
3 Лаба Для интерфейса необходимо определить 1 свойство и 2 метода. 
    Абстрактный класс должен содержать 3-5 свойств и 3-5 методов
    (включая унаследованные свойства интерфейса).
    Класс должен содержать дополнительно 2 свойства и 2 метода.
    В программе реализовать работу со списком объектов,
    который должен содержать объекты типа интерфейса.

interface Корабль -> abstract class Грузовой Корабль-> class Танкер.
*/

namespace _3Lab_
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
                listBox1.Items.Add(d.name);
            }

        }

        public void add(Ship ship)
        {
            list.Add(ship);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                Delete.Enabled = false;
                Deliver.Enabled = false;
                Data.Enabled = false;
            }
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

        private void Delete_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                list.RemoveAt(listBox1.SelectedIndex);
                Print();
                count--;
            }
        }

        private void Deliver_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                list[listBox1.SelectedIndex].deliver();
                MessageBox.Show("Доставка кораблём " + list[listBox1.SelectedIndex].name + " выполнена успешно");
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

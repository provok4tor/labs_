using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Exam[] array = new Exam[20];
        Exam_result[] array_result = new Exam_result[20];
        int count = 0;
        int count_result = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void show_q_Click_1(object sender, EventArgs e)
        {
            int cur = dataGridView1.CurrentCell.RowIndex;
            if (cur < count_result)
                MessageBox.Show(Convert.ToString(array_result[cur].Q()));
        }

        private void Show_Click_1(object sender, EventArgs e)
        {
            int cur = dataGridView1.CurrentCell.RowIndex;
            if (cur < count_result)
                MessageBox.Show(array_result[cur].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 20)
            {
                MessageBox.Show("Массив переполнен");
            }
            else
            {
                AddFirstClass trd = new AddFirstClass();
                if (trd.ShowDialog() == DialogResult.OK)
                {
                    Exam ex = trd.GetExam();
                    array[count] = ex;
                    dataGridView2.Rows.Add(ex.discipline, ex.visitors, ex.time);
                    count++;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int cur = dataGridView2.CurrentCell.RowIndex;
            if (cur < count)
                MessageBox.Show(Convert.ToString(array[cur].Q()));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int cur = dataGridView2.CurrentCell.RowIndex;
            if (cur < count)
                MessageBox.Show(array[cur].ToString());
        }

        private void add_exam_Click_1(object sender, EventArgs e)
        {
            if (count_result > 20)
            {
                MessageBox.Show("Массив переполнен");
            }
            else
            {
                AddSecondClass sec = new AddSecondClass();
                if (sec.ShowDialog() == DialogResult.OK)
                {
                    Exam_result ex = sec.GetExam();
                    array_result[count_result] = ex;
                    dataGridView1.Rows.Add(ex.discipline, ex.visitors, ex.time, ex.percent);
                    count_result++;
                }
            }
        }

    }
}

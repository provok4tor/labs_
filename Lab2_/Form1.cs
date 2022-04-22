using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_
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

        private void add_exam_Click(object sender, EventArgs e)
        {
            if (count_result > 20)
            {
                MessageBox.Show("Массив переполнен");
            }
            else
            {
                Second sec = new Second();
                if (sec.ShowDialog() == DialogResult.OK)
                {
                    Exam_result ex = sec.GetExam();
                    array_result[count_result] = ex;
                    dataGridView1.Rows.Add(ex.discipline, ex.visitors, ex.time, ex.percent);
                    count_result++;
                }
            }
        }

        private void show_q_Click(object sender, EventArgs e)
        {
            int cur = dataGridView1.CurrentCell.RowIndex;
            if (cur < count_result)
                MessageBox.Show(Convert.ToString(array_result[cur].Q()));
        }

        private void Show_Click(object sender, EventArgs e)
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
                Third trd = new Third();
                if (trd.ShowDialog() == DialogResult.OK)
                {
                    Exam ex = trd.GetExam();
                    array[count] = ex;
                    dataGridView2.Rows.Add(ex.discipline, ex.visitors, ex.time);
                    count++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cur = dataGridView2.CurrentCell.RowIndex;
            if (cur < count)
                MessageBox.Show(Convert.ToString(array[cur].Q()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cur = dataGridView2.CurrentCell.RowIndex;
            if (cur < count)
                MessageBox.Show(array[cur].ToString());
        }
    }
}

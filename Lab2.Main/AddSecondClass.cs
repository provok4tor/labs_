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
    public partial class AddSecondClass : Form
    {
        public AddSecondClass()
        {
            InitializeComponent();
            DiscipText.Text = "0";
            StudentText.Text = "0";
            TimeText.Text = "0";
            TwoText.Text = "0";
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Exam_result GetExam()
        {
            Exam_result nex = new Exam_result();
            nex.set(DiscipText.Text, Convert.ToInt32(StudentText.Text), Convert.ToDouble(TimeText.Text), Convert.ToDouble(TwoText.Text));
            return nex;
        }
    }
}

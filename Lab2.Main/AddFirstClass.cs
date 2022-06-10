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
    public partial class AddFirstClass : Form
    {
        public AddFirstClass()
        {
            InitializeComponent();
            DiscipText.Text = "0";
            StudentText.Text = "0";
            TimeText.Text = "0";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public Exam GetExam()
        {
            Exam nex = new Exam();
            nex.set(DiscipText.Text, Convert.ToInt32(StudentText.Text), Convert.ToDouble(TimeText.Text));
            return nex;
        }
    }
}

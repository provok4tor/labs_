﻿using System;
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
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

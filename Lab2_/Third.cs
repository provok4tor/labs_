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
    public partial class Third : Form
    {
        public Third()
        {
            InitializeComponent();
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

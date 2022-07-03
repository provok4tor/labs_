using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Main
{
    public partial class SelectSellerType : Form
    {
        private readonly IEnumerable<Type> sellerTypes;

        public Type SelectedType { get; private set; }

        public SelectSellerType(IEnumerable<Type> sellerTypes)
        {
            InitializeComponent();

            this.sellerTypes = sellerTypes;

            SelectedType = null;
        }

        private void selectsellerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = sellerTypes.First(type => type.Name == selectSellerComboBox.SelectedItem.ToString());
            agreeButton.Enabled = true;
        }

        private void SelectsellerType_Load(object sender, EventArgs e)
        {
            selectSellerComboBox.Items.AddRange(sellerTypes.Select(type => type.Name).ToArray());
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            if (SelectedType == null)
                MessageBox.Show("Вы не выбрали тип продавца");
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}

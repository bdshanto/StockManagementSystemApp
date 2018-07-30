using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategorySetupUi categorySetupUi = new CategorySetupUi();
            categorySetupUi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompayUi compayUi = new CompayUi();
            compayUi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemUi itemUi = new ItemUi();
            itemUi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockInUi stockInUi = new StockInUi();
            stockInUi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StockOutUi stockOutUi = new StockOutUi();
            stockOutUi.Show();
        }
    }
}

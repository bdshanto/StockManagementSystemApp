using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.UI;
using StockManagementSystemApp.UI.Stock;

namespace StockManagementSystemApp.VM
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryUi categorySetupUi = new CategoryUi();
            categorySetupUi.Show();
        }

        private void companyButton_Click(object sender, EventArgs e)
        {

            CompayUi compayUi = new CompayUi();
            compayUi.Show();
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            ItemUi itemUi = new ItemUi();
            itemUi.Show();
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInUi stockInUi = new StockInUi();
            stockInUi.Show();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            StockOutUi stockOutUi = new StockOutUi();
            stockOutUi.Show();
        }

        private void searchViewButton_Click(object sender, EventArgs e)
        {
            SearchAndViewItemSummaryUi SearchAndViewItemSummaryUi=new SearchAndViewItemSummaryUi();
            SearchAndViewItemSummaryUi.Show();
        }

        private void viewSalesButton_Click(object sender, EventArgs e)
        {
            ViewSalesBetweenTwoDatesUi ViewSalesBetweenTwoDatesUi=new ViewSalesBetweenTwoDatesUi();
            ViewSalesBetweenTwoDatesUi.Show();
        }
    }
}

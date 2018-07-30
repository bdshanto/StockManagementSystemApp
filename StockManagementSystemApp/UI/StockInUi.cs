using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using StockManagementSystemApp.Models;
using StockManagementSystemApp.BLL;

namespace StockManagementSystemApp
{
    public partial class StockInUi : Form
    {
        
        StocksIn _stockIn = new StocksIn();
        StockInManager _stockInManager = new StockInManager();
        public StockInUi()
        {
            InitializeComponent();
            LoadCompanyDropDown();
        }
        private void LoadCompanyDropDown()
        {
            DataTable dt = _stockInManager.LoadCompanyDropDown(_stockIn);
            companyBindingSource.DataSource = dt;
        }
        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(companyComboBox.SelectedValue);
            DataTable dt = _stockInManager.LoadCategories(id);
            itemBindingSource.DataSource = dt;
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id1 = Convert.ToInt64(itemComboBox.SelectedValue);
            if (id1 >= 0)
            {
                long ReorderLevl = _stockInManager.ReorederLevel(id1);
                reOrderLevelLabel.Text = ReorderLevl.ToString();
            }

            if (id1 >= 0)
            {

                long ReorderLevl = _stockInManager.availableQuantituLabel(id1);
                reOrderLevelLabel.Text = ReorderLevl.ToString();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (stockQuantityTextBox.Text == "")
            {
                msgLabel.Text = "Enter a Company";
                msgLabel.ForeColor = Color.Red;
                return;
            }
            _stockIn.ItemId = Convert.ToInt64(itemComboBox.SelectedValue);
            _stockIn.StockIn = Convert.ToInt64(stockQuantityTextBox.Text);

            long availableQuantity = Convert.ToInt64(availableQuantituLabel.Text) + _stockIn.StockIn;
            bool isAdded = _stockInManager.Add(_stockIn, availableQuantity);
            if (isAdded)
            {
                msgLabel.Text = $"Save stock Quantity: {stockQuantityTextBox.Text} successfully";
            }
        }
    }
}
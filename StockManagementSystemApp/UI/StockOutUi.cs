using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.BLL;
using StockManagementSystemApp.Models;
using StockManagementSystemApp.VM;

namespace StockManagementSystemApp
{
    public partial class StockOutUi : Form
    {
        StockInManager _stockInManager = new StockInManager();
        StockOutManager _stockOutManager = new StockOutManager();
        StocksIn _stocksIn = new StocksIn();

        List<StockOut> _stockOuts = new List<StockOut>();
        public StockOutUi()
        {
            InitializeComponent();
            LoadCompanyDropDown();
        }
        private void stockOutGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            stockOutGridView.Rows[e.RowIndex].Cells["id"].Value = e.RowIndex + 1;
        }

        private void LoadCompanyDropDown()
        {
            DataTable dt = _stockInManager.LoadCompanyDropDown(_stocksIn);
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

                long availableQuantity = _stockInManager.availableQuantituLabel(id1);
                availableQuantituLabel.Text = availableQuantity.ToString();
            }
        }
        List<StockOutVM> _stockOutVms = new List<StockOutVM>();
        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (stockQuantityTextBox.Text == "")
            {
                msgLabel.Text = "Enter a stock unit";
                msgLabel.ForeColor = Color.Red;
                return;
            }
            StockOut stockOut = new StockOut();
            StockOutVM stockOutVm = new StockOutVM();
            //database
            stockOut.Item = Convert.ToInt64(itemComboBox.SelectedValue);
            stockOut.Company = Convert.ToInt64(companyComboBox.SelectedValue);
            stockOut.Quantity = Convert.ToInt64(stockQuantityTextBox.Text);
            stockOut.AvailableItems = Convert.ToInt64(availableQuantituLabel.Text);
            _stockOuts.Add(stockOut);
            //grid only
            stockOutVm.Item = itemComboBox.Text;
            stockOutVm.Company = companyComboBox.Text;
            stockOutVm.StockIn = Convert.ToInt64(stockQuantityTextBox.Text);
            _stockOutVms.Add(stockOutVm);
            stockOutGridView.DataSource = null;
            stockOutGridView.DataSource = _stockOutVms;
        }

        private void stockOutGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
            foreach (StockOut stock in _stockOuts)
            {
                if (_stockOuts.Count > 0)
                {
                    long availableQuantity = stock.AvailableItems - stock.Item;
                    SqlConnection con = new SqlConnection(_conString);
                    string query = @"Insert into Stocks Values((select Id from Items where Id='" + stock.Item +
                                   "' and CompanyId = '" + stock.Company + "'),'" + availableQuantity + "')";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    bool rowAffect = com.ExecuteNonQuery() > 0;
                    con.Close();
                    

                }

            }


        }
    }
}

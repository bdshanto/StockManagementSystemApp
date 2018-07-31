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
                long ReorderLevl = _stockInManager.availableQuantituLabel(id1);
                reOrderLevelLabel.Text = ReorderLevl.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (stockQuantityTextBox.Text == "")
            {
                msgLabel.Text = "Enter a stock unit";
                msgLabel.ForeColor = Color.Red;
                return;
            }
            StockOut stockOut = new StockOut();

            stockOut.Item = Convert.ToInt64(itemComboBox.SelectedValue);
            stockOut.Company = Convert.ToInt64(companyComboBox.SelectedValue);
            stockOut.Quantity = Convert.ToInt64(stockQuantityTextBox.Text);

           
            _stockOuts.Add(stockOut);


            
           // DataTable dt = _stockInManager.GridUpdate();
            stockOutGridView.DataSource = null;
            stockOutGridView.DataSource = _stockOuts; 
        }

       

        private void stockOutGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }


        /*private bool Add()
        {
            long stock = Convert.ToInt64(availableQuantituLabel.Text) - _stocks.StockIn;
            SqlConnection con = new SqlConnection(_conString);
            string query = @"insert into Stocks values('" + _stocks.ItemId + "','" + stock + "')";
            // string query = "update stocks set StockIn='"+stock+ "'where ItemId='"+_stocks.ItemId+"'";
            //string query = "update stocks set StockIn='"+stock+ "'where ItemId='"+_stocks.ItemId+"'";

            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }*/
    }
}

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
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp
{
    public partial class StockInUi : Form
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
        Stocks _stocks = new Stocks();
        public StockInUi()
        {
            InitializeComponent();
            LoadCompanyDropDown();

        }
        private void LoadCompanyDropDown()
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = "SELECT * FROM Companies";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            companyBindingSource.DataSource = dt;
            con.Close();
        }
        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(companyComboBox.SelectedValue);
            SqlConnection con = new SqlConnection(_conString);
            string query = "select i.Id, i.Name from Items i join Companies c on i.CompanyId=c.Id where c.Id='" + id + "'";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            itemBindingSource.DataSource = dt;
            con.Close();

        }
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(_conString);
                long id1 = Convert.ToInt64(itemComboBox.SelectedValue);

                string query = "select ReOrderLevel from Items where Id='" + id1 + "'";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    Item item = new Item();
                    if (dr.Read())
                    {
                        item.ReOrderLevel = Convert.ToInt32(dr["ReOrderLevel"].ToString());
                    }
                    reOrderLevelLabel.Text = item.ReOrderLevel.ToString();
                }
                con.Close();
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
            _stocks.ItemId =Convert.ToInt64(itemComboBox.SelectedValue);
            _stocks.StockIn = Convert.ToInt64(stockQuantityTextBox.Text);

            bool isAdded = Add();
            if (isAdded)
            {
                msgLabel.Text = $"Save stock Quantity: {stockQuantityTextBox.Text} successfully";
            }


        }
        private bool Add()
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"insert into Stock values('" + _stocks.ItemId + "','" + _stocks.StockIn + "')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }
    }
}
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
    public partial class ItemUi : Form
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
        public ItemUi()
        {
            InitializeComponent();
            GetLoad();
            LoadCompany();
        }

        private void LoadCompany()
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
        private void GetLoad()
        {
             
            
            SqlConnection con = new SqlConnection(_conString);
            string query = "SELECT * FROM Categories";
            SqlCommand com = new SqlCommand(query,con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            categoryBindingSource.DataSource = dt;


            con.Close();
        }
        Item item = new Item();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (itemTextBox.Text == ""&& reOrderTextBox.Text=="")
                {
                    msgLabel.Text = "Enter a Item";
                    msgLabel.ForeColor = Color.Red;
                    return;
                    }

                item.CategoryId = Convert.ToInt64(categoryComboBox.SelectedValue);
                item.CompanyId = Convert.ToInt64(companyComboBox.SelectedValue);
                item.Name = itemTextBox.Text;
                item.ReOrderLevel = Convert.ToInt32(reOrderTextBox.Text);

                bool isExist = IsDuplicateData();
                if (isExist)
                {
                    msgLabel.Text = $"Company {itemTextBox.Text} already in system";
                    msgLabel.ForeColor = Color.Red;
                 
                    return;
                }


                bool isAdded = Add();
                if (isAdded)
                {

                    msgLabel.Text = $"Save Item: {itemTextBox.Text} successfully";
                  
                    
                }
            }
            catch (Exception exception)
            {
                msgLabel.Text = exception.Message;
            }
        }
        private bool IsDuplicateData()
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"select * from Companies where Name= '" + item.Name + "'";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                return true;

            }
            con.Close();
            return false;


        }

        private bool Add()
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"INSERT INTO Items Values('"+item.CategoryId+"','"+item.CompanyId+"','" + item.Name + "','"+item.ReOrderLevel+"')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }
    }
}

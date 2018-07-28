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
    public partial class CategorySetupUi : Form
             
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
        
        public CategorySetupUi()
        {
            InitializeComponent();
            GetData();

        }
        Category category = new Category();
        private void SaveButton_Click(object sender, EventArgs e)
        {


            try
            {
                
                if (nameTextBox.Text == "")
                { 
                    nameLlabel.Text = "Enter a category";
                    nameLlabel.ForeColor = Color.Red;
                    return; 
                }
                category.Name = nameTextBox.Text.Trim();
               
                bool isExist = IsDuplicateData();
                if (isExist)
                { 
                    nameLlabel.Text = $"Catagory {nameTextBox.Text} already in system";
                    nameLlabel.ForeColor = Color.Red;
                    nameTextBox.Clear();
                    return;
                } 


                bool isAdded = Add();
                if (isAdded)
                {

                    nameLlabel.Text = $"Save category: {nameTextBox.Text} successfully";
                    GetData();
                    nameTextBox.Clear();
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

        }

        private void GetData()
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"select * from Categories";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);

            categoryBindingSource.DataSource = dt;

            categoryGetDataGridView.DataSource = categoryBindingSource;
            con.Close();
            

        }

        private bool IsDuplicateData()
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"select * from Categories where Name= '" + category.Name + "'";
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
            string query = @"INSERT INTO Categories Values('" + category.Name + "')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }

        private void categoryGetDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            categoryGetDataGridView.Rows[e.RowIndex].Cells["SL"].Value = e.RowIndex + 1;
        }

        
    }
}

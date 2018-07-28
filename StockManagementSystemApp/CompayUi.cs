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
    public partial class CompayUi : Form
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
        public CompayUi()
        {
            InitializeComponent();
            GetData();
        }
        Company company = new Company();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (nameTextBox.Text == "")
                {
                    nameLlabel.Text = "Enter a Company";
                    nameLlabel.ForeColor = Color.Red;
                    return;
                }
                company.Name = nameTextBox.Text.Trim();

                bool isExist = IsDuplicateData();
                if (isExist)
                {
                    nameLlabel.Text = $"Company {nameTextBox.Text} already in system";
                    nameLlabel.ForeColor = Color.Red;
                    nameTextBox.Clear();
                    return;
                }


                bool isAdded = Add();
                if (isAdded)
                {

                    nameLlabel.Text = $"Save company: {nameTextBox.Text} successfully";
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
            string query = @"SELECT * from Companies";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            companyBindingSource.DataSource = dt;
            companyGetDataGridView.DataSource = companyBindingSource.DataSource;
            con.Close();


        }

        private bool IsDuplicateData()
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"select * from Companies where Name= '" + company.Name + "'";
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
            string query = @"INSERT INTO Companies Values('" + company.Name + "')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.DAL
{
    class CategorieGetway
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
       

        public DataTable GetData(Category category)
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"select * from Categories";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            con.Close();
            return dt;
            
           
        }

        public bool IsDuplicateData(Category _category)
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"select * from Categories where Name= '" + _category.Name + "'";
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

        public bool Add(Category _category)
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"INSERT INTO Categories Values('" + _category.Name + "')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }
    }
}

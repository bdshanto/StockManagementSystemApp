using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Models
{
    class ItemGetway
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
        public bool IsDuplicateData(Item _item)
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"select * from Items where CategoryId='" + _item.CategoryId + "'and CompanyId='" + _item.CompanyId + "'and Name= '" + _item.Name + "'";
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
        public bool Add(Item _item)
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = @"INSERT INTO Items Values('" + _item.CategoryId + "','" + _item.CompanyId + "','" + _item.Name + "','" + _item.ReOrderLevel + "')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }
    }
}

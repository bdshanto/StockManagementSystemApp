using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.DAL
{
    class StockInGetway
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";
        public DataTable LoadCompanyDropDown(StocksIn stocks)
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = "SELECT * FROM Companies";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable LoadCategories(long id)
        {
            SqlConnection con = new SqlConnection(_conString);
            string query = "select* from Items i join Companies c on i.CompanyId=c.Id where c.Id='" + id + "'";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public long ReorderLevel(long id1)
        {

            SqlConnection con = new SqlConnection(_conString);
            string query = "select ReOrderLevel from Items where Id='" + id1 + "'";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                Item item = new Item();
                if (dr.Read())
                {
                    item.ReOrderLevel = Convert.ToInt64(dr["ReOrderLevel"].ToString());
                }

                return item.ReOrderLevel;

            }
            con.Close();
            return 0;
        }
        public bool Add(StocksIn stockIn, long availableQuantity)
        {
          
            SqlConnection con = new SqlConnection(_conString);
            string query = @"insert into Stocks values('" + stockIn.ItemId + "','" + availableQuantity + "')";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            bool rowAffect = com.ExecuteNonQuery() > 0;
            con.Close();
            return rowAffect;
        }


        public long availableQuantituLabel(long id1)
        {
            SqlConnection con = new SqlConnection(_conString);
            // string query = @"select StockIn from Stocks  where Id=( select max (Id) from Stocks) and ItemId='" +id1+ "'";
             string query = @"select StockIn from Stocks  where ItemId='"+id1+"' and Id=(select max (Id)from Stocks where ItemId='"+id1+"');";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                StocksIn stocksIn = new StocksIn();
                if (dr.Read())
                {
                    stocksIn.StockIn = Convert.ToInt64(dr["StockIn"].ToString()); 
                }

                return stocksIn.StockIn;
            }
            con.Close();
            return 0;
        }

      
    }
}

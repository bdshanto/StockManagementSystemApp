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
    class ViewByTimeGetway
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";

        public DataTable ViewbyTime(ViewByTime viewByTime)
        {
            SqlConnection con = new SqlConnection(_conString);
           // string query = @"SELECT (select Name from Items i where i.Id=s.ItemId ) Name, Sell SaleQuantity FROM SummaryStock s WHERE CreateDate BETWEEN '" + viewByTime.FromDate+"' and '"+viewByTime.ToDate+"'";
            string query = @" SELECT (select Name from Items i where i.Id=s.ItemId ) ItemName, Sell SaleQuantity FROM SummaryStock s WHERE s.CreateDate>= '" + viewByTime.FromDate + "' and s.CreateDate<='" + viewByTime.ToDate + "'";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}

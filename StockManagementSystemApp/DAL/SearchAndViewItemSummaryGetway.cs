using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;
using StockManagementSystemApp.VM;

namespace StockManagementSystemApp.DAL
{
    class SearchAndViewItemSummaryGetway
    {
        string _conString = @"Server=.\SQLEXPRESS;Database=SMSDb;Integrated Security=True";

        public DataTable SearchViewInGrid(SearchAndViewItemSummary searchAndViewItemSummary)
        { 
            SqlConnection con = new SqlConnection(_conString);
           string query = @"SELECT it.Name ItemName, co.Name CompanyName, ct.Name CategoryName, iv.StockIn Quantity, it.ReOrderLevel Reorder FROM Items it LEFT OUTER JOIN Companies co  ON it.CompanyId = co.Id LEFT OUTER JOIN Categories ct ON it.CategoryId = ct.Id LEFT OUTER JOIN Stocks iv ON it.Id = iv.ItemId WHERE co.Id = '"+searchAndViewItemSummary.CompanyId+"' AND ct.Id = '" + searchAndViewItemSummary.CategoryId+"'";
           // string query = @"select  Name ItemName, (Select Name from Companies where Id='" + searchAndViewItemSummary.CompanyId + "') companyName, (Select Name from Categories where Id='" + searchAndViewItemSummary.CategoryId + "') CategoriesName,s.StockIn,i.ReOrderLevel  from Items i join Stocks s on i.Id=s.ItemId;";
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.DAL;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.BLL
{
    class SearchAndViewItemSummaryManager
    {
        SearchAndViewItemSummaryGetway _andViewItemSummaryGetway = new SearchAndViewItemSummaryGetway();
        public DataTable SearchViewInGrid(SearchAndViewItemSummary searchAndViewItemSummary)
        {
            return _andViewItemSummaryGetway.SearchViewInGrid(searchAndViewItemSummary);

        }
    }
}

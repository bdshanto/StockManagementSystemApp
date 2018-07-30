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
    class StockInManager
    {
        StockInGetway _stockInGetway= new StockInGetway();
        public DataTable LoadCompanyDropDown(StocksIn stocks)
        {
            return _stockInGetway.LoadCompanyDropDown(stocks);
        }

        public DataTable LoadCategories(long id)
        {
            return _stockInGetway.LoadCategories(id);
        }

        public bool Add(StocksIn stockIn, long availableQuantity)
        {
            return _stockInGetway.Add(stockIn, availableQuantity);
        }

        public long ReorederLevel(long id1)
        {
            return _stockInGetway.ReorderLevel(id1);
        }

        public long availableQuantituLabel(long id1)
        {
            return _stockInGetway.availableQuantituLabel(id1);
        }
    }
}

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
    class ViewByTimeManager
    {
        ViewByTimeGetway _viewByTimeGetway = new ViewByTimeGetway();
        public DataTable ViewbyTime(ViewByTime viewByTime)
        {
            return _viewByTimeGetway.ViewbyTime(viewByTime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.VM
{
   public class SearchAndView
    {
        public long Id { get; set; }
        public string Item { get; set; }
        public string Company { get; set; }

        public string Category { get; set; }

        public string AvailableQuantity { get; set; }

        public long  ReorderLevel { get; set; }


    }
}

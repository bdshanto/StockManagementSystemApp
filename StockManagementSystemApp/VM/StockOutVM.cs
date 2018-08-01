using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.VM
{
    class StockOutVM
    {
        public long Id { get; set; }
        public string  Item { get; set; }
        public string Company { get; set; }
        public long StockIn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Models
{
    class StockOut
    {
        public long Id { get; set; }
        public long Item { get; set; }
        public long Company { get; set; }
        public long Quantity { get; set; }
        public long AvailableItems { get; set; }

    }
}

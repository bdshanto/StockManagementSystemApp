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
        public long ItemId { get; set; }
        public long StocksOut { get; set; }
    }
}

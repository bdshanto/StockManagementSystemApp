using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Models
{
    class Item
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long CompanyId { get; set; }
        public string Name { get; set; }
        public long ReOrderLevel { get; set; }
        public long Stock { get; set; }
    }
}

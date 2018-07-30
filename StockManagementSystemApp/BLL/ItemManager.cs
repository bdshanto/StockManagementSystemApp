using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;
namespace StockManagementSystemApp.BLL
{
    class ItemManager
    {
        ItemGetway _itemGetway = new ItemGetway();
        public bool IsDuplicateData(Item item)
        {
            return _itemGetway.IsDuplicateData(item);
        }

        public bool Add(Item item)
        {
            return _itemGetway.Add(item);
        }
    }
}

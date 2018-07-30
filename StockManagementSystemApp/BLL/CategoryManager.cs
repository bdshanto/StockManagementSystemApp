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
    class CategoryManager
    {CategorieGetway _categorieGetway = new CategorieGetway();
      

        public DataTable GetData(Category category)
        {
            return _categorieGetway.GetData(category);
        }

        public bool IsDuplicateData(Category category)
        {
            return _categorieGetway.IsDuplicateData(category);
        }


        public bool Add(Category category)
        {
            return _categorieGetway.Add(category);
        }
    }
}

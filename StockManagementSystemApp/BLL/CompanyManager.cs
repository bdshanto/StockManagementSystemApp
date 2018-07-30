using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;
using  StockManagementSystemApp.DAL;

namespace StockManagementSystemApp.BLL
{
    class CompanyManager
    {
        CompanyGetway _companyGetway = new CompanyGetway();

        public DataTable GetData(Company company)
        {
            return _companyGetway.GetData(company);
        }
        public bool IsDuplicateData(Company company)
        {
            return _companyGetway.IsDuplicateData(company);
        }
        public bool Add(Company company)
        {
            return _companyGetway.Add(company);
        }

       
    }
}

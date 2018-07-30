using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Models;
using StockManagementSystemApp.BLL;

namespace StockManagementSystemApp
{
    public partial class ItemUi : Form
    {
        StockInManager _stockInManager = new StockInManager();
        StocksIn _stockIn = new StocksIn();
        CategoryManager _categoryManager = new CategoryManager();
        Category _category = new Category();
        ItemManager _itemManager = new ItemManager();
        Item _item = new Item();
        public ItemUi()
        {
            InitializeComponent();
            GetLoad();
            LoadCompany();
        }
        private void GetLoad()
        {
            DataTable dt = _categoryManager.GetData(_category);
            categoryBindingSource.DataSource = dt; 
        }

    private void LoadCompany()
        {
            DataTable dt = _stockInManager.LoadCompanyDropDown(_stockIn);
            companyBindingSource.DataSource = dt;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemTextBox.Text == "" && reOrderTextBox.Text == "")
                {
                    msgLabel.Text = "Enter a Item";
                    msgLabel.ForeColor = Color.Red;
                    return;
                }

                _item.CategoryId = Convert.ToInt64(categoryComboBox.SelectedValue);
                _item.CompanyId = Convert.ToInt64(companyComboBox.SelectedValue);
                _item.Name = itemTextBox.Text;
                _item.ReOrderLevel = Convert.ToInt32(reOrderTextBox.Text);

                bool isExist = _itemManager.IsDuplicateData(_item);
                if (isExist)
                {
                    msgLabel.Text = $"Company {itemTextBox.Text} already in system";
                    msgLabel.ForeColor = Color.Red;
                    return;
                }

                bool isAdded = _itemManager.Add(_item);
                if (isAdded)
                {
                    msgLabel.Text = $"Save Item: {itemTextBox.Text} successfully";
                }
            }
            catch (Exception exception)
            {
                msgLabel.Text = exception.Message;
            }
        }

    }
}

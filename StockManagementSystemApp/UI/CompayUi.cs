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
    public partial class CompayUi : Form
    {
        Company _company = new Company();
        CompanyManager _companyManager = new CompanyManager();

        public CompayUi()
        {
            InitializeComponent();
            GetData();
        }
        private void GetData()
        {
            DataTable dt = _companyManager.GetData(_company);
            companyGetDataGridView.DataSource = companyBindingSource.DataSource;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "")
                {
                    nameLlabel.Text = "Enter a Company";
                    nameLlabel.ForeColor = Color.Red;
                    return;
                }
                _company.Name = nameTextBox.Text.Trim();

                bool isExist = _companyManager.IsDuplicateData(_company);
                if (isExist)
                {
                    nameLlabel.Text = $"Company {nameTextBox.Text} already in system";
                    nameLlabel.ForeColor = Color.Red;
                    nameTextBox.Clear();
                    return;
                }
                bool isAdded = _companyManager.Add(_company);
                if (isAdded)
                {

                    nameLlabel.Text = $"Save company: {nameTextBox.Text} successfully";
                    GetData();
                    nameTextBox.Clear();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}

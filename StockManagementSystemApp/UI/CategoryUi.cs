using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using StockManagementSystemApp.Models;
using StockManagementSystemApp.BLL;

namespace StockManagementSystemApp.UI
{
    public partial class CategoryUi : Form

    {
        private void categoryGetDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            categoryGetDataGridView.Rows[e.RowIndex].Cells["SL"].Value = e.RowIndex + 1;
        }
        CategoryManager _categoryManager = new CategoryManager();
        Category _category = new Category();
         
        public CategoryUi()
        {
            InitializeComponent();
            GetData(); 
        }

        private void GetData()
        {
            DataTable geTable = _categoryManager.GetData(_category);
            categoryBindingSource.DataSource = geTable;
            categoryGetDataGridView.DataSource = categoryBindingSource;
        }
     
        private void SaveButton_Click(object sender, EventArgs e)
        { 
            try
            { 
                if (nameTextBox.Text == "")
                {
                    nameLlabel.Text = "Enter a category";
                    nameLlabel.ForeColor = Color.Red;
                    return;
                }
                _category.Name = nameTextBox.Text.Trim();

                bool isExist = _categoryManager.IsDuplicateData(_category);
                if (isExist)
                {
                    nameLlabel.Text = $"Catagory {nameTextBox.Text} already in system";
                    nameLlabel.ForeColor = Color.Red;
                    nameTextBox.Clear();
                    return;
                } 
                bool isAdded = _categoryManager.Add(_category);
                if (isAdded)
                { 
                    nameLlabel.Text = $"Save category: {nameTextBox.Text} successfully";
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

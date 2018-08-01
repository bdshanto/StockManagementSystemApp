namespace StockManagementSystemApp.VM
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryButton = new System.Windows.Forms.Button();
            this.companyButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.stockInButton = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.searchViewButton = new System.Windows.Forms.Button();
            this.viewSalesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.SidePanel.Controls.Add(this.viewSalesButton);
            this.SidePanel.Controls.Add(this.searchViewButton);
            this.SidePanel.Controls.Add(this.StockOutButton);
            this.SidePanel.Controls.Add(this.stockInButton);
            this.SidePanel.Controls.Add(this.itemButton);
            this.SidePanel.Controls.Add(this.companyButton);
            this.SidePanel.Controls.Add(this.categoryButton);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.ForeColor = System.Drawing.Color.Green;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(162, 506);
            this.SidePanel.TabIndex = 0;
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.headPanel.Controls.Add(this.label1);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(162, 0);
            this.headPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(637, 108);
            this.headPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(165, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Managment System";
            // 
            // categoryButton
            // 
            this.categoryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.Location = new System.Drawing.Point(0, 115);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(162, 38);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Setup Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // companyButton
            // 
            this.companyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyButton.Location = new System.Drawing.Point(0, 174);
            this.companyButton.Name = "companyButton";
            this.companyButton.Size = new System.Drawing.Size(162, 34);
            this.companyButton.TabIndex = 2;
            this.companyButton.Text = "Setup Company";
            this.companyButton.UseVisualStyleBackColor = true;
            this.companyButton.Click += new System.EventHandler(this.companyButton_Click);
            // 
            // itemButton
            // 
            this.itemButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemButton.Location = new System.Drawing.Point(0, 238);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(162, 39);
            this.itemButton.TabIndex = 3;
            this.itemButton.Text = "Setup Item";
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // stockInButton
            // 
            this.stockInButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInButton.Location = new System.Drawing.Point(-5, 301);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Size = new System.Drawing.Size(167, 37);
            this.stockInButton.TabIndex = 4;
            this.stockInButton.Text = "Stock In";
            this.stockInButton.UseVisualStyleBackColor = true;
            this.stockInButton.Click += new System.EventHandler(this.stockInButton_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutButton.Location = new System.Drawing.Point(0, 362);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(162, 37);
            this.StockOutButton.TabIndex = 5;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // searchViewButton
            // 
            this.searchViewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchViewButton.Location = new System.Drawing.Point(0, 416);
            this.searchViewButton.Name = "searchViewButton";
            this.searchViewButton.Size = new System.Drawing.Size(162, 35);
            this.searchViewButton.TabIndex = 6;
            this.searchViewButton.Text = "Search & View Items Summary";
            this.searchViewButton.UseVisualStyleBackColor = true;
            this.searchViewButton.Click += new System.EventHandler(this.searchViewButton_Click);
            // 
            // viewSalesButton
            // 
            this.viewSalesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSalesButton.Location = new System.Drawing.Point(0, 471);
            this.viewSalesButton.Name = "viewSalesButton";
            this.viewSalesButton.Size = new System.Drawing.Size(159, 32);
            this.viewSalesButton.TabIndex = 7;
            this.viewSalesButton.Text = "View Sales Between Two Dates ";
            this.viewSalesButton.UseVisualStyleBackColor = true;
            this.viewSalesButton.Click += new System.EventHandler(this.viewSalesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(40, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "WellCome To Stock Managment Syestem";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.SidePanel.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewSalesButton;
        private System.Windows.Forms.Button searchViewButton;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button stockInButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button companyButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
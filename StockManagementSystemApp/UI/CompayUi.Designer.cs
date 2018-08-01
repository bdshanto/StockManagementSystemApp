namespace StockManagementSystemApp
{
    partial class CompayUi
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
            this.components = new System.ComponentModel.Container();
            this.catagoryGroupBox = new System.Windows.Forms.GroupBox();
            this.companyGetDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catagoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catagoryGroupBox
            // 
            this.catagoryGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.catagoryGroupBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.catagoryGroupBox.Controls.Add(this.companyGetDataGridView);
            this.catagoryGroupBox.Controls.Add(this.SaveButton);
            this.catagoryGroupBox.Controls.Add(this.nameTextBox);
            this.catagoryGroupBox.Controls.Add(this.nameLlabel);
            this.catagoryGroupBox.Controls.Add(this.label1);
            this.catagoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryGroupBox.ForeColor = System.Drawing.Color.DarkRed;
            this.catagoryGroupBox.Location = new System.Drawing.Point(48, 18);
            this.catagoryGroupBox.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.catagoryGroupBox.Name = "catagoryGroupBox";
            this.catagoryGroupBox.Size = new System.Drawing.Size(642, 479);
            this.catagoryGroupBox.TabIndex = 1;
            this.catagoryGroupBox.TabStop = false;
            this.catagoryGroupBox.Text = "Company";
            this.catagoryGroupBox.UseCompatibleTextRendering = true;
            // 
            // companyGetDataGridView
            // 
            this.companyGetDataGridView.AllowUserToAddRows = false;
            this.companyGetDataGridView.AllowUserToDeleteRows = false;
            this.companyGetDataGridView.AutoGenerateColumns = false;
            this.companyGetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.nameDataGridViewTextBoxColumn,
            this.Action});
            this.companyGetDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.companyGetDataGridView.DataSource = this.companyBindingSource;
            this.companyGetDataGridView.Location = new System.Drawing.Point(43, 194);
            this.companyGetDataGridView.Name = "companyGetDataGridView";
            this.companyGetDataGridView.ReadOnly = true;
            this.companyGetDataGridView.Size = new System.Drawing.Size(547, 232);
            this.companyGetDataGridView.TabIndex = 3;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SL.Frozen = true;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.ToolTipText = "Serial";
            this.SL.Width = 54;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Edit";
            this.Action.Width = 79;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(285, 109);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nameTextBox.Location = new System.Drawing.Point(205, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLlabel
            // 
            this.nameLlabel.AutoSize = true;
            this.nameLlabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nameLlabel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nameLlabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nameLlabel.Location = new System.Drawing.Point(454, 63);
            this.nameLlabel.Name = "nameLlabel";
            this.nameLlabel.Size = new System.Drawing.Size(0, 18);
            this.nameLlabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemApp.Models.Company);
            // 
            // CompayUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 552);
            this.Controls.Add(this.catagoryGroupBox);
            this.Name = "CompayUi";
            this.Text = "CompayUi";
            this.catagoryGroupBox.ResumeLayout(false);
            this.catagoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox catagoryGroupBox;
        private System.Windows.Forms.DataGridView companyGetDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.BindingSource companyBindingSource;
    }
}
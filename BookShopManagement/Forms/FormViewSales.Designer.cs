namespace BookShopManagement.Forms
{
    partial class FormViewSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSaleReport = new System.Windows.Forms.DataGridView();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantitySell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(566, 32);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(65, 23);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Role :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sale Reports";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(21, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(88, 40);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(896, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSaleReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 389);
            this.panel2.TabIndex = 1;
            // 
            // dgvSaleReport
            // 
            this.dgvSaleReport.AllowUserToAddRows = false;
            this.dgvSaleReport.AllowUserToDeleteRows = false;
            this.dgvSaleReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleId,
            this.TitleSell,
            this.QuantitySell,
            this.PriceSell,
            this.TotalSellPrice,
            this.SaleDate});
            this.dgvSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleReport.Location = new System.Drawing.Point(0, 0);
            this.dgvSaleReport.Name = "dgvSaleReport";
            this.dgvSaleReport.ReadOnly = true;
            this.dgvSaleReport.RowHeadersWidth = 51;
            this.dgvSaleReport.RowTemplate.Height = 24;
            this.dgvSaleReport.Size = new System.Drawing.Size(960, 389);
            this.dgvSaleReport.TabIndex = 0;
            // 
            // SaleId
            // 
            this.SaleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleId.DataPropertyName = "SaleId";
            this.SaleId.HeaderText = "Sale ID";
            this.SaleId.MinimumWidth = 6;
            this.SaleId.Name = "SaleId";
            this.SaleId.ReadOnly = true;
            // 
            // TitleSell
            // 
            this.TitleSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleSell.DataPropertyName = "(none)TitleSell";
            this.TitleSell.HeaderText = "Title";
            this.TitleSell.MinimumWidth = 6;
            this.TitleSell.Name = "TitleSell";
            this.TitleSell.ReadOnly = true;
            // 
            // QuantitySell
            // 
            this.QuantitySell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantitySell.DataPropertyName = "QuantitySell";
            this.QuantitySell.HeaderText = "Quantity";
            this.QuantitySell.MinimumWidth = 6;
            this.QuantitySell.Name = "QuantitySell";
            this.QuantitySell.ReadOnly = true;
            // 
            // PriceSell
            // 
            this.PriceSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceSell.DataPropertyName = "PriceSell";
            this.PriceSell.HeaderText = "Unit Price";
            this.PriceSell.MinimumWidth = 6;
            this.PriceSell.Name = "PriceSell";
            this.PriceSell.ReadOnly = true;
            // 
            // TotalSellPrice
            // 
            this.TotalSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSellPrice.DataPropertyName = "TotalSellPrice";
            this.TotalSellPrice.HeaderText = "Total Sell Price";
            this.TotalSellPrice.MinimumWidth = 6;
            this.TotalSellPrice.Name = "TotalSellPrice";
            this.TotalSellPrice.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Date And Time";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // FormViewSales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewSales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSaleReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantitySell;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.Label lblRole;
    }
}
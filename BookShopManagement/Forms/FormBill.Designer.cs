namespace BookShopManagement.Forms
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.TitleSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantitySell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.labSub = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 73);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Billing";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnExit.Size = new System.Drawing.Size(64, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBill);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 179);
            this.panel2.TabIndex = 1;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleSell,
            this.QuantitySell,
            this.PriceSell,
            this.TotalSellPrice});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(936, 179);
            this.dgvBill.TabIndex = 1;
            // 
            // TitleSell
            // 
            this.TitleSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleSell.DataPropertyName = "TitleSell";
            this.TitleSell.HeaderText = "Book Title";
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
            this.PriceSell.HeaderText = "Price ";
            this.PriceSell.MinimumWidth = 6;
            this.PriceSell.Name = "PriceSell";
            this.PriceSell.ReadOnly = true;
            // 
            // TotalSellPrice
            // 
            this.TotalSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSellPrice.DataPropertyName = "(none)TotalSellPrice";
            this.TotalSellPrice.HeaderText = "Total";
            this.TotalSellPrice.MinimumWidth = 6;
            this.TotalSellPrice.Name = "TotalSellPrice";
            this.TotalSellPrice.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(343, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Puthi Mela Book Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(418, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Natore";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblDateTime.Location = new System.Drawing.Point(254, 161);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(100, 19);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "Data & Time:";
            // 
            // labSub
            // 
            this.labSub.AutoSize = true;
            this.labSub.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labSub.Location = new System.Drawing.Point(12, 398);
            this.labSub.Name = "labSub";
            this.labSub.Size = new System.Drawing.Size(78, 19);
            this.labSub.TabIndex = 15;
            this.labSub.Text = "Subtotal:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblDiscount.Location = new System.Drawing.Point(12, 433);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(84, 19);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(12, 465);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(107, 19);
            this.lblGrandTotal.TabIndex = 17;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(398, 513);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 46);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // FormBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.labSub);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantitySell;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSellPrice;
        private System.Windows.Forms.Label labSub;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnPrint;
    }
}
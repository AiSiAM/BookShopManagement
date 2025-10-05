namespace BookShopManagement.Forms
{
    partial class FormSaleBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaleBooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutoSearchTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvSell = new System.Windows.Forms.DataGridView();
            this.TitleSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantitySell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSearchTitle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(471, 33);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 23);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(873, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(24, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 39);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(20, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(20, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // txtAutoSearchTitle
            // 
            this.txtAutoSearchTitle.Location = new System.Drawing.Point(237, 98);
            this.txtAutoSearchTitle.Name = "txtAutoSearchTitle";
            this.txtAutoSearchTitle.Size = new System.Drawing.Size(293, 22);
            this.txtAutoSearchTitle.TabIndex = 5;
            this.txtAutoSearchTitle.TextChanged += new System.EventHandler(this.txtAutoSearchTitle_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(20, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discount:";
            // 
            // txtSellQuantity
            // 
            this.txtSellQuantity.Location = new System.Drawing.Point(237, 230);
            this.txtSellQuantity.Name = "txtSellQuantity";
            this.txtSellQuantity.Size = new System.Drawing.Size(293, 22);
            this.txtSellQuantity.TabIndex = 7;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(237, 270);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(293, 22);
            this.txtDiscount.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(237, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(293, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(237, 189);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(293, 22);
            this.txtQuantity.TabIndex = 10;
            // 
            // dgvSell
            // 
            this.dgvSell.AllowUserToAddRows = false;
            this.dgvSell.AllowUserToDeleteRows = false;
            this.dgvSell.BackgroundColor = System.Drawing.Color.White;
            this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleSell,
            this.QuantitySell,
            this.PriceSell,
            this.DiscountSell,
            this.TotalSellPrice});
            this.dgvSell.Location = new System.Drawing.Point(24, 346);
            this.dgvSell.Name = "dgvSell";
            this.dgvSell.ReadOnly = true;
            this.dgvSell.RowHeadersWidth = 51;
            this.dgvSell.RowTemplate.Height = 24;
            this.dgvSell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSell.Size = new System.Drawing.Size(913, 228);
            this.dgvSell.TabIndex = 11;
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
            this.PriceSell.HeaderText = "Price";
            this.PriceSell.MinimumWidth = 6;
            this.PriceSell.Name = "PriceSell";
            this.PriceSell.ReadOnly = true;
            // 
            // DiscountSell
            // 
            this.DiscountSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiscountSell.DataPropertyName = "DiscountSell";
            this.DiscountSell.HeaderText = "Discount";
            this.DiscountSell.MinimumWidth = 6;
            this.DiscountSell.Name = "DiscountSell";
            this.DiscountSell.ReadOnly = true;
            // 
            // TotalSellPrice
            // 
            this.TotalSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSellPrice.DataPropertyName = "TotalSellPrice";
            this.TotalSellPrice.HeaderText = "Total Price";
            this.TotalSellPrice.MinimumWidth = 6;
            this.TotalSellPrice.Name = "TotalSellPrice";
            this.TotalSellPrice.ReadOnly = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(24, 302);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(123, 38);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(176, 302);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 38);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(288, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(420, 302);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(110, 38);
            this.btnSell.TabIndex = 15;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSearchTitle);
            this.panel2.Location = new System.Drawing.Point(583, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 197);
            this.panel2.TabIndex = 16;
            // 
            // dgvSearchTitle
            // 
            this.dgvSearchTitle.AllowUserToAddRows = false;
            this.dgvSearchTitle.AllowUserToDeleteRows = false;
            this.dgvSearchTitle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchTitle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchTitle.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearchTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchTitle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSearchTitle.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchTitle.Name = "dgvSearchTitle";
            this.dgvSearchTitle.ReadOnly = true;
            this.dgvSearchTitle.RowHeadersWidth = 51;
            this.dgvSearchTitle.RowTemplate.Height = 24;
            this.dgvSearchTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchTitle.Size = new System.Drawing.Size(354, 197);
            this.dgvSearchTitle.TabIndex = 0;
            this.dgvSearchTitle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeaechTitle_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Book Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FormSaleBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dgvSell);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSellQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAutoSearchTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSaleBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSaleBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAutoSearchTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSellQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvSell;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSearchTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantitySell;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSellPrice;
    }
}
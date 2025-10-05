namespace BookShopManagement.Forms
{
    partial class FormManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFilterbyCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearchByTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 65);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(885, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Management";
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 65);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbFilterbyCategory);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtSearchByTitle);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtAuthor);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 314);
            this.panel2.TabIndex = 2;
            // 
            // cmbFilterbyCategory
            // 
            this.cmbFilterbyCategory.FormattingEnabled = true;
            this.cmbFilterbyCategory.Location = new System.Drawing.Point(686, 256);
            this.cmbFilterbyCategory.Name = "cmbFilterbyCategory";
            this.cmbFilterbyCategory.Size = new System.Drawing.Size(253, 24);
            this.cmbFilterbyCategory.TabIndex = 18;
            this.cmbFilterbyCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFilterbyCategory_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(522, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Filter by category:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(554, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(554, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(554, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearchByTitle
            // 
            this.txtSearchByTitle.Location = new System.Drawing.Point(180, 254);
            this.txtSearchByTitle.Name = "txtSearchByTitle";
            this.txtSearchByTitle.Size = new System.Drawing.Size(295, 22);
            this.txtSearchByTitle.TabIndex = 13;
            this.txtSearchByTitle.TextChanged += new System.EventHandler(this.txtSearchByTitle_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(180, 216);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(295, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(180, 179);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(295, 22);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(180, 97);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(295, 22);
            this.txtAuthor.TabIndex = 10;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(180, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 22);
            this.txtTitle.TabIndex = 9;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(180, 26);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(295, 22);
            this.txtBookId.TabIndex = 8;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction",
            "Science  ",
            "Business",
            "Self-Help",
            "History",
            "Biography",
            ""});
            this.cmbCategory.Location = new System.Drawing.Point(180, 137);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(295, 24);
            this.cmbCategory.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(47, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Search by title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(47, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(47, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(47, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(47, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(47, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(47, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Controls.Add(this.dgvBooks);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 221);
            this.panel3.TabIndex = 3;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.Title,
            this.Author,
            this.Category,
            this.Quantity,
            this.Price});
            this.dgvBooks.Location = new System.Drawing.Point(12, 6);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(936, 203);
            this.dgvBooks.TabIndex = 0;
            // 
            // BookId
            // 
            this.BookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "Book ID";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Book Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Book Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // FormManageBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManageBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFilterbyCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearchByTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
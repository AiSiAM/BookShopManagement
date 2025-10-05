namespace BookShopManagement.Forms
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAll = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecurityAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(905, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 72);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(88, 36);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puthi Mela Book Shop - User Management";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSecurityAnswer);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmbSecurityQuestion);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnDeleteUser);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbRole);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtUserId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 528);
            this.panel2.TabIndex = 1;
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(12, 354);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(241, 22);
            this.txtSecurityAnswer.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(8, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Security Answer:";
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "What is your favorite movie?",
            "What is the name of your favorite teacher?",
            "What is your favorite food?",
            "What is your favorite book?"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(16, 291);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(237, 24);
            this.cmbSecurityQuestion.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(8, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Security Question:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(12, 458);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(95, 37);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(158, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 37);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmbRole.Location = new System.Drawing.Point(106, 229);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(147, 24);
            this.cmbRole.TabIndex = 7;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(16, 64);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(237, 22);
            this.txtUserId.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(18, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(54, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add / Edit User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(319, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter by role:";
            // 
            // cmbAll
            // 
            this.cmbAll.FormattingEnabled = true;
            this.cmbAll.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Employee"});
            this.cmbAll.Location = new System.Drawing.Point(458, 473);
            this.cmbAll.Name = "cmbAll";
            this.cmbAll.Size = new System.Drawing.Size(131, 24);
            this.cmbAll.TabIndex = 4;
            this.cmbAll.SelectedIndexChanged += new System.EventHandler(this.cmbAll_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(627, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search:";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(716, 477);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(152, 22);
            this.txtAutoSearch.TabIndex = 6;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(303, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 382);
            this.panel3.TabIndex = 7;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Name,
            this.Password,
            this.Role,
            this.SecurityQuestion,
            this.SecurityAnswer});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.GridColor = System.Drawing.Color.Black;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(657, 382);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "User Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "User Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // SecurityQuestion
            // 
            this.SecurityQuestion.DataPropertyName = "SecurityQuestion";
            this.SecurityQuestion.HeaderText = "Security Question";
            this.SecurityQuestion.MinimumWidth = 6;
            this.SecurityQuestion.Name = "SecurityQuestion";
            this.SecurityQuestion.ReadOnly = true;
            this.SecurityQuestion.Width = 125;
            // 
            // SecurityAnswer
            // 
            this.SecurityAnswer.DataPropertyName = "SecurityAnswer";
            this.SecurityAnswer.HeaderText = "Security Answer";
            this.SecurityAnswer.MinimumWidth = 6;
            this.SecurityAnswer.Name = "SecurityAnswer";
            this.SecurityAnswer.ReadOnly = true;
            this.SecurityAnswer.Width = 125;
            // 
            // FormUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtAutoSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
       
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecurityAnswer;
    }
}
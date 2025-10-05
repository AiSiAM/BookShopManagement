namespace BookShopManagement.Forms
{
    partial class FormForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(722, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(260, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(260, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "What Is Your Security Question?";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(264, 156);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(209, 22);
            this.txtUserId.TabIndex = 3;
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "What is your favorite movie?",
            "What is the name of your favorite teacher?",
            "What is your favorite food?",
            "What is your favorite book?"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(264, 217);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(209, 24);
            this.cmbSecurityQuestion.TabIndex = 4;
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(264, 282);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(209, 22);
            this.txtSecurityAnswer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(260, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Security Answer:";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnVerify.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(264, 311);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(92, 32);
            this.btnVerify.TabIndex = 7;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(381, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormForgetPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.cmbSecurityQuestion);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForgetPassword";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
    }
}
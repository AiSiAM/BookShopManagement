using BookShopManagement.Forms;
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

namespace BookShopManagement
{
    public partial class FormLogin : Form
    {
       

        public FormLogin()
        {
            InitializeComponent();
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both User ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "SELECT * FROM UserInfo WHERE UserId = '" + txtUserId.Text + "' AND Password = '" + txtPassword.Text + "'";
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(query);
                da.Close(); 

                if (dt.Rows.Count == 1)
                {
                    string name = dt.Rows[0]["Name"].ToString();
                    string role = dt.Rows[0]["Role"].ToString();

                    MessageBox.Show("Login Successful! Welcome, " + name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();


                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        new FormAdmin(name,role, this).Show();
                    }
                    else if (role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                    {
                        new FormEmployee(name, role, this).Show();
                    }

                    else
                    {
                        MessageBox.Show("Unknown role. Access denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Do you want to exit?",
           "Exit Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        public void ClearFields()
        {
            txtUserId.Text = "";
            txtPassword.Text = "";
        
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (txtPassword.UseSystemPasswordChar)
                btnShowPassword.Text = "Show";
            else
                btnShowPassword.Text = "Hide";

        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormForgetPassword ffp = new FormForgetPassword();
            ffp.Show();
        }
    }
}

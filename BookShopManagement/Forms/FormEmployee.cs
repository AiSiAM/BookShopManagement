using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class FormEmployee : Form
    {
        public FormLogin Fl { get; set; }
        public string UserName { get; private set; }
        public string UserRole { get; private set; }

        public FormEmployee()
        {
            InitializeComponent();
        }
        public FormEmployee(string nameInfo, string role, FormLogin fl) : this()
        {
            this.lblInfo.Text = "WELCOME, " + nameInfo.ToUpper();
            this.lblRole.Text = "ROLE: " + role.ToUpper();
            this.Fl = fl;
            this.UserName = nameInfo;
            this.UserRole = role;
        }

        private void FormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("System terminating properly");
            Application.Exit();
        }
        private void btnEmployeeExit_Click(object sender, EventArgs e)
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
        private void moveSidePanel(Control btn)
        {
            pnlSide.Top = btn.Top;
            pnlSide.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSaleBooks);
            this.Hide();

            FormSaleBooks bookFrom = new FormSaleBooks(this.UserName, this.UserRole, this.Fl);
            bookFrom.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
            this.Hide();
            new FormViewSales(this.UserName, this.UserRole, this.Fl).Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Do you want to logout from the system?",
           "Logout Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();

                if (this.Fl != null)
                {
                    this.Fl.ClearFields(); 
                    this.Fl.Show();         
                }
                else
                {
                    FormLogin loginForm = new FormLogin();
                    loginForm.Show();
                }

                MessageBox.Show("Logged out from system");
            }
        }
    }
}
    

    


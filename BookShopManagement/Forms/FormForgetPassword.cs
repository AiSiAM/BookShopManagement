using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class FormForgetPassword : Form
    {
        public FormForgetPassword()
        {
            InitializeComponent();
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {

        }
    }
}

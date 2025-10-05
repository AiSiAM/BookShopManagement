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
    public partial class FormUpgradePassword : Form
    {
        public FormUpgradePassword()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Optional: hide the current form
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}

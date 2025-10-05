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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopManagement.Forms
{
    public partial class FormUsers : Form
    {
        private DataAccess Da = new DataAccess();
        private bool isEditing = false;
        private string CurrentUserName { get; set; }
        private string CurrentUserRole { get; set; }
        private FormLogin MainFormLogin { get; set; }

        public FormUsers()
        {
            InitializeComponent();
            PopulateGridView();
            this.Load += FormUsers_Load;
        }

        
        public FormUsers(string userName, string userRole, FormLogin fl) : this() 
        {
            this.CurrentUserName = userName;
            this.CurrentUserRole = userRole.ToLower(); 
            this.MainFormLogin = fl;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            PopulateGridView();
            ClearAll();
        }

        private void PopulateGridView(string sql = "SELECT * FROM UserInfo")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.DataSource = ds.Tables[0];
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (this.MainFormLogin != null && !string.IsNullOrWhiteSpace(this.CurrentUserRole))
            {
                if (this.CurrentUserRole.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    new FormAdmin(this.CurrentUserName, this.CurrentUserRole, this.MainFormLogin).Show();
                }
                else if (this.CurrentUserRole.Equals("employee", StringComparison.OrdinalIgnoreCase))
                {
                    new FormEmployee(this.CurrentUserName, this.CurrentUserRole, this.MainFormLogin).Show();
                }
                else
                {
                    MessageBox.Show("User role not recognized. Returning to login.", "Navigation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.MainFormLogin.ClearFields();
                    this.MainFormLogin.Show();
                }
            }
            else
            {
                MessageBox.Show("User session information lost. Returning to login screen.", "Session Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                new FormLogin().Show();
            }
            this.Dispose();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var userId = this.txtUserId.Text.Trim();

                if (isEditing)
                {
                    var sql = @"UPDATE UserInfo
                                SET Name = '" + this.txtName.Text + @"',
                                    Password = '" + this.txtPassword.Text + @"',
                                    Role = '" + this.cmbRole.Text + @"',
                                    SecurityQuestion = '" + this.cmbSecurityQuestion.Text + @"',
                                    SecurityAnswer = '" + this.txtSecurityAnswer.Text + @"'
                                WHERE UserId = '" + userId + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);
                    MessageBox.Show(count == 1 ? "User information has been updated." : "Update failed.");
                }
                else
                {
                    var sql = @"INSERT INTO UserInfo (UserId, Name, Password, Role, SecurityQuestion, SecurityAnswer)
                                VALUES ('" + userId + "', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbRole.Text + "', '" + this.cmbSecurityQuestion.Text + "', '" + this.txtSecurityAnswer.Text + "');";

                    var count = this.Da.ExecuteDMLQuery(sql);
                    MessageBox.Show(count == 1 ? "New user has been added." : "Insertion failed.");
                }

                this.PopulateGridView();
                this.ClearAll();

                isEditing = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred. Please try again.\n" + exc.Message);
            }
        }

        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtSecurityAnswer.Clear();

            this.txtUserId.Enabled = true;
            this.cmbRole.SelectedIndexChanged -= cmbRole_SelectedIndexChanged;
            this.cmbRole.SelectedIndex = -1;
            this.cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;

            this.cmbSecurityQuestion.SelectedIndex = -1;

            this.cmbAll.SelectedIndexChanged -= cmbAll_SelectedIndexChanged;
            this.cmbAll.SelectedIndex = -1;
            this.cmbAll.SelectedIndexChanged += cmbAll_SelectedIndexChanged;

            this.txtAutoSearch.Clear();
            this.dgvUsers.ClearSelection();

            isEditing = false;
        }

        private bool IsValidToSave()
        {
            return !string.IsNullOrEmpty(this.txtUserId.Text) &&
                   !string.IsNullOrEmpty(this.txtName.Text) &&
                   !string.IsNullOrEmpty(this.txtPassword.Text) &&
                   !string.IsNullOrEmpty(this.cmbRole.Text) &&
                   !string.IsNullOrEmpty(this.cmbSecurityQuestion.Text) &&
                   !string.IsNullOrEmpty(this.txtSecurityAnswer.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM UserInfo WHERE UserId LIKE '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void cmbAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAll.SelectedItem == null) return;

            string role = cmbAll.SelectedItem.ToString();
            string sql = role == "All"
                ? "SELECT * FROM UserInfo;"
                : "SELECT * FROM UserInfo WHERE Role = '" + role + "';";

            PopulateGridView(sql);
        }

        private void AutoUserIdGenerate(string role)
        {
            string prefix = role == "Admin" ? "ADM" :
                            role == "Employee" ? "EMP" : "";

            if (string.IsNullOrEmpty(prefix))
                return;

            string sql = "SELECT MAX(UserId) FROM UserInfo WHERE UserId LIKE '" + prefix + "%'";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0]?.ToString();

            if (string.IsNullOrEmpty(oldId))
            {
                this.txtUserId.Text = prefix + "001";
            }
            else
            {
                var numPart = oldId.Substring(prefix.Length);
                int num = Convert.ToInt32(numPart);
                string currentId = prefix + (++num).ToString("d3");
                this.txtUserId.Text = currentId;
            }
        }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEditing)
                return;

            if (cmbRole.SelectedItem == null)
                return;
            string selectedRole = cmbRole.SelectedItem.ToString();
            string expectedPrefix = selectedRole == "Admin" ? "ADM" : (selectedRole == "Employee" ? "EMP" : "");

            if (string.IsNullOrEmpty(this.txtUserId.Text) || !this.txtUserId.Text.StartsWith(expectedPrefix))
            {
                AutoUserIdGenerate(selectedRole);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUsers.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var id = this.dgvUsers.CurrentRow.Cells["UserId"].Value.ToString();
                var name = this.dgvUsers.CurrentRow.Cells["Name"].Value.ToString();

                var result = MessageBox.Show("Are you sure you want to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "DELETE FROM UserInfo WHERE UserId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                MessageBox.Show(count == 1 ? name.ToUpper() + " has been removed from the system." : "User could not be deleted.");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the user.\n" + ex.Message);
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvUsers.CurrentRow != null && this.dgvUsers.CurrentRow.Index >= 0)
            {
                this.txtUserId.Text = this.dgvUsers.CurrentRow.Cells["UserId"].Value.ToString();
                this.txtName.Text = this.dgvUsers.CurrentRow.Cells["Name"].Value.ToString();
                this.txtPassword.Text = this.dgvUsers.CurrentRow.Cells["Password"].Value.ToString();
                this.cmbRole.Text = this.dgvUsers.CurrentRow.Cells["Role"].Value.ToString();
                this.cmbSecurityQuestion.Text = this.dgvUsers.CurrentRow.Cells["SecurityQuestion"].Value.ToString();
                this.txtSecurityAnswer.Text = this.dgvUsers.CurrentRow.Cells["SecurityAnswer"].Value.ToString();
                this.txtUserId.Enabled = false;
                isEditing = true;
            }
        }
    }
}
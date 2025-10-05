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
    public partial class FormManageBooks : Form
    {
        private DataAccess Da = new DataAccess();
        private bool isEditing = false;
        private string CurrentUserName { get; set; }
        private string CurrentUserRole { get; set; }
        private FormLogin MainFormLogin { get; set; } 

        public FormManageBooks()
        {
            InitializeComponent();
            this.Load += FormManageBooks_Load;
            this.Shown += FormManageBooks_Shown;
            this.dgvBooks.CellDoubleClick += dgvBooks_CellDoubleClick;
        }
        public FormManageBooks(string userName, string userRole, FormLogin fl) : this()
        {
            this.CurrentUserName = userName;
            this.CurrentUserRole = userRole.ToLower();
            this.MainFormLogin = fl;
        }

        private void FormManageBooks_Load(object sender, EventArgs e)
        {
            PopulateGridView();
            LoadCategories();
            ClearAll();
        }

        private void FormManageBooks_Shown(object sender, EventArgs e)
        {
            AutoBookIdGenerate();
        }

        private void PopulateGridView(string sql = "SELECT * FROM BookInfo")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.DataSource = ds.Tables[0];
        }

        private void AutoBookIdGenerate()
        {
            string sql = "SELECT COUNT(*) FROM BookInfo";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]) + 1;
            this.txtBookId.Text = "BK-" + count.ToString("D3");
        }

        private void RenumberBookIds()
        {
            string selectSql = "SELECT * FROM BookInfo ORDER BY BookId";
            DataTable dt = this.Da.ExecuteQueryTable(selectSql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string newId = "BK-" + (i + 1).ToString("D3");
                string oldId = dt.Rows[i]["BookId"].ToString();

                if (newId != oldId)
                {
                    string updateSql = "UPDATE BookInfo SET BookId = '" + newId + "' WHERE BookId = '" + oldId + "'";
                    this.Da.ExecuteDMLQuery(updateSql);
                }
            }
        }
        private void LoadCategories()
        {
            cmbFilterbyCategory.Items.Clear();
            cmbFilterbyCategory.Items.Add("All");

            string sql = "SELECT DISTINCT Category FROM BookInfo;";
            DataSet ds = this.Da.ExecuteQuery(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cmbFilterbyCategory.Items.Add(row["Category"].ToString());
            }

            cmbFilterbyCategory.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidToSave())
            {
                MessageBox.Show("Please fill all the empty fields");
                return;
            }

            string bookId = this.txtBookId.Text.Trim();
            string sql;

            if (isEditing)
            {
                sql = "UPDATE BookInfo SET " +
                      "Title = '" + this.txtTitle.Text + "', " +
                      "Author = '" + this.txtAuthor.Text + "', " +
                      "Category = '" + this.cmbCategory.Text + "', " +
                      "Quantity = '" + this.txtQuantity.Text + "', " +
                      "Price = '" + this.txtPrice.Text + "' " +
                      "WHERE BookId = '" + bookId + "'";
            }
            else
            {
                sql = "INSERT INTO BookInfo (BookId, Title, Author, Category, Quantity, Price) " +
                      "VALUES ('" + bookId + "', '" + this.txtTitle.Text + "', '" + this.txtAuthor.Text + "', " +
                      "'" + this.cmbCategory.Text + "', '" + this.txtQuantity.Text + "', '" + this.txtPrice.Text + "')";
            }

            int count = this.Da.ExecuteDMLQuery(sql);
            if (count == 1)
            {
                MessageBox.Show(isEditing ? "Book information has been updated." : "New book has been added.");
            }
            else
            {
                MessageBox.Show(isEditing ? "Update failed." : "Insertion failed.");
            }

            PopulateGridView();
            ClearAll();
            AutoBookIdGenerate();
            isEditing = false;
        }

        private void ClearAll()
        {
            this.txtBookId.Clear();
            this.txtTitle.Clear();
            this.txtAuthor.Clear();
            this.txtQuantity.Clear();
            this.txtPrice.Clear();

            this.cmbCategory.SelectedIndex = -1;
            this.cmbCategory.Text = string.Empty;

            this.dgvBooks.ClearSelection();

            this.txtBookId.Enabled = true;
            isEditing = false;
        }

        private bool IsValidToSave()
        {
            int quantity;
            double price;

                return !string.IsNullOrWhiteSpace(this.txtBookId.Text)
                && !string.IsNullOrWhiteSpace(this.txtTitle.Text)
                && !string.IsNullOrWhiteSpace(this.txtAuthor.Text)
                && !string.IsNullOrWhiteSpace(this.cmbCategory.Text)
                && int.TryParse(this.txtQuantity.Text, out quantity)
                && double.TryParse(this.txtPrice.Text, out price);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            AutoBookIdGenerate();
        }
        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvBooks.CurrentRow != null && this.dgvBooks.CurrentRow.Index >= 0)
            {
                this.txtBookId.Text = this.dgvBooks.CurrentRow.Cells["BookId"].Value.ToString();
                this.txtTitle.Text = this.dgvBooks.CurrentRow.Cells["Title"].Value.ToString();
                this.txtAuthor.Text = this.dgvBooks.CurrentRow.Cells["Author"].Value.ToString();
                this.cmbCategory.Text = this.dgvBooks.CurrentRow.Cells["Category"].Value.ToString();
                this.txtQuantity.Text = this.dgvBooks.CurrentRow.Cells["Quantity"].Value.ToString();
                this.txtPrice.Text = this.dgvBooks.CurrentRow.Cells["Price"].Value.ToString();

                this.txtBookId.Enabled = false;
                isEditing = true;
            }
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
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.MainFormLogin != null && !string.IsNullOrWhiteSpace(this.CurrentUserRole))
            {
                if (this.CurrentUserRole.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    FormAdmin adminForm = new FormAdmin(this.CurrentUserName, this.CurrentUserRole, this.MainFormLogin);
                    adminForm.Show();
                }
                else if (this.CurrentUserRole.Equals("employee", StringComparison.OrdinalIgnoreCase))
                {
                    FormEmployee employeeForm = new FormEmployee(this.CurrentUserName, this.CurrentUserRole, this.MainFormLogin);
                    employeeForm.Show();
                }
                else
                {
                    MessageBox.Show("User role not recognized. Returning to login.", "Error",
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvBooks.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string id = this.dgvBooks.CurrentRow.Cells["BookId"].Value.ToString();
            string title = this.dgvBooks.CurrentRow.Cells["Title"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this book?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
            );

            if (result == DialogResult.No)
                return;

            string sql = "DELETE FROM BookInfo WHERE BookId = '" + id + "'";
            int count = this.Da.ExecuteDMLQuery(sql);

            if (count == 1)
            {
                RenumberBookIds();
                MessageBox.Show(title.ToUpper() + " has been removed from the system.");
            }
            else
            {
                MessageBox.Show("Book could not be deleted.");
            }

            PopulateGridView();
            ClearAll();
            AutoBookIdGenerate();
        }
    
        private void txtSearchByTitle_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM BookInfo WHERE Title LIKE '" + this.txtSearchByTitle.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void cmbFilterbyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterbyCategory.SelectedItem == null)
                return;

            string category = cmbFilterbyCategory.SelectedItem.ToString().Trim();
            string sql;

            if (string.Equals(category, "All", StringComparison.OrdinalIgnoreCase))
            {
                sql = "SELECT * FROM BookInfo;";
            }
            else
            {
                sql = "SELECT * FROM BookInfo WHERE Category = '" + category.Replace("'", "''") + "';";
            }

            PopulateGridView(sql);
        }
    }
}





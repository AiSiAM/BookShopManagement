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
    public partial class FormSaleBooks : Form
    {
        private DataAccess Da = new DataAccess();
        private string CurrentUserName { get; set; }
        private string CurrentUserRole { get; set; }
        private FormLogin MainFormLogin { get; set; }

        public FormSaleBooks()
        {
            InitializeComponent();
            InitializeSellGrid();
        }
        public FormSaleBooks(string userName, string userRole, FormLogin fl) : this()
        {
            this.CurrentUserName = userName;
            this.CurrentUserRole = userRole;
            this.MainFormLogin = fl;
        }

        private void InitializeSellGrid()
        {
            dgvSell.Columns.Clear();
            dgvSell.AutoGenerateColumns = false;

            dgvSell.Columns.Add("colTitle", "Title");
            dgvSell.Columns.Add("colSellQty", "Sell Quantity");
            dgvSell.Columns.Add("colUnitPrice", "Unit Price");
            dgvSell.Columns.Add("colDiscount", "Discount (%)");
            dgvSell.Columns.Add("colTotalPrice", "Total Price");
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.CurrentUserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                FormAdmin adminForm = new FormAdmin(this.CurrentUserName, this.CurrentUserRole, this.MainFormLogin);
                adminForm.Show();
            }
            else if (this.CurrentUserRole.Equals("Employee", StringComparison.OrdinalIgnoreCase))
            {
                FormEmployee employeeForm = new FormEmployee(this.CurrentUserName, this.CurrentUserRole, this.MainFormLogin);
                employeeForm.Show();
            }
            else
            {
                MessageBox.Show("Unknown user role. Returning to login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (this.MainFormLogin != null)
                {
                    this.MainFormLogin.ClearFields();
                    this.MainFormLogin.Show();
                }
                else
                {
                    new FormLogin().Show();

                }
            }
        }

        private void txtAutoSearchTitle_TextChanged(object sender, EventArgs e)
        {
            string keyword = this.txtAutoSearchTitle.Text.Trim();
            string sql = "SELECT Title FROM BookInfo WHERE Title LIKE '" + keyword + "%';";
            DataSet ds = this.Da.ExecuteQuery(sql);
            dgvSearchTitle.DataSource = ds.Tables[0];
        }

        private void dgvSeaechTitle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedTitle = dgvSearchTitle.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAutoSearchTitle.Text = selectedTitle;

                string sql = "SELECT Price, Quantity FROM BookInfo WHERE Title = '" + selectedTitle + "'";
                DataSet ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    txtPrice.Text = row["Price"].ToString();
                    txtQuantity.Text = row["Quantity"].ToString();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                    txtPrice.Clear();
                    txtQuantity.Clear();
                }
            }
        }

        private void ClearAll()
        {
            txtAutoSearchTitle.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtQuantity.Clear();
            txtSellQuantity.Clear();
            dgvSearchTitle.DataSource = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private string AutoSaleIdGenerate()
        {
            string sql = "SELECT COUNT(*) FROM SaleInfo;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]) + 1;
            return "SL" + count.ToString("D3");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAutoSearchTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                    string.IsNullOrWhiteSpace(txtSellQuantity.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Please fill in all fields before adding to cart.");
                    return;
                }

                string title = txtAutoSearchTitle.Text.Trim();
                int availableQty = int.Parse(txtQuantity.Text.Trim());
                int sellQty = int.Parse(txtSellQuantity.Text.Trim());
                decimal unitPrice = decimal.Parse(txtPrice.Text.Trim());
                decimal discount = 0;

                if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
                    discount = decimal.Parse(txtDiscount.Text.Trim());

                if (sellQty > availableQty)
                {
                    MessageBox.Show("Not enough stock available!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal discountAmountPerUnit = (unitPrice * discount) / 100;
                decimal finalUnitPrice = unitPrice - discountAmountPerUnit;
                decimal totalPrice = finalUnitPrice * sellQty;

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSell);

                row.Cells[0].Value = title;
                row.Cells[1].Value = sellQty;
                row.Cells[2].Value = unitPrice;
                row.Cells[3].Value = discount + "%";
                row.Cells[4].Value = totalPrice;

                dgvSell.Rows.Add(row);

                MessageBox.Show("Book added to cart with discount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvSell.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSell.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvSell.Rows.Remove(row);
                    }
                }
                MessageBox.Show("Selected item(s) removed from cart.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSell.Rows.Count == 0)
                {
                    MessageBox.Show("Cart is empty. Add items first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string saleId = AutoSaleIdGenerate();
                string saleDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                foreach (DataGridViewRow row in dgvSell.Rows)
                {
                    if (row.IsNewRow) continue;

                    string title = row.Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[1].Value);
                    decimal price = Convert.ToDecimal(row.Cells[2].Value);
                    string discountStr = row.Cells[3].Value.ToString().Replace("%", "");
                    decimal discount = string.IsNullOrWhiteSpace(discountStr) ? 0 : Convert.ToDecimal(discountStr);
                    decimal total = Convert.ToDecimal(row.Cells[4].Value);

                    string insertSql =
                        "INSERT INTO SaleInfo (SaleId, TitleSell, QuantitySell, PriceSell, DiscountSell, TotalSellPrice, SaleDate) " +
                        "VALUES ('" + saleId + "', '" + title.Replace("'", "''") + "', '" + quantity + "', '" + price + "', '" + discount + "', '" + total + "', '" + saleDate + "');";

                    string updateStockSql =
                        "UPDATE BookInfo SET Quantity = Quantity - " + quantity + " WHERE Title = '" + title.Replace("'", "''") + "';";

                    this.Da.ExecuteDMLQuery(insertSql);
                    this.Da.ExecuteDMLQuery(updateStockSql);
                }

                MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormBill billForm = new FormBill(saleId);
                billForm.Show();

                dgvSell.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sale failed: " + ex.Message);
            }

        }

    }

}
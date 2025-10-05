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
    public partial class FormBill : Form
    {
        private string SaleId { get; set; }
        private DataAccess Da = new DataAccess();

        public FormBill(string saleId)
        {
            InitializeComponent();
            this.SaleId = saleId;
            LoadBillDetails();
        }
        private void LoadBillDetails()
        {
            try
            {
                string sql = "SELECT TitleSell, QuantitySell, PriceSell, TotalSellPrice FROM SaleInfo WHERE SaleId = '" + this.SaleId + "';";
                DataSet ds = this.Da.ExecuteQuery(sql);

                dgvBill.Rows.Clear();

                decimal subtotal = 0;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string title = row["TitleSell"].ToString();
                    int quantity = Convert.ToInt32(row["QuantitySell"]);
                    decimal price = Convert.ToDecimal(row["PriceSell"]);
                    decimal total = Convert.ToDecimal(row["TotalSellPrice"]);

                    dgvBill.Rows.Add(title, quantity, price, total);
                    subtotal += total;
                }

                labSub.Text = "Subtotal: " + subtotal.ToString("0.00") + " Tk";

                decimal totalDiscount = 0;
                string discountSql = "SELECT SUM(DiscountSell * QuantitySell * PriceSell / 100) AS TotalDiscount FROM SaleInfo WHERE SaleId = '" + this.SaleId + "';";
                DataTable dtDiscount = this.Da.ExecuteQueryTable(discountSql);
                if (dtDiscount.Rows.Count > 0 && dtDiscount.Rows[0][0] != DBNull.Value)
                {
                    totalDiscount = Convert.ToDecimal(dtDiscount.Rows[0][0]);
                }

                lblDiscount.Text = "Discount: " + totalDiscount.ToString("0.00") + " Tk";

                decimal grandTotal = subtotal - totalDiscount;
                lblGrandTotal.Text = "Grand Total: " + grandTotal.ToString("0.00") + " Tk";

                lblDateTime.Text = "Date & Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bill: " + ex.Message);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing not implemented yet.");
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Print successful!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

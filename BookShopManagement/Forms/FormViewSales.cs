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
    public partial class FormViewSales : Form
    {
        private DataAccess Da = new DataAccess();
        public FormLogin Fl { get; set; }
        public string CurrentUserName { get; private set; }
        public string CurrentUserRole { get; private set; }

        public FormViewSales()
        {
            InitializeComponent();
            InitializeSaleReportGrid();
            this.Load += FormViewSales_Load;
        }

        public FormViewSales(string userName, string userRole, FormLogin fl) : this() 
        {
            this.CurrentUserName = userName;
            this.CurrentUserRole = userRole.ToLower(); 

            this.Fl = fl;

            if (this.lblRole != null)
            {
                this.lblRole.Text = userRole.ToUpper();
            }
        }

        public FormViewSales(string role, FormLogin fl) : this()
        {
            this.CurrentUserRole = role.ToLower();
            this.Fl = fl;
            if (this.lblRole != null)
            {
                this.lblRole.Text = role.ToUpper();
            }
        }

        private void InitializeSaleReportGrid()
        {
            dgvSaleReport.Columns.Clear();
            dgvSaleReport.AutoGenerateColumns = false;

            dgvSaleReport.Columns.Add("colSaleId", "Sale ID");
            dgvSaleReport.Columns.Add("colTitleSell", "Title");
            dgvSaleReport.Columns.Add("colQuantitySell", "Quantity");
            dgvSaleReport.Columns.Add("colPriceSell", "Unit Price");
            dgvSaleReport.Columns.Add("colDiscountSell", "Discount (%)");
            dgvSaleReport.Columns.Add("colTotalSellPrice", "Total Price");
            dgvSaleReport.Columns.Add("colSaleDate", "Sale Date");

            foreach (DataGridViewColumn col in dgvSaleReport.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadSalesReport()
        {
            try
            {
                string sql = @"SELECT SaleId, TitleSell, QuantitySell, PriceSell, DiscountSell, TotalSellPrice, SaleDate
                              FROM SaleInfo ORDER BY SaleDate DESC;";
                DataSet ds = Da.ExecuteQuery(sql);
                dgvSaleReport.Rows.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int rowIndex = dgvSaleReport.Rows.Add();

                    dgvSaleReport.Rows[rowIndex].Cells["colSaleId"].Value = row["SaleId"].ToString();
                    dgvSaleReport.Rows[rowIndex].Cells["colTitleSell"].Value = row["TitleSell"].ToString();
                    dgvSaleReport.Rows[rowIndex].Cells["colQuantitySell"].Value = row["QuantitySell"].ToString();
                    dgvSaleReport.Rows[rowIndex].Cells["colPriceSell"].Value = row["PriceSell"].ToString();
                    dgvSaleReport.Rows[rowIndex].Cells["colDiscountSell"].Value = row["DiscountSell"].ToString();
                    dgvSaleReport.Rows[rowIndex].Cells["colTotalSellPrice"].Value = row["TotalSellPrice"].ToString();

                    if (DateTime.TryParse(row["SaleDate"].ToString(), out DateTime dt))
                        dgvSaleReport.Rows[rowIndex].Cells["colSaleDate"].Value = dt.ToString("yyyy-MM-dd HH:mm:ss");
                    else
                        dgvSaleReport.Rows[rowIndex].Cells["colSaleDate"].Value = row["SaleDate"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormViewSales_Load(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            string roleToNavigate = this.CurrentUserRole;
            string nameToNavigate = this.CurrentUserName;
            if (string.IsNullOrWhiteSpace(roleToNavigate) && this.lblRole != null)
            {
                roleToNavigate = this.lblRole.Text.Trim().ToLower();
            }
            if (string.IsNullOrWhiteSpace(nameToNavigate))
            {
                nameToNavigate = "";
            }


            if (roleToNavigate == "admin")
            {
                FormAdmin adminForm = new FormAdmin(nameToNavigate, roleToNavigate, this.Fl);
                adminForm.Show();
            }
            else if (roleToNavigate == "employee")
            {
                FormEmployee employeeForm = new FormEmployee(nameToNavigate, roleToNavigate, this.Fl);
                employeeForm.Show();
            }
            else
            {
                MessageBox.Show("User role not recognized or session invalid. Returning to login.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.Fl != null)
                {
                    this.Fl.ClearFields();
                    this.Fl.Show();
                }
                else
                {
                    new FormLogin().Show();
                }
                this.Dispose();
            }
        }
    }
}


            




        




    
    


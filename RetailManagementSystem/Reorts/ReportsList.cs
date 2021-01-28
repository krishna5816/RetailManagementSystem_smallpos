using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailControls;
using RetailManagementSystem.Custom;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.REPORTS
{
    public partial class ReportsList : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public ReportsList()
        {
            InitializeComponent();
            tabPage_sales.Controls.Add(new SalesReport()
            {
                Dock = DockStyle.Fill
            });
            tabPage_purchase.Controls.Add(new PurchaseReport()
            {
                Dock = DockStyle.Fill
            });
            tabPage_Expense.Controls.Add(new ExpenseReport()
            {
                Dock = DockStyle.Fill
            });
        }

        private void lvl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportsList_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.SalesReturns
{
    public partial class Salesreturn : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Salesreturn()
        {
            InitializeComponent();
        }

        private void Salesreturn_Load(object sender, EventArgs e)
        {

        }

        private void betterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton_load_Click(object sender, EventArgs e)
        {
            betterListView1.Items.Clear();
            var load = db.bills.Find(invoicenumber.value);
            foreach (billitem n in db.billitems.Where(o => o.bill_id == load.id).ToList())
            {
               Viewer viewer = new Viewer(n,(int)load.day, betterListView1.Items.Count + 1);
                betterListView1.Items.Add(viewer);

            }
        }
    }
}

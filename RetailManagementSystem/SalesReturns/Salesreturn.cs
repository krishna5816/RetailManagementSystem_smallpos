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
            sumcal();
        }
        decimal total=0;
        decimal dis = 0;
        private void sumcal()
        {
            dis = 0;
            total = 0;
            foreach (ListViewItem lstItem in betterListView_salesreturn.Items) // listView has ListViewItem objects
            {
                dis += Convert.ToDecimal(lstItem.SubItems[5].Text);
                total += Convert.ToDecimal(lstItem.SubItems[6].Text);// Columns 4
            }
            betterTextBox_total.Clear();
            betterTextBox_discount.Clear();
            betterTextBox_total.decVal = total;
            betterTextBox_discount.decVal = dis;
        }

        private void Salesreturn_Load(object sender, EventArgs e)
        {

        }

        private void betterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton_load_Click(object sender, EventArgs e)
        {
            
        }

        private void betterListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void add()
        {
            if (betterListView_salesreturn.SelectedItems.Count > 0)
            {
                (betterListView_salesreturn.SelectedItems[0] as Viewer).add(1);
            }
        }
        void subtract()
        {
            if (betterListView_salesreturn.SelectedItems.Count > 0)
            {
                (betterListView_salesreturn.SelectedItems[0] as Viewer).minus(1);
            }
        }
        void delete()
        {
            if (betterListView_salesreturn.SelectedItems.Count > 0)
            {
                betterListView_salesreturn.Items.Remove(betterListView_salesreturn.SelectedItems[0]);
            }
        }
        private void betterListView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
        public bill bill_id { get; set; }
        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            
            var savecreditnote = new Models.creditnote()
            {
                amount = betterTextBox_total.decVal,
                bill_id = invoicenumber_text.intVal,
                date = Dashboard.Instance.nepaliCalender1.DATESTAMP,
                checkreturnbills=false,
                updated_at = DateTime.Now,
                created_at = DateTime.Now,
            };
            db.creditnotes.Add(savecreditnote);
                var bill = db.bills.Find(invoicenumber_text.intVal);
                var customer = db.customers.Find(bill.customer_id);
                if (customer != null)
                {
                    customer.due -= betterTextBox_total.decVal;
                    db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                }
            bill.checkreturnbills = false;
            db.Entry(bill).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            foreach (var item in betterListView_salesreturn.Items.Cast<SalesReturns.Viewer>().ToList())
            {
                item.save(savecreditnote.id);

            }
            SalesReturns.Printcreditnote print = new Printcreditnote();
            print.print(savecreditnote);
            betterListView_salesreturn.Items.Clear();
            invoicenumber_text.Clear();
            betterTextBox_discount.Clear();
            betterTextBox_total.Clear();
        }

        private void betterListView_salesreturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.F1))
            {
                
                this.add();
                sumcal();
            }
            else if (e.KeyCode == Keys.F2)
            {
                
                this.subtract();
                sumcal();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                this.delete();
                sumcal();
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            betterListView_salesreturn.Items.Clear();
            var load = db.bills.Find(invoicenumber_text.intVal);
            if (load.checkreturnbills == false)
            {
                CustomControls.Alert.show("Not Found", "This bills items are already added in salesreturns", 3000);
                return;
            }
            foreach (billitem n in db.billitems.Where(o => o.bill_id == load.id).ToList())
            {
                
                Viewer viewer = new Viewer(n, (int)load.day, betterListView_salesreturn.Items.Count + 1);
                betterListView_salesreturn.Items.Add(viewer);

            }
            sumcal();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterListView_salesreturn.SelectedItems.Count > 0)
            {
                betterListView_salesreturn.SelectedItems[0].Remove();
                sumcal();
            }
        }
    }
}

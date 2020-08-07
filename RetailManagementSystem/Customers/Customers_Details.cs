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
namespace RetailManagementSystem.CUSTOMERS
{
    public partial class Customers_Details : Form
    {
        int count;
        public int id;
        public Customers_Details(int id)
        {
            InitializeComponent();

            using (var db = new HamroSuperMarketEntities())
            {
                customer c = db.customers.First(o => o.id == id);
                this.id = id;
                customername.Text = c.name;
                customeraddress.Text = c.adress;
                customerphone.Text = c.phone;
                customeremail.Text = c.email;
                customerdue.Text = c.due.ToString();

                foreach (bill b in db.bills.Where(o=>o.customer_id==id).ToList())
                {
                    betterListView1.Items.Add(new ListViewItem(
                        new string[]
                        {
                            b.id.ToString(),
                            b.total.ToString(),
                            b.paid.ToString(),
                            b.due.ToString(),
                           RetailControls.Helpers.DateStampToString(b.day.Value)
                        }
                        ));
                }
            }


        }

        private void Customers_Details_Load(object sender, EventArgs e)
        {
            count=0;
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var paidamount = Convert.ToDecimal(textBox_pay.Text);
                var temp = paidamount;
                decimal duepaid = 0;
                using (var db=new Models.HamroSuperMarketEntities())
                {
                    foreach(var bill in db.bills.Where(o => o.customer_id == this.id).Where(o => o.due > 0).ToList())
                    {
                        if (temp >= bill.due)
                        {
                            var temp1 = bill.due.Value;
                            bill.due = 0;
                            bill.paid = bill.total;
                            db.Entry(bill).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            temp -= temp1;
                            duepaid += temp1;
                        }
                        else
                        {
                            
                            bill.due = bill.due-temp;
                            bill.paid = bill.paid+temp;
                            db.Entry(bill).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            duepaid += temp;
                            temp =0;

                        }
                        if (temp == 0)
                        {
                            break;
                        }


                    }
                        var cus = db.customers.Find(this.id);
                        cus.due -= duepaid;
                        if(cus.due>0 && temp > 0)
                        {
                        if (temp >= cus.due.Value)
                        {
                            duepaid += cus.due.Value;
                            cus.due = 0;
                        }
                        else
                        {
                            duepaid += temp;
                            cus.due -= temp;
                        }
                        }
                        customerdue.Text = cus.due.ToString();
                        db.Entry(cus).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        db.customerpaids.Add(new customerpaid()
                        {
                            customer_id = this.id,
                            amount = duepaid,
                            year = Dashboard.Instance.nepaliCalender1.date.Year,
                            month = Dashboard.Instance.nepaliCalender1.date.Month,
                            day = Dashboard.Instance.nepaliCalender1.date.Day,
                            
                        });
                        db.SaveChanges();
            }
                }
            catch (Exception)
            {

                
            }
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialButton_load_Click(object sender, EventArgs e)
        {
            using (var db=new Models.HamroSuperMarketEntities())
            {
                List<bill> bills =new List<bill>();
                var q = db.bills.Where(o => o.customer_id == this.id);
                if (radioButton_all.Checked)
                {
                    bills=q.ToList();
                }else if (radioButton_due.Checked)
                {
                    bills=q.Where(o => o.due > 0).ToList();

                }else if(radioButton_paid.Checked){
                    bills=q.Where(o => o.due == 0).ToList();
                }
                betterListView1.Items.Clear();
                foreach(bill b in bills)
                {
                    betterListView1.Items.Add(new ListViewItem(
                        new string[]
                        {
                            b.id.ToString(),
                            b.total.ToString(),
                            b.paid.ToString(),
                            b.due.ToString(),
                            b.year.ToString()+"/"+b.month.ToString()+"/"+b.day.ToString(),
                            b.customer.name,
                        }
                        ));
                }
            }
        }

        private void materialButton_duepaid_Click(object sender, EventArgs e)
        {
            ITEMS.ModalBackground m = new ITEMS.ModalBackground();
            var obj = new Duepaids(this.id);
            m.obj = obj;
            m.ShowDialog();
        }
        private void salesForCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
                var sel=Convert.ToInt32( betterListView1.SelectedItems[0].SubItems[0].Text);
                var itemdetails = new Customer_Sale();
                var trance = new ITEMS.ModalBackground();
                trance.obj = itemdetails;
                itemdetails.loaddata(sel);
                trance.ShowDialog();

            }
        }
    }
}

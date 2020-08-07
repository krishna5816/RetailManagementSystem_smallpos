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
using  RetailManagementSystem.Custom;
namespace RetailManagementSystem.VENDORS
{
    public partial class Vendor_Details : Form
    {
        int count = 0;
       
        public Vendor_Details( int id)
        {
            InitializeComponent();
            using (HamroSuperMarketEntities db = new HamroSuperMarketEntities())
            {
                vendor v = db.vendors.First(o => o.id == id);
                this.id = id;
                venname_txt.Text = v.name;
                venaddr_txt.Text = v.adress;
                venphn_txt.Text = v.phoneno;
                venvat_txt.Text = v.vatno;
                venpan_txt.Text = v.panno;
                vendue_txt.Text = v.due.ToString();
                venemail_txt.Text = v.email;
                venadvnc_txt.Text = v.advance.ToString();
            }
        }
        private void Vendor_Details_Load(object sender, EventArgs e)
        {
            
        
        }
       public int id;
        public void loaddata(int id)
       {

           
          
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void refresh()
        {
               
            using (HamroSuperMarketEntities db = new HamroSuperMarketEntities())
            {
                var q = db.supplies;
                IQueryable<supply> supplies=q;
                if (radioButton_all.Checked)
                {
                    supplies = q.Where(o => o.vendor_id == this.id);
                }else if (radioButton_due.Checked)
                {
                    supplies = q.Where(o => o.vendor_id == this.id && o.due>0);

                }
                else if (radioButton_paid.Checked)
                {
                    supplies = q.Where(o => o.vendor_id == this.id && o.due > 0);

                }

                foreach (var item in supplies.ToList())
                {
                    betterListView1.Items.Add(
                        new ListViewItem(
                            new string[]
                            {
                                item.id.ToString(),
                                item.bill_no.ToString(),
                                item.total.ToString(),
                                item.paid.ToString(),
                                item.due.ToString(),
                                RetailControls.Helpers.DateStampToString(item.day.Value)
                            }
                            )
                        );
                }
            }
        }

        private void materialButton_load_Click(object sender, EventArgs e)
        {
            betterListView1.Items.Clear();
            refresh();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var paidamount = Convert.ToDecimal(textBox_pay.Text);
                var temp = paidamount;
                decimal duepaid = 0;
                using (var db = new Models.HamroSuperMarketEntities())
                {
                    foreach (var sup in db.supplies.Where(o => o.vendor_id == this.id).Where(o => o.due > 0).ToList())
                    {
                        if (temp >= sup.due)
                        {
                            var temp1 = sup.due.Value;
                            sup.due = 0;
                            sup.paid = sup.total;
                            db.Entry(sup).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            temp -= temp1;
                            duepaid += temp1;
                        }
                        else
                        {

                            sup.due = sup.due - temp;
                            sup.paid = sup.paid + temp;
                            db.Entry(sup).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            duepaid += temp;
                            temp = 0;

                        }
                        if (temp == 0)
                        {
                            break;
                        }


                    }
                    var ven = db.vendors.Find(this.id);
                    ven.due -= duepaid;
                    if (ven.due > 0 && temp > 0)
                    {
                        if (temp >= ven.due.Value)
                        {
                            duepaid += ven.due.Value;
                            ven.due = 0;
                        }
                        else
                        {
                            duepaid += temp;
                            ven.due -= temp;
                        }
                    }
                    vendue_txt.Text = ven.due.ToString();
                    db.Entry(ven).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    db.supplierpaids.Add(new supplierpaid()
                    {
                        supplier_id = this.id,
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

        private void viewPurchaseItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
                var sel =(Convert.ToInt32 (betterListView1.SelectedItems[0].SubItems[0].Text));
            var itemdetails = new Purchase_items();
            var trance = new ITEMS.ModalBackground();
            trance.obj = itemdetails;
            itemdetails.loaddata(sel);
            trance.ShowDialog();
            }
            
        }
    }
}

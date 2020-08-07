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
using RetailManagementSystem.Custom;
using RetailManagementSystem.Properties;
using RetailManagementSystem.VENDORS;
namespace RetailManagementSystem.stock_Add
{
    public partial class Stock_Add : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();

        public Stock_Add()
        {
            InitializeComponent();
            List<item> items = db.items.ToList();
            foreach (var item in items)
            {
                combobox_itmname.addItem(item, item.id);
            }
            List<vendor> vendors = db.vendors.ToList();
            foreach (var vendor in vendors)
            {
                combobox_supplier.addItem(vendor, vendor.id);
            }

        }
        public decimal Grosstotal
        {
            get
            {
                return Convert.ToDecimal(Grostotal_txt.Text);
            }
            set
            {
                Grostotal_txt.Text = value.ToString();
            }
        }
        public decimal discount
        {
            get
            {
                return Convert.ToDecimal(Discount_txt.Text);
            }
            set
            {
                Discount_txt.Text = value.ToString();
            }
        }
        public decimal taxs
        {
            get
            {
                return Convert.ToDecimal(tax_txt.Text);
            }
            set
            {
                tax_txt.Text = value.ToString();
            }
        }
        public decimal nettotal
        {
            get
            {
                return Convert.ToDecimal(nettotal_txt.Text);
            }
            set
            {
                nettotal_txt.Text = value.ToString();
            }
        }
        public decimal returns
        {
            get
            {
                return Convert.ToDecimal(floatTextBox_Retrun.Text);
            }
            set
            {
                floatTextBox_Retrun.Text = value.ToString();
            }
        }
        public decimal due
        {
            get
            {
                return Convert.ToDecimal(due_txt.Text);
            }
            set
            {
                due_txt.Text = value.ToString();
            }
        }
        public decimal paid
        {
            get
            {
                return Convert.ToDecimal(paid_txt.Text);
            }
            set
            {
                paid_txt.Text = value.ToString();
            }
        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            var obj = new ITEMS.ModalBackground();
            var obj1 = new ITEMS.Item_Add();
            obj1.onDataSaved += Obj1_onDataSaved;
            obj.obj = obj1;
            obj.ShowDialog();
        }

        private void Obj1_onDataSaved(object Sender, DataSaveargs e)
        {
            var i = (e.data as item);
            combobox_itmname.addItem(i,i.id);
        }

        private void Stock_Add_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SupplierCheck_btn.Checked)
            {
                panel_suppliers.Enabled = true;
            }
            else
            {
                panel_suppliers.Enabled = false;
            }
        }

        private void supplieradd_btn_Click(object sender, EventArgs e)
        {
            ITEMS.ModalBackground m = new ITEMS.ModalBackground();
            VENDORS.Vendors_Add obj = new VENDORS.Vendors_Add();
            m.obj = obj;
            obj.onDataSaved += obj_onDataSaved;
            m.ShowDialog();
        }
          void obj_onDataSaved(object Sender, DataSaveargs e)
        {
            vendor c = (vendor)e.data;
            combobox_supplier.addItem(c,c.id);
            combobox_supplier.selectByValue(c.id);
           
        }
        private void materialButton1_Click(object sender, EventArgs e)
          {
            if (rate_fltb.value==0)
            {
                notificationMAnager1.show("please enter your cost price of product", 1000);
                return;
            }
            if (qty_fltb.value==0)
            {
                notificationMAnager1.show("please enter your quantity of product", 1000);
                return;
            }
              try
              {

            var sel = (item)combobox_itmname.getSelectedItem().getdata<item>();
            decimal total;
            total = rate_fltb.value * qty_fltb.value;
            betterlistview1.additem(new string[] { sel.name, rate_fltb.value.ToString(), qty_fltb.value.ToString(), total.ToString(), sel.id.ToString() });
            Grosstotal += total;
           
              }
              catch
              {
                  notificationMAnager1.show("please select items and enter rate and quentity ", 1000);
              }
            combobox_itmname.SelectedItem = -1;
            qty_fltb.Clear();
            rate_fltb.Clear();
          
        }
      
        public void refresstock()
        {
            try
            {
                if (discount > Grosstotal)
                {
                    discount = Grosstotal;
                }
                if (checkBox1_tax.Checked)
                {
                    taxs = (Grosstotal - discount) * (decimal)(0.13);
                }
                else
                {
                    taxs = 0;
                }
                nettotal = Grosstotal - discount + taxs;
                if (paid > nettotal)
                {
                    due = 0;
                   returns = paid - nettotal;

                }
                else
                {

                    due = nettotal - paid;
                   returns = 0;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
            private void Discount_txt_TextChanged(object sender, EventArgs e)
        {
            refresstock();
        }

        private void paid_txt_TextChanged(object sender, EventArgs e)
        {
            refresstock();
        }

        private void checkBox1_tax_CheckedChanged(object sender, EventArgs e)
        {
            refresstock();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (billnum_txt.Text.Trim() == "")
            {
                notificationMAnager1.show("please fill the bill number", 1000);
                return;
            }
           
            supply Supply = new supply()
            {   
                bill_no =billnum_txt.Text,
                paid = paid,
                discount = discount,
                due = due,
                dates = Dashboard.Instance.nepaliCalender1.engdate,
                tax = taxs,
                grosstotal = Grosstotal,
                total = nettotal,
                day = Dashboard.Instance.nepaliCalender1.DATESTAMP,
                created_at=DateTime.Now,
                updated_at=DateTime.Now
                
            };

            if (SupplierCheck_btn.Checked)
            {
                if (combobox_supplier.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select A supplier");
                   
                    return;
                }
                    var selvendor = (vendor)combobox_supplier.getSelectedItem().data;
                    Supply.vendor_id = selvendor.id;
                    var supplier = db.vendors.First(o => o.id == selvendor.id);
                if (checkBox_useadvance.Checked)
                {
                    if (advance_fltb.value >= supplier.advance.Value)
                    {
                        supplier.advance = 0;
                    }
                    else
                    {
                        supplier.advance -=advance_fltb.value;
                    }
                }
                    if (due > 0)
                    {
                        if (checkBox_useadvance.Checked)
                        {
                        if (advance_fltb.value >= due)
                        {
                            due = 0;
                        }
                        else
                        {
                            due-= advance_fltb.value;
                        }
                    }
                        supplier.due += due;
                    }
                db.Entry(supplier).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
                db.supplies.Add(Supply);
                db.SaveChanges();
            foreach (ListViewItem item in betterlistview1.Items)
            {
                   var Item_id = Convert.ToInt32(item.SubItems[4].Text);
                   var  Rate = Convert.ToDecimal(item.SubItems[1].Text);
                   var   Quantity = Convert.ToDecimal(item.SubItems[2].Text);
                   var  Amount = Convert.ToDecimal(item.SubItems[3].Text);
                   var Item = db.items.Find(Item_id);
                   Item.stock += Quantity;
                    Item.buyrate = Rate;
                   db.Entry(Item).State = System.Data.Entity.EntityState.Modified;
                supplyitem supplyitem = new supplyitem()
                {
                    rate = Rate,
                    item_id = Item_id,
                    quantity = Quantity,
                    amount = Amount,
                    supply_id = Supply.id
                };
                db.supplyitems.Add(supplyitem);
                db.SaveChanges();

            }
                betterlistview1.Items.Clear();
                billnum_txt.Clear();
                Grostotal_txt.Clear();
                Discount_txt.Clear();
                paid_txt.Clear();
                tax_txt.Clear();
                due_txt.Clear();
                SupplierCheck_btn.Checked = false;
                
        }

        private void Grostotal_txt_TextChanged(object sender, EventArgs e)
        {
            refresstock();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void supplier_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_supplier.SelectedIndex > -1)
            {
                var sel= (vendor)combobox_supplier.getSelectedItem().data;
                using(var db=new HamroSuperMarketEntities())
                {
                    var sup = db.vendors.Find(sel.id);
                    advance_fltb.value = sup.advance.Value;
                }
            }
        }
        private decimal getTotal()
        {
            decimal Total = 0;
            foreach (ListViewItem item in betterlistview1.Items)
            {
                try
                {
                    Total += Convert.ToDecimal(item.SubItems[3].Text);
                }
                catch (Exception)
                {


                }
            }
            return Total;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterlistview1.SelectedItems.Count > 0)
            {
                betterlistview1.SelectedItems[0].Remove();
                Grosstotal = getTotal();
                refresstock();
            }
        }

        private void combobox_itmname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

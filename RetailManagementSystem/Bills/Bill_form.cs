using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Custom;
using RetailManagementSystem.Models;
using p = RetailControls.PrintHelper;

namespace RetailManagementSystem.Bills_form
{
    public partial class Bill_form : Form

    {
        public static bill instance;
        public static item itemintance;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();

        public bill Bills { get; set; }
        public Bill_form()
        {
            InitializeComponent();

            RetailManagementSystem.Bills.Data.items = db.items.ToList();
            var itms = db.items.ToList();
            var item = itms.Select(o => new RetailManagementSystem.Bills.ItemNameViwer(o) { }).ToArray();
            var barcode = itms.Where(o=>o.barcode.Trim()!=""). Select(o => new RetailManagementSystem.Bills.BarcodeViwer(o) { }).ToArray();
            comboBox_item.Items.AddRange(item);
            comboBox_barcode.Items.AddRange(barcode);
            //foreach (item itm in db.items.ToList())
            //{
            //    comboBox_item.Items.Add(new RetailManagementSystem.Bills.ItemNameViwer(itm));
            //    if (itm.barcode.Trim() != "")
            //    {
            //        comboBox_barcode.Items.Add(new RetailManagementSystem.Bills.BarcodeViwer(itm));
            //    }
            //    refresh();

            //}
            comboBox_item.Focus();
        }

      
        public void refresh()
        {
            comboBox_customer.Items.Clear();
            comboBox_item.Items.Clear();

            List<item> items = db.items.ToList();
            foreach (var item in items)
            {
                comboBox_item.Items.Add(item);
            }
            List<customer> customers = db.customers.ToList();
            foreach (var customer in customers)
            {
                comboBox_customer.Items.Add(customer);
            }
        }
       
        private void itemname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bill_form_Load(object sender, EventArgs e)
        {


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
        public decimal MRP=0;
        public decimal qty=0;
        public decimal discount=0;
        private void refreshData()
        {
            IEnumerable<RetailManagementSystem.Bills_form.Viwer> itemslist = betterlistview1.Items.Cast<RetailManagementSystem.Bills_form.Viwer>();
            Grosstotal_txt.decVal = itemslist.Sum(o => o.grosstotal);
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (floattb_wholesalerate.value == 0)
            {
                notificationMAnager1.show("Please Set your wholesale price of this item", 2000);
                return;
            }
            if (retailrate_fltb.value == 0)
            {
                notificationMAnager1.show("Please Set your retail price of this item", 2000);
                return;
            }
            var sel = (item)comboBox_item.SelectedItem;

            if (comboBox_item.SelectedItem == null)
            {
                notificationMAnager1.show("Please Select Item", 2000);
                return;
            }
            if (qty_fltb.value == 0)
            {
                notificationMAnager1.show("Please Enter Quantity", 2000);
                return;
            }
            if (stock_qty.value < qty_fltb.value)
            {
                notificationMAnager1.show("this item stock is less then your required quantity ", 2000);
                return;
            }
            if (radioButton_retail.Checked == true)
            {
                MRP = retailrate_fltb.value;

            }
           

            if (radioButton_wholesale.Checked == true)
            {
                MRP = retailrate_fltb.value; 
                discount = retailrate_fltb.value - floattb_wholesalerate.value;
            }
           

            var selitem = (item)comboBox_item.SelectedItem;
            IEnumerable<RetailManagementSystem.Bills_form.Viwer> itemslist = betterlistview1.Items.Cast<RetailManagementSystem.Bills_form.Viwer>();

            if (itemslist.Count(o => o.id == selitem.id) > 0)
            {
                RetailManagementSystem.Bills_form.Viwer selecteditem = itemslist.First(o => o.id == selitem.id);
                selecteditem.addItem(qty_fltb.value);
            }
            else
            {
                var newbillitem = new RetailManagementSystem.Bills_form.Viwer(selitem, qty_fltb.value, betterlistview1.Items.Count + 1, MRP,discount);
                newbillitem.modify += () =>
                {
                    this.refreshData();
                };

                betterlistview1.Items.Add(newbillitem);
                refreshData();
            }

            comboBox_barcode.SelectedIndex = -1;
            comboBox_item.SelectedIndex = -1;
            qty_fltb.Clear();
            floattb_wholesalerate.Clear();
            retailrate_fltb.Clear();
            stock_qty.Clear();
            MRP = 0;
            discount = 0;
        }
        public void refresbill()
            { 
            try
            {
                if (Discount_txt.decVal > Grosstotal_txt.decVal)
                {
                    Discount_txt.decVal = Grosstotal_txt.decVal;
                }
                if (checkBox1_tax.Checked)
                {
                    tax_txt.decVal = (Grosstotal_txt.decVal - Discount_txt.decVal) * (decimal)(0.13);
                }
                else
                {
                    tax_txt.decVal = 0;
                }
                nettotal_txt.decVal = Grosstotal_txt.decVal - Discount_txt.decVal + tax_txt.decVal;
                if (paid_txt.decVal > nettotal_txt.decVal)
                {
                    due_txt.decVal = 0;
                    return_fltb.decVal = paid_txt.decVal - nettotal_txt.decVal;

                }
                else
                {

                    due_txt.decVal = nettotal_txt.decVal - paid_txt.decVal;
                    return_fltb.decVal = 0;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void paid_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void checkBox1_tax_CheckedChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            comboBox_customer.Enabled = checkBox1.Checked;
            customeradd_btn.Enabled = checkBox1.Checked;
        }

        private void customeradd_btn_Click(object sender, EventArgs e)
        {
            ITEMS.ModalBackground m = new ITEMS.ModalBackground();
            CUSTOMERS.Customers_Add obj = new CUSTOMERS.Customers_Add();
            m.obj = obj;
            obj.onDataSaved += obj_onDataSaved;
            m.ShowDialog();
        }

        void obj_onDataSaved(object Sender, DataSaveargs e)
        {
            customer c = (customer)e.data;
            comboBox_customer.Items.Add(c);
            comboBox_customer.SelectedItem = c;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (betterlistview1.Items.Count == 0)
            {
                notificationMAnager1.show("please select your items and enter quantity.", 2000);
                return;
            }
            if (due_txt.decVal > paid_txt.decVal)
            {
                notificationMAnager1.show("Please select customer for dueable amount.", 3000);
                return;
            }
            bill savebill = new bill()
            {
                paid = paid_txt.decVal,
                due = due_txt.decVal,
                grosstotal = Grosstotal_txt.decVal,
                discount = Discount_txt.decVal,
                tax = tax_txt.decVal,
                dates = Dashboard.Instance.nepaliCalender1.engdate,
                total = nettotal_txt.decVal,
                day = Dashboard.Instance.nepaliCalender1.DATESTAMP,
                returns = return_fltb.decVal,
                checkreturnbills = true,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            if (checkBox1.Checked == true)
            {
                if (comboBox_customer.SelectedItem != null)
                {
                    var selcustomer = (customer)comboBox_customer.SelectedItem;
                    savebill.customer_id = selcustomer.id;
                    if (Convert.ToDecimal(due_txt.Text) > 0)
                    {
                        var cus = db.customers.Find(selcustomer.id);
                        cus.due += Convert.ToDecimal(due_txt.Text);
                        db.Entry(cus).State = System.Data.Entity.EntityState.Modified;
                    }
                }
                else
                {
                    notificationMAnager1.show("please select old customer or add a new customer ", 2000);
                    return;
                }
            }
            else
            {
                notificationMAnager1.show("please select old customer or add a new customer ", 2000);
                return;
            }
            db.bills.Add(savebill);
            db.SaveChanges();
            foreach (var item in betterlistview1.Items.Cast<Bills_form.Viwer>().ToList())
            {
                item.save(savebill.id);

            }
        

            betterlistview1.Items.Clear();
            Grosstotal_txt.Clear();
            Discount_txt.Clear();
            tax_txt.Clear();
            nettotal_txt.Clear();
            paid_txt.Clear();
            due_txt.Clear();
            qty_fltb.Clear();
            return_fltb.Clear();
            comboBox_item.SelectedIndex = -1;
            comboBox_customer.SelectedIndex = -1;
            floattb_wholesalerate.Clear();
            retailrate_fltb.Clear();
            stock_qty.Clear();
        }

        private void materialButton_SavenPrint_Click(object sender, EventArgs e)
        {
            if (due_txt.decVal!=0)
            {
                if (checkBox1.Checked==false)
                {
                notificationMAnager1.show("Please select customer for dueable amount.", 3000);
                return;
                }
            }
            if (betterlistview1.Items.Count==0)
            {
                notificationMAnager1.show("please select your items and enter quantity.", 2000);
                return;
            }
            bill savebill = new bill()
            {
                paid = paid_txt.decVal,
                due = due_txt.decVal,
                grosstotal = Grosstotal_txt.decVal,
                discount = Discount_txt.decVal,
                tax = tax_txt.decVal,
                dates = Dashboard.Instance.nepaliCalender1.engdate,
                total = nettotal_txt.decVal,
                day = Dashboard.Instance.nepaliCalender1.DATESTAMP,
                returns = return_fltb.decVal,
                checkreturnbills=true,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            if (checkBox1.Checked==true)
            {
               if (comboBox_customer.SelectedItem!=null)
                {
                var selcustomer = (customer)comboBox_customer.SelectedItem;
                savebill.customer_id = selcustomer.id;
                if (Convert.ToDecimal(due_txt.Text) > 0)
                {
                    var cus = db.customers.Find(selcustomer.id);
                    cus.due += Convert.ToDecimal(due_txt.Text);
                    db.Entry(cus).State = System.Data.Entity.EntityState.Modified;
                }                  
                }
                else
                {
                    notificationMAnager1.show("please select old customer or add a new customer ", 2000);
                    return;
                }
            }
            else
            {
                notificationMAnager1.show("please select old customer or add a new customer ", 2000);
                return;
            }
            db.bills.Add(savebill);
            db.SaveChanges();
            foreach (var item in betterlistview1.Items.Cast<Bills_form.Viwer>().ToList())
            {
                item.save(savebill.id);

            }
            var printer = new Bills_form.BillPrinter();
            printer.print(savebill);
            betterlistview1.Items.Clear();
            Grosstotal_txt.Clear();
            Discount_txt.Clear();
            tax_txt.Clear();
            nettotal_txt.Clear();
            paid_txt.Clear();
            due_txt.Clear();
            qty_fltb.Clear();
            return_fltb.Clear();
            comboBox_item.SelectedIndex = -1;
            comboBox_customer.SelectedIndex = -1;
            comboBox_barcode.SelectedIndex = -1;
            floattb_wholesalerate.Clear();
            retailrate_fltb.Clear();
            stock_qty.Clear();
        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            betterlistview1.Items.Clear();
            Grosstotal_txt.Clear();
            Discount_txt.Clear();
            tax_txt.Clear();
            nettotal_txt.Clear();
            paid_txt.Clear();
            due_txt.Clear();
            qty_fltb.Clear();
            return_fltb.Clear();
            comboBox_item.SelectedIndex = -1;
            comboBox_customer.SelectedIndex = -1;
            floattb_wholesalerate.Clear();
            retailrate_fltb.Clear();
            stock_qty.Clear();
                     

        }

        private void customername_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterlistview1.SelectedItems.Count > 0)
            {
                betterlistview1.SelectedItems[0].Remove();
                Grosstotal_txt.decVal = getTotal();
                refresbill();
            }
            else
            {
                notificationMAnager1.show("sdd", 2000);
            }
        }

        private void comboBox_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_item.SelectedIndex > -1)
            {
                var sel =(item)comboBox_item.SelectedItem;
                using (var kdb = new HamroSuperMarketEntities())
                {
                    stock_qty.Text = kdb.items.Find(sel.id).stock.Value.ToString("00.00");
                    retailrate_fltb.Text = kdb.items.Find(sel.id).rate.Value.ToString("00.00");
                    floattb_wholesalerate.value = kdb.items.Find(sel.id).wholesaleprice.Value;
                }
                qty_fltb.Focus();
            }

        }

        private void comboBox_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void return_fltb_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void qty_fltb_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_fltb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialButton1.PerformClick();
            }
        }

        private void paid_txt_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void due_txt_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void Discount_txt_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void tax_txt_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void nettotal_txt_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }

        private void Grosstotal_txt_TextChanged(object sender, EventArgs e)
        {
            refresbill();
        }
       
        private void comboBox_barcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox_barcode.SelectedIndex > -1)
            {
                
                var selitem =comboBox_barcode.SelectedItem as RetailManagementSystem.Bills.BarcodeViwer;
                if (radioButton_retail.Checked)
                {
                    MRP =selitem.Item.rate.Value;
                    floattb_wholesalerate.Enabled = false;
                }
                if (radioButton_wholesale.Checked)
                {
                    MRP = selitem.Item.rate.Value;
                    if (selitem.Item.wholesaleprice>=0)
                    {
                    discount = (decimal)(selitem.Item.rate - selitem.Item.wholesaleprice.Value);
                    retailrate_fltb.Enabled = false;

                    }
                    else
                    {
                        notificationMAnager1.show("your Wholesale price is not set please set your wholesale price", 3000);
                        return;

                    }
                }
                qty = selitem.Item.stock.Value;
                if (qty == 0)
                {
                    notificationMAnager1.show("your stock is not availabe in database", 2000);
                    return;
                }
                IEnumerable<RetailManagementSystem.Bills_form.Viwer> itemslist = betterlistview1.Items.Cast<RetailManagementSystem.Bills_form.Viwer>();
                if (itemslist.Count(o => o.id == selitem.Item.id) > 0)
                {
                    RetailManagementSystem.Bills_form.Viwer selecteditem = itemslist.First(o => o.id == selitem.Item.id);
                    selecteditem.addItem(1);
                }
                else 
                {
                    RetailManagementSystem.Bills_form.Viwer newbillitem = new RetailManagementSystem.Bills_form.Viwer(selitem.Item, 1, betterlistview1.Items.Count + 1, MRP,discount);
                    newbillitem.modify += () =>
                    {
                        this.refreshData();
                    };
                    betterlistview1.Items.Add(newbillitem);
                    refreshData();
                }
            }
            else
            {         
                notificationMAnager1.show("This item's barcode is not available please search in Itemlist", 2000);
                return;
                    
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                comboBox_item.Focus();
            }
            else if (keyData == Keys.F2)
            {
                comboBox_barcode.Focus();
            }
            else if (keyData == Keys.F3)
            {
                qty_fltb.Focus();
            }
            else if (keyData == Keys.F4)
            {
                radioButton_retail.Checked = true;
            }
            else if (keyData == Keys.F5)
            {
                radioButton_wholesale.Checked = true;
            }
            else if (keyData == Keys.F6)
            {
                Discount_txt.Focus();
            }
            else if (keyData == Keys.F7)
            {
                paid_txt.Focus();
            }
            else if (keyData == Keys.F3)
            {
                materialButton2.PerformClick();
            }
            else if (keyData == Keys.F3)
            {
                materialButton_SavenPrint.PerformClick();
            }
            else if (keyData == Keys.F3)
            {
               reset_btn.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void radioButton_retail_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_item_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void radioButton_wholesale_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
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
namespace RetailManagementSystem.CUSTOMERS
{
    public partial class customers_form : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        int count = 0;
        public customers_form()
        {
            InitializeComponent();
        }

        private void customers_form_Load(object sender, EventArgs e)
        {
            foreach (customer n in db.customers.ToList())
            {
                CustomerViwer customerviwer = new CustomerViwer(n);
                listView1.Items.Add(customerviwer);
                
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            ITEMS.ModalBackground m = new ITEMS.ModalBackground();
            CUSTOMERS.Customers_Add obj = new CUSTOMERS.Customers_Add();
            obj.onDataSaved += obj_onDataSaved;
            m.obj = obj;
            m.ShowDialog();
        }

        void obj_onDataSaved(object Sender, DataSaveargs e)
        {
            var i = (customer)e.data;
            CustomerViwer customerviwer = new CustomerViwer(i);
            listView1.Items.Add(customerviwer);


        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            using (var db = new HamroSuperMarketEntities())
            {
                var customers = db.customers.Where(o => o.name.Contains(textBox1.Text) || o.phone == textBox1.Text.Trim()).ToList();
                
                foreach (customer c in customers)
                {
                    CustomerViwer customerviwer = new CustomerViwer(c);
                    listView1.Items.Add(customerviwer);
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            count = 0;
            listView1.Items.Clear();
            if(textBox1.Text.Trim()==""){
                notificationMAnager1.show("Please Enter Customer name to search",1000);
                return;
            }
            using (var db = new HamroSuperMarketEntities())
            {
                var customers = db.customers.Where(o => o.name.Contains(textBox1.Text) || o.phone == textBox1.Text.Trim()).ToList();
                if (customers.Count == 0)
                {
                    notificationMAnager1.show("No Customers Found", 1000);
                    return;
                }
                foreach (customer c in customers)
                {
                    CustomerViwer customerviwer = new CustomerViwer(c);
                    listView1.Items.Add(customerviwer);
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            using (var db = new HamroSuperMarketEntities())
            {
                
                foreach (customer c in db.customers.ToList())
                {
                    CustomerViwer customerviwer = new CustomerViwer(c);
                    listView1.Items.Add(customerviwer);
                }
            }
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                count = 0;
                listView1.Items.Clear();
                if (textBox1.Text.Trim() == "")
                {
                    notificationMAnager1.show("Please Enter Customer name to search", 1000);
                    return;
                }
                using (var db = new HamroSuperMarketEntities())
                {
                    var customers = db.customers.Where(o => o.name.Contains(textBox1.Text) || o.phone==textBox1.Text.Trim()).ToList();
                    if (customers.Count == 0)
                    {
                        notificationMAnager1.show("No Customers Found", 1000);
                        return;
                    }
                    foreach (customer c in customers)
                    {
                        CustomerViwer customerviwer = new CustomerViwer(c);
                        listView1.Items.Add(customerviwer);
                    }
                }

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                contextMenuStrip1.Enabled = true;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
           
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var sel = listView1.SelectedItems[0] as CustomerViwer;
                var cusedit = new Customeredited_form();
                cusedit.loaddata(sel.id);
                cusedit.onDataEdited += Cusedit_onDataEdited;
                ITEMS.ModalBackground m = new ITEMS.ModalBackground();
                m.obj = cusedit;
                m.ShowDialog();
            }

        }

        private void Cusedit_onDataEdited(object Sender, DataSaveargs e)
        {
            var sel = listView1.SelectedItems[0] as CustomerViwer;
            sel.update(e.data as customer);
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            { 
                if (MessageBox.Show("Do You want To Delete this Customer", "Customers", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
            try
            {
                    var sel = listView1.SelectedItems[0] as CustomerViwer;
                    using (var db = new HamroSuperMarketEntities())
                    {
                        var cus = db.customers.Find(sel.id);
                        db.Entry(cus).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                    }
                    sel.Remove();
                    }
                    catch(Exception ex)
                    {
                        notificationMAnager1.show("you can not delete this customer", 2000);
                    }
            }
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
            
                    var sel = listView1.SelectedItems[0] as CustomerViwer;
                    var cusedit = new Customers_Details(sel.id);
                    cusedit.ShowDialog();
            }
        }
    }
}

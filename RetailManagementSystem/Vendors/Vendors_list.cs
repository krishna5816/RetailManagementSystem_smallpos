
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
using RetailManagementSystem.VENDORS;
namespace RetailManagementSystem.VENDORS
{
    public partial class Vendors_list : Form
    {
        public int id;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Vendors_list()
        {
            InitializeComponent();
        }
        bool hassearchable = false;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (var db = new HamroSuperMarketEntities())
            {

                foreach (Models.vendor n in db.vendors.Where(o => o.name.Contains(search_txt.Text)).ToList())
                {
                   VenViwer  venViwer = new VenViwer(n);
                    listView1.Items.Add(venViwer);

                }
            }
        }
        private void employee_name_Click_1(object sender, EventArgs e)
        {
            ITEMS.ModalBackground m = new ITEMS.ModalBackground();
            VENDORS.Vendors_Add obj = new Vendors_Add();
            obj.onDataSaved += obj_onDataSaved;
            m.obj = obj;
            m.ShowDialog();
        }

        private void obj_onDataSaved(object Sender, DataSaveargs e)
        {
            var i = (vendor)e.data;
            VenViwer venviwer = new VenViwer(i);
            listView1.Items.Add(venviwer);
        }

        private void materialButton5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        int count = 0;
        private void Vendors_list_Load(object sender, EventArgs e)
        {
            foreach (vendor n in db.vendors.ToList())
            {
                VenViwer ven = new VenViwer(n);
                listView1.Items.Add(ven);
            }
        }
        private void panel4_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Do You want To Delete this Customer", "Customers", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var sel = listView1.SelectedItems[0] as VenViwer;
                    using (var db = new HamroSuperMarketEntities())
                    {
                        var cus = db.vendors.Find(sel.id);
                        db.Entry(cus).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                    }
                    sel.Remove();
                }
            }
            }catch(Exception ex)
            {
                notificationMAnager1.show("you can not delete this party records", 2000);
            }

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var sel = listView1.SelectedItems[0] as VenViwer;
                var venedit = new Vendors_edit();
                venedit.loaddata(sel.id);
                venedit.onDataEdited += venedit_onDataEdited;
                ITEMS.ModalBackground m = new ITEMS.ModalBackground();
                m.obj = venedit;
                m.ShowDialog();
            }
        }

        private void venedit_onDataEdited(object Sender, DataSaveargs e)
        {
            var sel = listView1.SelectedItems[0] as VenViwer;
            sel.update(e.data as vendor);
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

                var sel = listView1.SelectedItems[0] as VenViwer;
                var vendetail = new Vendor_Details(sel.id);
                vendetail.ShowDialog();
            }
        }
    }
}


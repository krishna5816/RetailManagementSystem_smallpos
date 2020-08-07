using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailManagementSystem.Custom;
using System.Windows.Forms;
using RetailManagementSystem.Models;

namespace RetailManagementSystem.ITEMS
{
    public partial class Item_List : Form
    {
        public Item_List()
        {
            InitializeComponent();
            using (var db = new HamroSuperMarketEntities())
            {

                foreach (item n in db.items.ToList())
                {
                    ItemViwer itemviwer = new ItemViwer(n,betterListView1.Items.Count+1);
                    betterListView1.Items.Add(itemviwer);

                }
                foreach (var cats in db.categories.ToList())
                {
                    comboBox_categories.Items.Add(cats);
                }
                foreach (ListViewItem lstItem in betterListView1.Items) // listView has ListViewItem objects
                {
                    valorSum += ((Convert.ToDecimal(lstItem.SubItems[3].Text)) * (Convert.ToDecimal(lstItem.SubItems[5].Text)));
                    label_totalmrp.Text = valorSum.ToString("0.##");
                    totalwholesale +=((Convert.ToDecimal(lstItem.SubItems[4].Text))*(Convert.ToDecimal(lstItem.SubItems[5].Text))); ;
                    label_totalwholesale.Text = totalwholesale.ToString("0.##");
                    totalcost += ((Convert.ToDecimal(lstItem.SubItems[6].Text))* (Convert.ToDecimal(lstItem.SubItems[5].Text))); ;
                    label_totalcost.Text = totalcost.ToString("0.##");
                }
                this.id = id;
            }
        }
        int id;
        public int count = 0;
        public decimal valorSum, totalcost, totalwholesale = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            betterListView1.Items.Clear();
            using (var db = new HamroSuperMarketEntities())
            {

                foreach (item n in db.items.Where(o => o.name.Contains(searchbox.Text)).ToList())
                {
                    ItemViwer itemviwer = new ItemViwer(n,betterListView1.Items.Count+1);
                    betterListView1.Items.Add(itemviwer);

                }
            }
        }


        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //TextBox t = (TextBox)sender;
            //t.ForeColor = Color.Black;
            //if (!hassearchable)
            //{
            //t.Text = "";
            //}
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            //TextBox t = (TextBox)sender;
            //if (t.Text.Trim() == "")
            //{
            //t.ForeColor = Color.Gray;
            //t.Text = "Search Item";
            //hassearchable = false;
            //}
            //hassearchable = true;
        }

        private void employee_name_Click(object sender, EventArgs e)
        {

        }

        void obj1_onDataSaved(object Sender, DataSaveargs e)
        {
           
            var i = (item)e.data;
            betterListView1.Items.Add(new ItemViwer(i,betterListView1.Items.Count+1));
            
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void Item_List_Load(object sender, EventArgs e)
        {


        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            searchbox.Text = "";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
                contextMenuStrip.Enabled = true;
            }
            else
            {
                contextMenuStrip.Enabled = false;

            }
        }

        private void comboBox_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_categories.SelectedIndex > -1)
            {
                betterListView1.Items.Clear();
                using (var db = new HamroSuperMarketEntities())
                {
                    if (comboBox_categories.SelectedIndex == 0)
                    {
                        foreach (item n in db.items.ToList())
                        {
                            ItemViwer itemviwer = new ItemViwer(n,betterListView1.Items.Count+1);
                            betterListView1.Items.Add(itemviwer);
                        }

                    }
                    else
                    {
                        var sel = comboBox_categories.SelectedItem as category;
                        foreach (item n in db.items.Where(o => o.category_id == sel.id).ToList())
                        {
                            ItemViwer itemviwer = new ItemViwer(n,betterListView1.Items.Count+1);
                            betterListView1.Items.Add(itemviwer);

                        }

                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView1.SelectedItems[0] as ItemViwer;
            var k = new Item_edit();
            k.loaddata(sel.id);
            k.onDataEdited += K_onDataEdited;
            var b = new ModalBackground();
            b.obj = k;
            b.ShowDialog();
        }

        private void K_onDataEdited(object Sender, DataSaveargs e)
        {
            var sel = betterListView1.SelectedItems[0] as ItemViwer;
            sel.update((e.data as item));
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Do you Delete this item?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {

                    using (var db = new HamroSuperMarketEntities())
                    {
                        var sel = betterListView1.SelectedItems[0] as ItemViwer;
                        var itm = db.items.Find(sel.id);
                        db.Entry(itm).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        sel.Remove();
                    }
                    }
                    catch (Exception ex)
                    {
                        notificationMAnager1.show("this item you can not delete", 2000);
                    }
                }
            }
        }

        private void addcate_btn_Click(object sender, EventArgs e)
        {
            var trance = new ModalBackground();
            var addcate = new ITEMS.Categories();
            addcate.FormClosed += Addcate_FormClosed;
            trance.obj = addcate;
            trance.ShowDialog();
        }

        private void Addcate_FormClosed(object sender, FormClosedEventArgs e)
        {
            comboBox_categories.Items.Clear();
            comboBox_categories.Items.Add("All");
            using (var db = new HamroSuperMarketEntities())
            {


                foreach (var cats in db.categories.ToList())
                {
                    comboBox_categories.Items.Add(cats);
                }
            }
        }

        private void add_obj(object sender, DataSaveargs e)
        {
            var i = (category)e.data;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            var obj = new ModalBackground();
            var obj1 = new Item_Add();
            obj1.onDataSaved += obj1_onDataSaved;
            obj.obj = obj1;
            obj.ShowDialog();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void betterListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

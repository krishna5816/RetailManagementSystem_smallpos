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
using RetailControls;

namespace RetailManagementSystem.ITEMS
{

    public partial class Item_edit : Form
    {
         public delegate void datasaved(Object Sender,DataSaveargs e);
        public event datasaved  onDataEdited;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Item_edit()
        {
            InitializeComponent();
            foreach (var item in db.categories.ToList())
            {
                comboBox_category.Items.Add(item);
            }
        }
        public class edit
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.FromArgb(0, 150, 150);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Item_edit_Load(object sender, EventArgs e)
        {
          
        }

        public void loaddata(int id)
        {
            item a = db.items.Where(o => o.id == id).First();
            itemeditname_txt.Text = a.name;
            bettertextbox_barcode.Text = a.barcode;
            comboBox_category.Text = ((a.category as Models.category).name);
            stock_fltb.value = a.stock.Value;
            price_fltb.value = a.rate.Value;
            floattb_wholesaleprice.value = a.wholesaleprice.Value;
            floattb_cost.value = a.buyrate.Value;
            this.id = id;
        }
        int id;
        private void label2_Click(object sender, EventArgs e)
        {
           if(itemeditname_txt.Text.Trim()=="")
            {
                notificationMAnager1.show("please enter your item name", 1000);
                return;
            }
            if (comboBox_category.SelectedItem == null)
            {
                notificationMAnager1.show("please select catrgory", 1000);
                return;
            }
            

            if (bettertextbox_barcode.Text.Trim() == "")
            {
                notificationMAnager1.show("Point Barcode Reader properly to the product or, if product has no Barcode then, type 'Na' in barcode field", 2000);
                bettertextbox_barcode.Focus();               
                return;
            }
            if (floattb_cost.value > price_fltb.value)
            {
                if (Comformation.ShowModal("Please Confirm Your Selling Rate", ", Your selling price is less then cost price please check and confirm", true) == DialogResult.OK) ;
            }
            if (floattb_wholesaleprice.value > price_fltb.value)
            {
                if (Comformation.ShowModal("Please Confirm Your wholesale Rate", ", are you  sure your selling price is less then wholesale ?", true) == DialogResult.OK) ;
            }
            if (floattb_wholesaleprice.value == 0)
            {
                floattb_wholesaleprice.value = price_fltb.value;
            }
            else
            {
                floattb_wholesaleprice.value = floattb_wholesaleprice.value;
            }
            try
            {
            item a = db.items.Where(o => o.id == id).First();
            a.name = itemeditname_txt.Text;
            a.category_id = (comboBox_category.SelectedItem as Models.category).id;
            a.stock = stock_fltb.value;
            a.rate = price_fltb.value;
            a.buyrate = floattb_cost.value;
            a.barcode = bettertextbox_barcode.Text;
            a.wholesaleprice = floattb_wholesaleprice.value;
            a.created_at = DateTime.Now;
            a.updated_at = DateTime.Now;
            db.Entry(a).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            if (onDataEdited != null)
            {
                onDataEdited(this, new DataSaveargs() { data = a });
            }
            }
            catch (Exception)
            {
                notificationMAnager1.show("data can not be saved", 1000);
            }
            this.Close();
        }

        private void stock_fltb_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

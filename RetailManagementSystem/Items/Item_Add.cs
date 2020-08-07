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
    public partial class Item_Add : Form
    {
        public delegate void datasaved(Object Sender,DataSaveargs e);
        public event datasaved  onDataSaved;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Item_Add()
        {
            InitializeComponent();
            foreach (var item in db.categories.ToList())
            {
                comboBox_category.Items.Add(item);
            }
        }
        public Form Back;
        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        
        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

      
        private void vendors_nsme_Click(object sender, EventArgs e)
        {
            if (itemname.Text.Trim() == "")
            {
                notificationMAnager1.show("please enter the item name",1000);
                itemname.Focus();
                return;
                }
            if (pricce_fltb.value==0)
            {
                notificationMAnager1.show("please enter the item price",1000);
                pricce_fltb.Focus();
                return;
            }
            if (textBox_barcode.Text.Trim() == "")
            {
                notificationMAnager1.show("Point Barcode Reader properly to the product or, if product has no Barcode then, type 'Na' in barcode field", 2000);
                textBox_barcode.Focus();              
                return;
            }
            if (comboBox_category.SelectedIndex < 0)
            {
                notificationMAnager1.show("Please Select a Category", 1000);
                return;
            }
            if (floattb_cost.value > pricce_fltb.value)
            {
                if (Comformation.ShowModal("Please Confirm Your Selling Rate", ", Your selling price is less then cost price please check and confirm", true) == DialogResult.OK) ;
                            
            }
            if (floattb_wholesaleprice.value > pricce_fltb.value)
            {
                if (Comformation.ShowModal("Please Confirm Your wholesale Rate", ", are you  sure your selling price is less then wholesale ?", true) == DialogResult.OK) ;
            }
            if (floattb_wholesaleprice.value == 0)
            {
                floattb_wholesaleprice.value = pricce_fltb.value;
            }
            else
            {
                floattb_wholesaleprice.value = floattb_wholesaleprice.value;
            }
            try
            {
                item i = new item(); 
                i.name = itemname.Text;
                i.stock = qty_fltb.value;
                i.rate = pricce_fltb.value;
                i.buyrate= floattb_cost.value;
                i.barcode = textBox_barcode.Text;
                i.wholesaleprice = floattb_wholesaleprice.value;
                i.category_id = (comboBox_category.SelectedItem as category).id;
                i.created_at = DateTime.Now;
                i.updated_at = DateTime.Now;
            db.items.Add(i);
            db.SaveChanges();
            
            if (onDataSaved != null)
            {
                onDataSaved(this, new DataSaveargs() { data = i });
            }
            notificationMAnager1.show("Successfully Data are Saved......", 10000);
            this.Close();
            }
            catch (Exception ex)
            {
                notificationMAnager1.show("data is not save Please Try Again"+ex.Message, 10000);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pricce_fltb_TextChanged(object sender, EventArgs e)
        {

        }

        private void floattb_wholesaleprice_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

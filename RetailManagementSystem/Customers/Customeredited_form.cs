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
    public partial class Customeredited_form : Form
    {
        public delegate void datasaved(Object Sender, DataSaveargs e);
        public event datasaved onDataEdited;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Customeredited_form()
        {
            InitializeComponent();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public void loaddata(int id)
        {
            customer c = db.customers.Where(o => o.id == id).First();
            customername.Text = c.name;
            customeradress.Text = c.adress;
            customerphoneno.Text = c.phone;
            customeremail.Text = c.email;
            cusdue_txt.Text = c.due.ToString();
            this.id = id;
        }
        int id;
        private void label2d_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

            if (cusname.Text.Trim() == "")
            {
                notificationMAnager1.show("plese Enter customer name", 1000);
                return;
            }
            if (cusadr.Text.Trim() == "")
            {
                notificationMAnager1.show("plese Enter customer address", 1000);
                return;
            }
            if (cusphn.Text.Trim() == "")
            {
                notificationMAnager1.show("plese Enter customer phone", 1000);
                return;
            }
            try
            {
            customer c = db.customers.Where(o => o.id == id).First();
             c.name=customername.Text;
             c.adress= customeradress.Text;
             c.email=customeremail.Text;
            c.phone=customerphoneno.Text;
            c.due =Convert.ToDecimal( cusdue_txt.Text);
            c.created_at = DateTime.Now;
            c.updated_at = DateTime.Now;
            db.Entry(c).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            if (onDataEdited != null)
            {
                onDataEdited(this, new DataSaveargs() { data = c });
            }

            }
            catch (Exception)
            {

                notificationMAnager1.show("data are not saved ", 1000);
            }
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customeredited_form_Load(object sender, EventArgs e)
        {

        }
    }
}

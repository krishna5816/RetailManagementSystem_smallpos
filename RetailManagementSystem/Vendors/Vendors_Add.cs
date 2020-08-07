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

namespace RetailManagementSystem.VENDORS
{
    public partial class Vendors_Add : Form
    {
        public delegate void datasaved(Object Sender, DataSaveargs e);
        public event datasaved onDataSaved;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Vendors_Add()
        {
            InitializeComponent();
        }

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

        private void label2_Click(object sender, EventArgs e)
        {
            if (venname_txt.Text.Trim() == "")
            {
                notificationMAnager1.show("please fill the name", 1000);
                return;
            }
            if (venaddr_txt.Text.Trim() == "")
            {
                notificationMAnager1.show("please fill the address", 1000);
                return;
            }
            if (venphn_txt.Text == "")
            {
                notificationMAnager1.show("please fill the phone", 1000);
                return;
            }
            try
            {

                vendor ven = new vendor
                {

                    name = venname_txt.Text,
                    adress = venaddr_txt.Text,
                    panno = pannum_txt.Text,
                    email = vanemail_txt.Text,
                    phoneno = venphn_txt.Text,
                    vatno = vatnum_txt.Text,
                    advance = Convert.ToDecimal(vanadvnc_txt.Text),
                    due = Convert.ToDecimal(vendue_txt.Text),
                    created_at=DateTime.Now,
                    updated_at=DateTime.Now
                };
            db.vendors.Add(ven);
            db.SaveChanges();
        
            if (onDataSaved != null)
            {
                onDataSaved(this, new DataSaveargs() { data = ven });
            }
            notificationMAnager1.show("data are successfully saved", 1000);
            this.Close();
            
            }catch(Exception ex)
            {
                notificationMAnager1.show("data are is not save please try again", 1000);
                this.Close();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.VENDORS;
using RetailManagementSystem.Custom;
using RetailManagementSystem.Properties;
using RetailManagementSystem.Models;

namespace RetailManagementSystem.VENDORS
{
    public partial class Vendors_edit : Form
    {

        public delegate void datasaved(Object Sender, DataSaveargs e);
        public event datasaved onDataEdited;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Vendors_edit()
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
            Pen pp = new Pen(new SolidBrush(Color.Teal), 1);
            pp.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            Panel p = (Panel)sender;
            var rect = new Rectangle(1, 1, p.Width - 2, p.Height - 2);
            e.Graphics.DrawRectangle(pp, rect);
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
            vendor a = db.vendors.Where(o => o.id == id).First();
            venname_txt.Text = a.name;
            venaddr_txt.Text = a.adress;
            pannum_txt.Text = a.panno;
            vanemail_txt.Text = a.email;
           vatnum_txt.Text = a.vatno;
            venphn_txt.Text = a.phoneno;
            vendue_txt.Text = a.due.ToString();
            vanadvnc_txt.Text = a.advance.ToString();

            this.id = id;
        } 
        int id;
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
                vendor vendor = db.vendors.Where(o => o.id == id).First();
                vendor.name = venname_txt.Text;
                vendor.adress = venaddr_txt.Text;
                vendor.panno = pannum_txt.Text;
                vendor.email = vanemail_txt.Text;
                vendor.vatno = vatnum_txt.Text;
                vendor.phoneno = venphn_txt.Text;
                vendor.due =Convert.ToDecimal( vendue_txt.Text);
                vendor.advance = Convert.ToDecimal(vanadvnc_txt.Text);
                vendor.created_at = DateTime.Now;
                vendor.updated_at = DateTime.Now;
                db.Entry(vendor).State = System.Data.Entity.EntityState.Modified;
                 db.SaveChanges();
                 notificationMAnager1.show("successfully data has been saved", 10000);
            if (onDataEdited != null)
            {
                onDataEdited(this, new DataSaveargs() { data = vendor });
            }
            }
            catch (Exception)
            {
               notificationMAnager1.show("please try again",1000);
            }
            this.Close();
            }
        }
    }

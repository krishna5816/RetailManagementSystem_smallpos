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
namespace RetailManagementSystem.VENDORS
{
    public partial class paidvendor : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public paidvendor()
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
        public int id;
        private void label2_Click(object sender, EventArgs e)
        {
            if (amount_txt.Text.Trim() == "")
            {
                notificationMAnager1.show("please enter the amount", 1000);
                return;
            }
            try
            {
                supplierpaid paidvendor = new supplierpaid()
                {
                    paiddate = nepaliCalender1.engdate,
                    amount = Convert.ToDecimal(amount_txt.Text),
                    supplier_id=this.id
                };
                db.supplierpaids.Add(paidvendor);
                db.SaveChanges();
                notificationMAnager1.show("data are successfully saved",1000);
            }
            catch (Exception ex)
            {
                notificationMAnager1.show("some error please try again", 1000);
                return;
            }
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

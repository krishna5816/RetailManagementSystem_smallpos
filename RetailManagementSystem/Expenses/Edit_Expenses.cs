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
namespace RetailManagementSystem.Expenses
{
    public partial class Edit_Expenses : Form
    {
        public delegate void datasaved(Object Sender, DataSaveargs e);
        public event datasaved dataedited;

        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Edit_Expenses()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }
        public void loaddata(int id)
        {
            expence exp = db.expences.Where(o => o.id == id).First();
            expname.Text = exp.name;
            nepaliCalender1.engdate = Convert.ToDateTime(exp.dates);
            expamount.Text =exp.amount.ToString();
            expdescription.Text=exp.descriptions;

            this.id =id;
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
        int id;
        private void label2_Click(object sender, EventArgs e)
        {
            if (expname.Text.Trim() == "" || expamount.Text.Trim() == "" || expdescription.Text.Trim() == "")
            {
                notificationMAnager1.show("please fill the data", 2000);
                return;
            }
            try
            {
            expence exp = db.expences.Where(o =>o.id == id).First();
            exp.name = expname.Text;
            exp.amount =Convert.ToDecimal( expamount.Text);
            exp.descriptions = expdescription.Text;
            exp.dates = nepaliCalender1.engdate;
            exp.day = nepaliCalender1.DATESTAMP;
            exp.created_at = DateTime.Now;
            exp.updated_at=DateTime.Now;
            db.Entry(exp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            notificationMAnager1.show("data are successfully edited", 2000);
            this.Dispose();
            }
            catch(Exception ex)
            {
                notificationMAnager1.show("some error please try again", 2000);
            }

        }
    }
}

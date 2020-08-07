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
namespace RetailManagementSystem.Expenses
{
    public partial class Add_Expenses : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Add_Expenses()
        {
            InitializeComponent();
        }

        public int category_id { get; set; }
        
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public int categorys_id;
        private void label2_Click(object sender, EventArgs e)
        {
            expence exp = new expence();
            exp.expencecategory_id = category_id;
            exp.name = expname.Text;
            exp.amount =Convert.ToDecimal( expamount.Text);
            exp.descriptions = expdescription.Text;
            exp.dates = nepaliCalender1.engdate;
            exp.day = nepaliCalender1.DATESTAMP;
            exp.updated_at = DateTime.Now;
            exp.created_at = DateTime.Now;
            db.expences.Add(exp);
            db.SaveChanges();
            this.Close();
        }
    }
}

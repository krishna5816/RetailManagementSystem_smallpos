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
    public partial class Add_Expensecat : Form
    {
        public delegate void addhandler(object sender, Custom.DataSaveargs e);
        public event addhandler add;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Add_Expensecat()
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

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {

            expencecategory exp = new expencecategory();
            exp.name = itemname.Text;
            exp.created_at = DateTime.Now;
            exp.updated_at = DateTime.Now;
            db.expencecategories.Add(exp);
             
            db.SaveChanges();
                if (add !=null)
                {
                    add(this, new Custom.DataSaveargs
                    {
                        data = exp
                    });
                }
            notificationMAnager1.show("data has been successfully seved", 2000);
            itemname.Clear();
            this.Dispose();
            }
            catch(Exception ex)
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}

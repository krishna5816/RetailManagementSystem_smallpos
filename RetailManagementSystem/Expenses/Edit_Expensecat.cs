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
    public partial class Edit_Expensecat : Form
    {
        public delegate void edithandler(object sender, Custom.DataSaveargs e);
        public event edithandler edit;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Edit_Expensecat()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }
        int id;
        public void loaddata(int id)
        {
            var exp = db.expencecategories.Where(o => o.id == id).First();
            expname_txt.Text=exp.name;
            this.id = id;
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
            if (expname_txt.Text.Trim() == "")
            {
                notificationMAnager1.show("please fill the expenses category name", 2000);
                return;
            }
            try
            {
            expencecategory expense = db.expencecategories.Where(o => o.id == id).First();
            expense.name = expname_txt.Text;
            
            db.Entry(expense).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
                if (edit != null)
                {
                    edit(this, new Custom.DataSaveargs
                    {
                        data = expense
                    });
                }
            notificationMAnager1.show("data are successfully saved", 2000);
            this.Dispose();
            }
            catch(Exception ex)
            {
                notificationMAnager1.show(" please try again", 2000);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

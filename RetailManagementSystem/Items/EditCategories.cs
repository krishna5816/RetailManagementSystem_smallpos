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
namespace RetailManagementSystem.ITEMS
{
    public partial class EditCategories : Form
    {
        public delegate void edithandler(object sender, DataSaveargs e);
        public event edithandler edit;
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public EditCategories()
        {
            InitializeComponent();
           
        }
        int id;
        public void loadata(int id)
        {
            
            var editdata = db.categories.Where(o => o.id == id).First();
            textBox1_name.Text = editdata.name;
            this.id =id;
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {

            if (textBox1_name.Text.Trim() == "")
            {
                notificationMAnager1.show("please enter category", 1000);
                return;
            }
            var editcate = db.categories.Where(o => o.id == id).First();
            editcate.name = textBox1_name.Text;
            editcate.updated_at = DateTime.Now;
            editcate.created_at = DateTime.Now;
            db.Entry(editcate).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            
                notificationMAnager1.show("successfully modify your category", 1000);
                this.Close();
            if (edit != null)
            {
                edit(this, new DataSaveargs()
                {
                    data=editcate
                });
            }
            }catch(Exception ex)
            {
                notificationMAnager1.show("your category is not modify please try agarin", 1000);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCategories_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Categories : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        int mode = 0;
        public Categories()
        {
            InitializeComponent();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int id;
        private void vendors_nsme_Click(object sender, EventArgs e)
        {
            using (var db=new HamroSuperMarketEntities())
            {
                if (textBox_name.Text.Trim() == "")
                {
                    notificationMAnager1.show("Please Enter Category Name", 1000);
                    return;
                }
                try
                {

                    category category = new category
                    {
                        name = textBox_name.Text,
                        created_at = DateTime.Now,
                        updated_at=DateTime.Now
                    };
                    db.categories.Add(category);
                    db.SaveChanges();
                    listBox1.Items.Add(category);
                    textBox_name.Clear();
                }
                catch (Exception ex)
                {
                    notificationMAnager1.show(" your category is not save please try again", 1000);
                }
                }
               
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
            if (listBox1.SelectedItems.Count > 0)
            {
                var sel = listBox1.SelectedItems[0]  as category;
                var cateedit = new ITEMS.EditCategories();
                cateedit.loadata(sel.id);
                cateedit.edit += edit_obj;
                ITEMS.ModalBackground m = new ITEMS.ModalBackground();
                m.obj = cateedit;
                m.ShowDialog();
                
            }
           
        }

        private void edit_obj(object sender, DataSaveargs e)
        {
            listBox1.Items.Clear();
            foreach (category n in db.categories.ToList())
            {
                listBox1.Items.Add(n);
            }
        }
        
        private void Categories_Load(object sender, EventArgs e)
        {
            foreach (category n in db.categories.ToList())
            {
                listBox1.Items.Add(n);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class Expense_List : Form
    {
        public Expense_List()
        {
            InitializeComponent();
            using (var db = new HamroSuperMarketEntities())
            {
                foreach (expencecategory item in db.expencecategories.ToList())
                {

                    var cat = new expensecat_viwer()
                    {
                        id = item.id,
                        category_name = item.name,
                        Dock = DockStyle.Top,
                    };
                    cat_loader.Controls.Add(cat);
                }

            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Expense_List_Load(object sender, EventArgs e)
        {
        }

        private void cat_loader_ControlAdded(object sender, ControlEventArgs e)
        {
            refreshcontrol();
        }

        private void cat_loader_ControlRemoved(object sender, ControlEventArgs e)
        {
            refreshcontrol();
        }

        private void refreshcontrol()
        {
            var count = 0;
            cat_loader.VerticalScroll.Value=0;
            foreach (Control item in cat_loader.Controls)
            {
                item.Location = new Point(5,40*count+2);
                count += 1;
            }
        }

        private void employee_name_Click(object sender, EventArgs e)
        {
            var addcate = new Add_Expensecat();
            var modal = new ITEMS.ModalBackground();
            addcate.add += Obj_add;
            modal.obj = addcate;
            modal.ShowDialog();
        }

        private void Obj_add(object sender, Custom.DataSaveargs e)
        {
            var i = (expencecategory)e.data;
            var exp = new expensecat_viwer
            {
                id = i.id,
                category_name = i.name
            };
            cat_loader.Controls.Add(exp);
            
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var obj = new Expencesview();
            var modal = new ITEMS.ModalBackground();
            modal.obj = obj;
            modal.ShowDialog();
        }

        private void cat_loader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in cat_loader.Controls)
            {
                var c = item as expenses_viwer;
                if (c.namecategory.ToLower().Contains(search_txt.Text.ToLower()))
                {
                    c.Show();
                }
                else
                {
                    c.Hide();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.Expenses
{
    public partial class expensecat_viwer : UserControl
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public expensecat_viwer()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string category_name
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var editform = new Expenses.Edit_Expensecat();
            var trance = new ITEMS.ModalBackground();
            editform.loaddata(this.id);
            trance.obj = editform;
            editform.edit += Obj_edit;
            trance.ShowDialog();
        }

        private void Obj_edit(object sender, Custom.DataSaveargs e)
        {
            var i = (expencecategory)e.data;
            id = i.id;
            label1.Text = i.name;
        }

       
        private void materialButton1_delete_Click(object sender, EventArgs e)
        {
            try
            {

            expencecategory exp = db.expencecategories.Where(o => o.id == this.id).First();
            db.Entry(exp).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            notificationMAnager1.show("the data are successfully deleted", 2000);
            this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                notificationMAnager1.show("it has many sub type of expences first delete all sub type of expences", 4000);
                return;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Add_Expenses exp = new Add_Expenses();
            exp.category_id = this.id;
            exp.ShowDialog();
        }

        private void expensecat_viwer_Load(object sender, EventArgs e)
        {

        }
    }
}

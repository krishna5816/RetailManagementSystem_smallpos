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
using RetailManagementSystem.Custom;
using RetailControls;
using RetailManagementSystem.Properties;
namespace RetailManagementSystem.Expenses
{
    public partial class expenses_viwer : UserControl
    {
        
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public expenses_viwer()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string namecategory
        {
            set
            {
                expname_lbl.Text = value;
            }
            get
            {
                return expname_lbl.Text;
            }
        }
        public DateTime date
        {
            set
            {
                date_lbl.Text = NepDateConverter.EngToNep(value).ToString();
            }
            get
            {
                return Convert.ToDateTime(date_lbl.Text);
            }
        }
        public decimal amount
        {
            set
            {
                amount_lbl.Text = value.ToString();
            }
            get
            {
                return Convert.ToDecimal( amount_lbl.Text);
            }
        }
        private void expenses_viwer_Load(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

            var obj = new ITEMS.ModalBackground();
            var obj1 = new Edit_Expenses();
            obj.obj = obj1;
            obj1.loaddata(this.id);
            obj1.dataedited += obj1_onDataEdited;
            obj.ShowDialog();  
        }
        decimal n;
        void obj1_onDataEdited(object Sender, Custom.DataSaveargs e)
        {
            var i = (expence)e.data;
            this.namecategory = i.name;
            this.date = Convert.ToDateTime(i.dates);
            this.amount = Convert.ToDecimal(i.amount);
            

        }
       
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
            expence exp = db.expences.Where(o => o.id ==this.id).First();
            db.Entry(exp).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            this.Parent.Controls.Remove(this);
            
            notificationMAnager1.show("data are successfully deleted", 2000);
            }
            catch (Exception ex)
            {
                notificationMAnager1.show("it has some problem please try again", 2000);
                return;
            }
        }

        private void view_detail_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailManagementSystem.CUSTOMERS
{
    public partial class Duepaids : Form
    {
        public Duepaids(int id)
        {
            InitializeComponent();
            using (var db=new Models.HamroSuperMarketEntities())
            {
                foreach (var item in db.customerpaids.Where(o=>o.customer_id==id).ToList())
                {
                    betterListView1.Items.Add(new ListViewItem(new string[]{
                        item.amount.ToString(),
                        item.year.ToString()+"/"+item.month.ToString()+"/"+item.day.ToString()
                    }));
                }
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

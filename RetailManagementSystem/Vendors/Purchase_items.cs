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

namespace RetailManagementSystem.VENDORS
{
    public partial class Purchase_items : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Purchase_items()
        {
            InitializeComponent();

        }
        int i=1;
        public void loaddata(int id)
        {
           
           foreach (var itm in db.supplies.Where(o=>o.id==id).ToList())
            {
                foreach (var item in itm.supplyitems)
                {

                betterListView1.Items.Add(
                    new ListViewItem(
                        new string[]
                        {
                                item.id.ToString(),
                                item.supply.bill_no.ToString(),
                                item.item.ToString(),
                                item.item.category.name.ToString(),
                                item.quantity.ToString(),
                                item.rate.ToString(),
                                RetailControls.Helpers.DateStampToString(item.supply.day.Value)
                        }
                        )
                    );
                }
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Purchase_items_Load(object sender, EventArgs e)
        {
            
        }
    }
}          
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
namespace RetailManagementSystem.CUSTOMERS
{
    public partial class Customer_Sale : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Customer_Sale()
        {
            InitializeComponent();
        }

        private void Customer_Sale_Load(object sender, EventArgs e)
        {

        }
        public void loaddata(int id)
        {

           
                foreach (var item in db.bills.Find(id).billitems.ToList())
                {

                    betterListView1.Items.Add(
                        new ListViewItem(
                            new string[]
                            { 
                                item.id.ToString(),
                                item.item.name,
                                item.item.category.name.ToString(),
                                item.quantity.ToString(),
                                item.rate.ToString(),
                               RetailControls.Helpers.DateStampToString(item.bill.day.Value)
                            }
                            )
                        );
                }
            

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

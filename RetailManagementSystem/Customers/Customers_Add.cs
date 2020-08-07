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
namespace RetailManagementSystem.CUSTOMERS
{
    public partial class Customers_Add : Form
    {
        public delegate void datasaved(Object Sender, DataSaveargs e);
        public event datasaved onDataSaved;

        public Customers_Add()
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
            if (customername.Text.Trim() == "") 
            {
                notificationMAnager1.show("Please enter and customer name ", 1000);
                return;
            }
            if(customeradress.Text.Trim() == "")
            {
                notificationMAnager1.show("Please enter and customer address ", 1000);
                return;
            }
            if (customerphoneno.Text.Trim() == "")
            {
                notificationMAnager1.show("Please enter and customer address ", 1000);
                return;
            }
            try
            {
                using (var db = new HamroSuperMarketEntities())
                {
                    customer i = new customer()
                    {
                        name = customername.Text,
                        adress = customeradress.Text,
                        phone = customerphoneno.Text,
                        email = customeremail.Text,
                        due =Convert.ToDecimal( due_txt.Text),
                        created_at=DateTime.Now,
                        updated_at=DateTime.Now
                    };
                    db.customers.Add(i);
                    db.SaveChanges();
                    if (onDataSaved != null)
                    {
                        onDataSaved(this, new DataSaveargs() { data = i });
                    }
                    notificationMAnager1.show("Customer added", 1000);
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                notificationMAnager1.show("Data Cannot be Saved Pleasetry again", 1000);
                Console.WriteLine(ex.Message);
            }
        }
    }
}

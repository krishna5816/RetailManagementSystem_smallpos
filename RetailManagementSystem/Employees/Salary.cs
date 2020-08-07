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

namespace RetailManagementSystem.EMPLOYEES
{
    public partial class Salary : Form
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public Salary()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string name { get; set; }
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
            if (nepaliCalender1From.engdate > nepaliCalender2To.engdate)
            {
                var notification =new RetailControls.NotificationMAnager();
                notification.show("beging date can not be bigger then finising date", 2000);
                return;
            }
            if (Amountofsalary.Text.Trim() == "")
            {
                var notification = new RetailControls.NotificationMAnager();
                notification.show("please enter the amout", 2000);
                return;
            }
            if (!(Convert.ToDecimal(Amountofsalary.Text) > 0))
            {
                var notification = new RetailControls.NotificationMAnager();
                notification.show("enter the salary'amount in positive value", 2000);
                return;
            }
            try
            {

            salary sal = new salary();
            sal.employee_id = this.id;
            sal.form = nepaliCalender1From.engdate;
            sal.toto = nepaliCalender2To.engdate;
            sal.amount = Convert.ToDecimal(Amountofsalary.Text);
            sal.dates = Dashboard.Instance.nepaliCalender1.engdate;
            sal.day = nepaliCalender1From.DATESTAMP;
            sal.today = nepaliCalender2To.DATESTAMP;
            db.salaries.Add(sal);
            db.SaveChanges();
            var notification = new RetailControls.NotificationMAnager();
            notification.show("Salary Added for " + this.name, 2000);
            this.Dispose();
            }

            catch (Exception ex)
            {
                var notification = new RetailControls.NotificationMAnager();
                notification.show("please enter the correct value" + this.name, 2000);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailManagementSystem.EMPLOYEES
{
    public partial class Advance : Form
    {
        public Advance()
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
             if (Amountoadvance.Text.Trim() == "")
            {
                var notification = new RetailControls.NotificationMAnager();
                notification.show("please enter the amout", 2000);
                return;
            }
            if (!(Convert.ToDecimal(Amountoadvance.Text) > 0))
            {
                var notification = new RetailControls.NotificationMAnager();
                notification.show("enter the salary'amount in positive value", 2000);
                return;
            }
            using (var db = new Models.HamroSuperMarketEntities())
            {
                try
                {
                    db.advances.Add(
                        new Models.advance()
                        {
                            employee_id = this.id,
                            amount = Convert.ToDecimal(Amountoadvance.Text),
                            dates = Dashboard.Instance.nepaliCalender1.engdate,
                            day = Dashboard.Instance.nepaliCalender1.date.Day,
                            month = Dashboard.Instance.nepaliCalender1.date.Month,
                            year = Dashboard.Instance.nepaliCalender1.date.Day,
                            updated_at = DateTime.Now,
                            created_at=DateTime.Now
                        });
                db.SaveChanges();
                var notification=new RetailControls.NotificationMAnager();
                notification.show("Advance added for"+this.name,2000);
                this.Dispose();
                }
                catch (Exception ex )
                {
                    var notification=new RetailControls.NotificationMAnager();
                    notification.show("Advance cannot be saved",2000);
            
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}

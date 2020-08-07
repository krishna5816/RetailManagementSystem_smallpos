using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Custom;
using RetailManagementSystem.Models;
using RetailManagementSystem.EMPLOYEES;
using RetailManagementSystem.Custom;
namespace RetailManagementSystem.EMPLOYEES
{
    public partial class Employees_Add : Form
    {
        public delegate void datasaved(object sender, Advanceformclosedargs e);
        public event datasaved ondatasaved;
        HamroSuperMarketEntities db= new HamroSuperMarketEntities();
        public Employees_Add()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            string image = "";
            string documents = "";
            if (!(System.IO.Directory.Exists("employee/images/")))
            {
                System.IO.Directory.CreateDirectory("employee/images/");
            }
            if (EmpDocument.documents.Count > 0)
            {
                foreach (var  document in EmpDocument.documents)
                {
                    string timestamp=DateTime.Now.ToFileTime().ToString();
                   var destinationpath="employee/images/"+timestamp+System.IO.Path.GetExtension(document.Value);
                   System.IO.File.Copy(document.Value, destinationpath);
                   documents += destinationpath + "|";
                }
            }

            if (EmpImage.ImageLoc!=null )
            {
                if (EmpImage.ImageLoc != "")
                {

                string timestamp = DateTime.Now.ToFileTime().ToString();
                var destinationpath = "employee/images/" + timestamp + System.IO.Path.GetExtension(EmpImage.ImageLoc);
                System.IO.File.Copy(EmpImage.ImageLoc, destinationpath);
                image = destinationpath;
                }
            }
            if (EmpName.Text.Trim() == "" || EmpAdr.Text.Trim() == "" || EmpPhn.Text.Trim() == "" ||EmpEmail.Text.Trim()==""||EmpSalary.Text.Trim() == "")
            {
                notificationMAnager1.show("please enter correct data", 1000);
                return;
            }
            if (!(Convert.ToDecimal(EmpSalary.Text) > 0))
            {
                notificationMAnager1.show("please enter the right value", 1000);
                return;
            }
            employee emp = new employee()
            {
                photo=image,
                docs=documents
            };
            emp.name = EmpName.Text;
            emp.adress = EmpAdr.Text;
            emp.phone = EmpPhn.Text;
            emp.email = EmpEmail.Text;
            emp.startdate =  Convert.ToDateTime( Dashboard.Instance.nepaliCalender1.engdate);
            emp.salary = Convert.ToDecimal(EmpSalary.Text);
            db.employees.Add(emp);
            db.SaveChanges();
            if (ondatasaved != null)
            {
                ondatasaved(this, new Advanceformclosedargs() { data = emp });
            }
            notificationMAnager1.show("data are successfully added in list", 10000);
            this.Dispose();
        }

        private void imageLoader1_Load(object sender, EventArgs e)
        {

        }

        private void documentsLoader1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

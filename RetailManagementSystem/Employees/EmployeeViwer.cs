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
namespace RetailManagementSystem.EMPLOYEES
{
    public partial class EmployeeViwer : UserControl
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        public EmployeeViwer()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string name
        {
            get
            {
                return EmpName.Text;
            }
            set
            {
                EmpName.Text = value;

            }
        }
        public string addr
        {
            get
            {
                return EmpAddr.Text;
            }
            set
            {
                EmpAddr.Text = value;
            }
        }
        public string phone
        {
            get
            {
                return EmpPhn.Text;
            }
            set
            {
                EmpPhn.Text = value;
            }
        }
        public decimal salary
        {
            get
            {
                return Convert.ToDecimal(EmpSalary.Text);
            }
            set
            {
                EmpSalary.Text = value.ToString();
            }
        }
       
        
        private void EmployeeViwer_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeViwer_Paint(object sender, PaintEventArgs e)
        {
            var rect = new Rectangle(1, 1, this.Bounds.Width - 2, this.Bounds.Height - 2);
            Pen p = new Pen(new SolidBrush(Color.FromArgb(0, 70, 166)), 2);
            e.Graphics.DrawRectangle(p, rect);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var emp = new Employees_edited();
            var emp1 =new ITEMS.ModalBackground();
            emp1.emp1 = emp;
            emp.loaddata(this.id);
            emp.onDataEdited +=obj1_onDataEdited;
            emp.ShowDialog();
        }
        void obj1_onDataEdited(object Sender, Custom.DataSaveargs e)
        {
            var i = (employee)e.data;
            this.name = i.name;
            this.addr = i.adress;
            this.phone = i.phone;
            this.salary =Convert.ToDecimal( i.salary);
            
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
            using (var db = new Models.HamroSuperMarketEntities())
            {
                var emp = db.employees.Where(o => o.id == this.id).Single();
                db.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                this.Parent.Controls.Remove(this);
            }

            }
            catch
            {
                notificationMAnager1.show("this data was saved in bill please first  clear from the bill", 2000);
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            var back = new ITEMS.ModalBackground();
            var salaryform = new Salary()
            {
                id = this.id,
                name = this.name
            };
            back.obj = salaryform;
            back.ShowDialog();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            var back = new ITEMS.ModalBackground();
            var advanceform = new Advance()
            {
                id = this.id,
                name = this.name
            };
            back.obj = advanceform;
            back.ShowDialog();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            var back = new ITEMS.ModalBackground();
            var advanceform = new EmployeeDetails()
            {
                id=this.id
            };
            back.obj = advanceform;
            back.ShowDialog();
        }

        private void EmpPhn_Click(object sender, EventArgs e)
        {

        }

        private void EmpSalary_Click(object sender, EventArgs e)
        {

        }
    }
}

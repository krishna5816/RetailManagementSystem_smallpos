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
using RetailManagementSystem.EMPLOYEES;
using RetailControls;
namespace RetailManagementSystem.EMPLOYEES
    

{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }
        int count = 0;
        int count1 = 0;
        public int id { get; set; }
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            employee emp = db.employees.Where(o => o.id == this.id).First();
            empname.Text = emp.name;
            empadr.Text = emp.adress;
            emphn.Text = emp.phone;
            empemail.Text = emp.email;
            empsalary.Text = emp.salary.ToString();
          
            foreach (salary sal in db.salaries.Where(o=>o.employee_id==this.id).ToList())
            {
                SalaryViwer s = new EMPLOYEES.SalaryViwer()
                {
                    employee_id=(int)sal.employee_id,
                    statdate=(DateTime)sal.form,
                    todate=(DateTime)sal.toto,
                    paiddate=(DateTime)sal.dates,
                    salaryamount=(decimal)sal.amount,
                    
                };
              
                s.Location = new Point(5, count *40  + 5);
                count += 1;
                panel2.Controls.Add(s);
                s.Show();
                
            }
            foreach (advance  advance in db.advances.Where(o=>o.employee_id==this.id).ToList())
            {
                AdvanceViwer advanceviwer = new EMPLOYEES.AdvanceViwer()
                {
                    id=advance.id,
                   empid=(int)advance.employee_id,
                   amount=(decimal)advance.amount,
                   date= (DateTime)advance.dates
                };
                advanceviwer.Location = new Point(5, count1 * 40 + 4);
                count1 += 1;
                panel3.Controls.Add(advanceviwer);
                advanceviwer.Show();
            }
            
        }
        private void label11_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

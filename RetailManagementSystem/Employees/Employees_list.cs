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
namespace RetailManagementSystem.EMPLOYEES
{
    public partial class employees_list : Form
    {
        public employees_list()
        {
            InitializeComponent();
        }
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        private void employee_name_Click(object sender, EventArgs e)
        {
            ITEMS.ModalBackground m = new ITEMS.ModalBackground();
            EMPLOYEES.Employees_Add obj = new EMPLOYEES.Employees_Add();
            obj.ondatasaved += obj_ondatasaved;
            m.obj = obj;
            m.ShowDialog(); 
        }

        void obj_ondatasaved(object sender, Custom.Advanceformclosedargs e)
        {
            var emp = (employee)e.data;
            var k = new EmployeeViwer() { 
                id=emp.id,
                name=emp.name,
                salary=(decimal)emp.salary,
                phone=emp.phone,
                addr=emp.adress
            };
            panel4.Controls.Add(k);
        }

       

        private void materialButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employees_list_Load(object sender, EventArgs e)
        {
            List<employee> employeese = db.employees.ToList();
            foreach (employee emp in employeese)
            {
                var k = new EmployeeViwer()
                {
                    id = emp.id,
                    name = emp.name,
                    salary = (decimal)emp.salary,
                    phone = emp.phone,
                    addr = emp.adress
                };
                panel4.Controls.Add(k);

            }
        }

        private void panel4_ControlAdded(object sender, ControlEventArgs e)
        {
            refreshpanel();

        }

        private void panel4_ControlRemoved(object sender, ControlEventArgs e)
        {
            refreshpanel();
        }

        void refreshpanel()
        {
            var i=0;
            foreach (Control c in panel4.Controls)
            {
                c.Location = new Point(5, i * 65 + 5);
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control emp in panel4.Controls)
            {
                var c = emp as EmployeeViwer;
                if (c.name.ToLower().Contains(searchbox_txt.Text.ToLower()))
                {
                    c.Show();
                }
                else
                {
                    c.Hide();
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            searchbox_txt.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailControls;
using RetailManagementSystem.Models;
namespace RetailManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Instance = this;
            name_lbl.Text = RetailManagementSystem.Properties.Settings.Default.Name;
        }
        Bills_form.Bill_form bill_Form;
        private void Clocktimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void nepaliCalender1_Load(object sender, EventArgs e)
        {

        }
        
        private void materialButton1_Click(object sender, EventArgs e)

        {
            ITEMS.Item_List obj = new ITEMS.Item_List();
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            obj.FormClosed += Obj_FormClosed;
            panel4.Controls.Add(obj);
            obj.Show();
            obj.BringToFront();
            obj.Show();
            menu_panel.Hide();
        }

        private void Obj_FormClosed(object sender, FormClosedEventArgs e)
        {
            bill_Form.refresh();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            CUSTOMERS.customers_form obj = new CUSTOMERS.customers_form();
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            panel4.Controls.Add(obj);
            obj.Show();
            obj.BringToFront();
            obj.Show();
            menu_panel.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setting_Click(object sender, EventArgs e)
        {

        }

        //private void employee_name_Click(object sender, EventArgs e)
        //{
        //    EMPLOYEES.employees_list obj = new EMPLOYEES.employees_list();
        //    obj.TopLevel = false;
        //    obj.Location = new Point(0, 0);
        //    obj.Dock = DockStyle.Fill;
        //    panel4.Controls.Add(obj);
        //    obj.Show();
        //    obj.BringToFront();
        //    obj.Show();
        //    menu_panel.Hide();    
        //}

        private void Dashboard_Load(object sender, EventArgs e)
        {
            bill_Form = new Bills_form.Bill_form();
            bill_Form.TopLevel = false;
            bill_Form.Location = new Point(0, 0);
            bill_Form.Dock = DockStyle.Fill;
            panel4.Controls.Add(bill_Form);
            bill_Form.Show();
            menu_panel.Hide();
        }

        public void showForms(Form obj)
        {
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            panel4.Controls.Add(obj);
            obj.BringToFront();
            obj.Show();
        }


        private void reports_Click(object sender, EventArgs e)
        {
            REPORTS.ReportsList obj = new REPORTS.ReportsList();
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            panel4.Controls.Add(obj);
            obj.Show();
            obj.BringToFront();
            obj.Show();
            menu_panel.Hide();
        }

        private void vendors_nsme_Click(object sender, EventArgs e)
        {
            VENDORS.Vendors_list obj = new VENDORS.Vendors_list();
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            panel4.Controls.Add(obj);
            obj.Show();
            obj.BringToFront();
            obj.Show();
            menu_panel.Hide();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Expenses.Expense_List obj = new Expenses.Expense_List();
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            panel4.Controls.Add(obj);
            obj.Show();
            obj.BringToFront();
            obj.Show();
            menu_panel.Hide();
        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            stock_Add.Stock_Add obj = new stock_Add.Stock_Add();
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            panel4.Controls.Add(obj);
            obj.Show();
            obj.BringToFront();
            obj.Show();
            menu_panel.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu_panel.Show();
            menu_panel.BringToFront();
            panel3.SendToBack();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            menu_panel.Hide();
        }

        private void materialButton2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_salesreturn_Click(object sender, EventArgs e)
        {
            SalesReturns.Salesreturn obj = new SalesReturns.Salesreturn();
            obj.TopLevel = false;
            obj.Location = new Point(0, 0);
            obj.Dock = DockStyle.Fill;
            panel4.Controls.Add(obj);
            obj.Show();
            obj.BringToFront();
            obj.Show();
            menu_panel.Hide();
        }
    }
    
       
    
}
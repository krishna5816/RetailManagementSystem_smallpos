using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Custom;
using RetailManagementSystem.Models;
using RetailControls;

namespace RetailManagementSystem.EMPLOYEES
{
    public partial class SalaryViwer : UserControl
    {
        
        public int id { get; set; }
        public int employee_id
        {
            get;
            set;
        }
        public DateTime statdate
        {
            set
            {
                startdate.Text = NepDateConverter.EngToNep(value).ToString();
            }
            get
            {
                return Convert.ToDateTime(startdate.Text);
            }
        }
        public DateTime todate
        {
            set
            {
                lastdate.Text = NepDateConverter.EngToNep (value).ToString();
            }
            get
            {
                return Convert.ToDateTime(lastdate.Text);
            }
    }
        public decimal salaryamount
        {
            set
            {
                amount.Text = value.ToString();
            }
            get
            {
                return Convert.ToDecimal(amount.Text);
            }
        }
        public DateTime paiddate
        {
            set
            {
                date1.Text = RetailControls.NepDateConverter.EngToNep( value).ToString();
            }
            get
            {
                return Convert.ToDateTime(date1.Text);
            }
        }
      
        public SalaryViwer()
          {
    
          InitializeComponent();
        }

        private void itemedit_btn_Click(object sender, EventArgs e)
        {
        
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (HamroSuperMarketEntities db = new HamroSuperMarketEntities())
            {
                salary sal = db.salaries.Where(o => o.id == id).First();
                db.Entry(sal).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

            }
        }

        private void SalaryViwer_Load(object sender, EventArgs e)
        {
        
        }

    }
}

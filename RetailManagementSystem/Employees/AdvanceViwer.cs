using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailControls;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.EMPLOYEES
{
    public partial class AdvanceViwer : UserControl
    {
        public int id { get; set; }
        public int empid
        {
            set;
            get;
           
        }
        public decimal amount
        {
            set
            {
                AdvanceAmount.Text = value.ToString();
            }
        }
        public DateTime date
        {
            set
            {
                advancepaiddate.Text =RetailControls.NepDateConverter.EngToNep(value).ToString();
            }
        }
        public AdvanceViwer()
        {
            InitializeComponent();
        }

        private void AdvanceViwer_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (HamroSuperMarketEntities db = new HamroSuperMarketEntities())
            {
                advance advance = db.advances.Where(o => o.id == this.id).First();
                db.Entry(advance).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}

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
namespace RetailManagementSystem.VENDORS
{
    public partial class PaidViwer : UserControl
    {
        public PaidViwer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public DateTime datetime
        {
            set
            {
                date_lbl.Text = NepDateConverter.EngToNep(value).ToString();

            }
            get
            {
              return  Convert.ToDateTime(date_lbl.Text);
            }
        }
        private void paidvender_Load(object sender, EventArgs e)
        {

        }
    }
}

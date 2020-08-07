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
using RetailManagementSystem.Properties;
using RetailManagementSystem.Models;
using RetailControls;
namespace RetailManagementSystem.VENDORS
{
    public partial class Billviwer : UserControl
    {
        public Billviwer()
        {
            InitializeComponent();
        }
        public DateTime datetime
        {
            set
            {
                date_lbl.Text = NepDateConverter.EngToNep(value).ToString();
            }
            get
            {
                return Convert.ToDateTime(date_lbl.Text);
            }
        }
        private void Billviwer_Load(object sender, EventArgs e)
        {

        }
    }
}

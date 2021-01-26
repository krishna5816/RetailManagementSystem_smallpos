using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class ADBS : UserControl
    {
        public override string ToString()
        {
            if (mode == 0)
            {
                return dateTimePicker1.Text;
            }
            else
            {
                return nepaliCalender1.Datestamp.ToNepaliDate();
            }
        }
        public int datestamp
        {
            get
            {
                return nepaliCalender1.Datestamp;
            }
            set
            {
                nepaliCalender1.Datestamp = value;
            }
        }

        public DateTime dateTime
        {
            get
            {
                return nepaliCalender1.DateTime;
            }
            set
            {
                nepaliCalender1.DateTime = value;
            }
        }
        public ADBS()
        {
            InitializeComponent();
        }

        private int _mode = 0;
        public int mode
        {
            get
            {
                return _mode;

            }
            set
            {
                _mode = value;
                if (value == 0)
                {
                    materialButton_adbs.Text = "AD";
                    dateTimePicker1.BringToFront();
                }
                else
                {
                    materialButton_adbs.Text = "BS";
                    nepaliCalender1.BringToFront();
                }
            }
        }
        private void materialButton_adbs_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;
            }
            else
            {
                mode = 0;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            nepaliCalender1.DateTime = dateTimePicker1.Value;
        }

        private void nepaliCalender1_Load(object sender, EventArgs e)
        {

        }

        private void nepaliCalender1_dateChange(int year, int month, int day)
        {
            dateTimePicker1.Value = nepaliCalender1.DateTime;
        }
    }
}

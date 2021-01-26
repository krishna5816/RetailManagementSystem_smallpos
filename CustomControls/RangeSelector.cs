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
    public partial class RangeSelector : UserControl
    {

        public int DurationType
        {
            get
            {
                return comboBox_duration.SelectedIndex;

            }
        }
        public bool valid
        {
            get
            {
                return comboBox_duration.SelectedIndex > 0;
            }
        }
        public bool fyvalid
        {
            get
            {
                return comboBox_fy.SelectedIndex > -1;
            }
        }
        public class FYViwer
        {
            public int id { get; set; }
            public string name { get; set; }
            public Nullable<int> startdate { get; set; }
            public Nullable<int> enddate { get; set; }

            public override string ToString()
            {
                return name;
            }
        }


        public int[] Range
        {
            get
            {
                int[] r = new int[] { 0, 0 };
                switch (comboBox_duration.SelectedIndex)
                {
                    case 2:
                        r = nepaliCalenderfrom.getYearRange();

                        break;
                    case 3:
                        r = nepaliCalenderfrom.getMonthRange();

                        break;
                    case 4:
                        if (comboBox_week.SelectedIndex < 0)
                        {
                            CustomControls.Comformation.show(this.ParentForm.Text, "Please Select Fiscal Year", 1);
                            return null;
                        }
                        r = nepaliCalenderfrom.getMonthRange();

                        break;
                    case 5:

                        r[0] = nepaliCalenderfrom.Datestamp;
                        break;
                    case 6:
                        r[0] = nepaliCalenderfrom.Datestamp;
                        r[1] = nepaliCalender_to.Datestamp;
                        break;
                    default:
                        panel_dateselect.Height = 130;
                        break;
                        return null;
                }
                return r;
            }
        }
        public List<FYViwer> fYViwers { get; set; }
        public RangeSelector()
        {
            InitializeComponent();
        }

        public FYViwer fy
        {
            get
            {
                if (comboBox_fy.SelectedIndex == -1)
                {
                    return null;
                }
                else
                {
                    return comboBox_fy.SelectedItem as FYViwer;
                }
            }
        }
        public void init(List<FYViwer> _fYViwers)
        {
            fYViwers = _fYViwers;
            comboBox_fy.Items.AddRange(fYViwers.ToArray());
        }
        private void comboBox_duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_duration.SelectedIndex == 1)
            {
                panel_fy.Visible = true;
                panel_dateselect.Height = 0;
            }
            else if (comboBox_duration.SelectedIndex > 1)
            {

                panel_fy.Visible = false;
                switch (comboBox_duration.SelectedIndex)
                {
                    case 2:
                        label_fromdate.Text = "Year";
                        panel_dateselect.Height = 65;
                        comboBox_week.Visible = false;
                        label_week.Visible = false;
                        nepaliCalenderfrom.SelType = CustomControls.NepaliCalender.type.year;

                        break;
                    case 3:
                        label_fromdate.Text = "Year/Month";

                        panel_dateselect.Height = 65;
                        label_week.Visible = false;
                        comboBox_week.Visible = false;
                        nepaliCalenderfrom.SelType = CustomControls.NepaliCalender.type.month;

                        break;
                    case 4:
                        label_fromdate.Text = "Year/Month";
                        panel_dateselect.Height = 65;
                        label_week.Visible = true;
                        comboBox_week.Visible = true;
                        nepaliCalenderfrom.SelType = CustomControls.NepaliCalender.type.week;
                        break;
                    case 5:
                        label_fromdate.Text = "Date";
                        panel_dateselect.Height = 65;
                        comboBox_week.Visible = false;
                        label_week.Visible = false;

                        nepaliCalenderfrom.SelType = CustomControls.NepaliCalender.type.day;
                        break;
                    case 6:
                        label_fromdate.Text = "From" +
                            "";
                        panel_dateselect.Height = 130;
                        comboBox_week.Visible = false;
                        label_week.Visible = false;
                        nepaliCalenderfrom.SelType = CustomControls.NepaliCalender.type.day;
                        break;
                    default:
                        panel_dateselect.Height = 130;
                        break;
                }

            }
            else
            {
                panel_fy.Visible = false;
                panel_dateselect.Height = 0;
            }
        }
    }
}

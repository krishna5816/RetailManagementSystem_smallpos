using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailControls
{
    public delegate void EventDelegate(object sender, EventArgs e);
    public partial class NepaliCalender : UserControl
    {
        public NepaliCalender()
        {
            InitializeComponent();
            foreach (var item in NepDateConverter.getAllYears())
            {
                year.Items.Add(new AdvancedCombobox.ComboBoxItem()
                {
                    value = item.Key,
                    data = item.Value
                });
            }

            foreach (var item in NepDateConverter.GetMonths())
            {
                month.Items.Add(new AdvancedCombobox.ComboBoxItem(){
                    value=item.Key,data=item.Value});
            }

        }

        public enum type
        {
            day, month, year, week
        }


        public type SelType
        {

            set
            {
                switch (value)
                {
                    case type.day:
                        day.Visible = true;
                        month.Visible = true;
                        year.Visible = true;
                        break;
                    case type.month:
                        day.Visible = false;
                        month.Visible = true;
                        year.Visible = true;
                        break;
                    case type.week:
                        day.Visible = false;
                        month.Visible = true;
                        year.Visible = true;
                        break;
                    case type.year:
                        day.Visible = false;
                        month.Visible = false;
                        year.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private bool loadcomplete = false;
        private void NepaliCalender_Load(object sender, EventArgs e)
        {

        }


        private NepDate nepdate;
        public DateTime engdate { get; set; }
        public event EventDelegate changed;
        public NepDate date
        {
            get
            {
                return nepdate;
            }
            set
            {
                try
                {
                    nepdate = value;
                    year.selectBydata(nepdate.Year);
                    month.selectByValue(nepdate.Month);
                    day.Items.Clear();

                    for (var i = 1; i <= NepDateConverter.getMonthDays(year.getSelectedItem().getvalue<int>(), month.getSelectedItem().getvalue<int>()); i++)
                    {
                        day.addItem(i, i);
                    }
                    day.selectByValue(nepdate.Day);
                    engdate = NepDateConverter.NepToEng(nepdate);
                    if (changed != null)
                    {
                        changed(this, EventArgs.Empty);

                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void NepSel_Load(object sender, EventArgs e)
        {
            foreach (var years in NepDateConverter.getAllYears())
            {
                year.addItem(years.Value, years.Key);
            }

            foreach (var months in NepDateConverter.GetMonths())
            {
                month.addItem(months.Value, months.Key);
            }

            nepdate = NepDateConverter.EngToNep(DateTime.Now);
            year.selectBydata(nepdate.Year);
            month.selectByValue(nepdate.Month);
            day.Items.Clear();

            for (var i = 1; i <= NepDateConverter.getMonthDays(year.getSelectedItem().getvalue<int>(), month.getSelectedItem().getvalue<int>()); i++)
            {
                day.addItem(i, i);
            }
            day.selectByValue(nepdate.Day);
            loadcomplete = true;
            engdate = NepDateConverter.NepToEng(nepdate);
        }

        public void loadEnglishdate(DateTime dt)
        {
            if (!loadcomplete)
            {
                return;
            }
            engdate = dt;
            this.NepSel_Load(this, null);
            nepdate = NepDateConverter.EngToNep(DateTime.Now);
            year.selectBydata(nepdate.Year);
            month.selectByValue(nepdate.Month);
            day.Items.Clear();

            for (var i = 1; i <= NepDateConverter.getMonthDays(year.getSelectedItem().getvalue<int>(), month.getSelectedItem().getvalue<int>()); i++)
            {
                day.addItem(i, i);
            }
            day.selectByValue(nepdate.Day);
            if (changed != null)
            {
                changed(this, EventArgs.Empty);

            }
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
           
        {
            if (!loadcomplete)
            {
                return;
            }
            try
            {
                day.Items.Clear();

                for (var i = 1; i <= NepDateConverter.getMonthDays(year.getSelectedItem().getvalue<int>(), month.getSelectedItem().getvalue<int>()); i++)
                {
                    day.addItem(i, i);
                }
                day.selectByValue(1);

                nepdate = new NepDate()
                {
                    Year = year.getSelectedItem().getdata<int>(),
                    Month = month.getSelectedItem().getvalue<int>(),
                    Day = day.getSelectedItem().getvalue<int>()
                };

                engdate = NepDateConverter.NepToEng(nepdate);
                if (changed != null)
                {
                    changed(this, EventArgs.Empty);

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadcomplete)
            {
                return;
            }
            try
            {

                nepdate = new NepDate()
                {
                    Year = year.getSelectedItem().getdata<int>(),
                    Month = month.getSelectedItem().getvalue<int>(),
                    Day = day.getSelectedItem().getvalue<int>()
                };

                engdate = NepDateConverter.NepToEng(nepdate);
                if (changed != null)
                {
                    changed(this, EventArgs.Empty);

                }
            }
            catch (Exception ex)
            {

            }
        }

        public int[] getWeek(int i)
        {
            var week = new int[] { 1, 0 };
            week[0] = new NepDate(
                  date.Year,
                  date.Month,
                  (i * 7) + 1
                ).TIMESTAMP();
            week[1] = new NepDate(
                 date.Year,
                 date.Month,
                  (i * 7) + 7
                ).TIMESTAMP();
            return week;
        }

        public int[] getMonth()
        {
            var month = new int[] { 0, 1 };
            month[0] = new NepDate(
                date.Year,
                date.Month,
                  1
                ).TIMESTAMP();
            month[1] = new NepDate(
                 date.Year,
                 date.Month,
                  32
                ).TIMESTAMP();
            return month;
        }

        public int[] getYear()
        {
            var year = new int[] { 0, 1 };
            year[0] = new NepDate(
                  date.Year,
                  1,
                  1
                ).TIMESTAMP();
            year[1] = new NepDate(
                  date.Year,
                  12,
                  32
                ).TIMESTAMP();
            return year;
        }

        public int DATESTAMP
        {
            get
            {
                return new NepDate(
                  date.Year,
                  date.Month,
                  date.Day
                ).TIMESTAMP();
            }
            set
            {
                var r = value;
                var y = value / 10000;
                r = r % 10000;
                var m = r / 100;
                r = r % 100;
                date = new NepDate(y, m, r);
            }
        }
    }
}

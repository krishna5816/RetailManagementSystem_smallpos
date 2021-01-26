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
    public partial class NepaliCalender : UserControl
    {


        public int Datestamp
        {
            get
            {
                return ((int)comboBox_year.SelectedItem * 10000) + (((int)comboBox_month.SelectedIndex + 1) * 100) + ((int)comboBox_day.SelectedItem);
            }
            set
            {
                var year = value / 10000;
                value = value % 10000;
                var month = value / 100;
                value = value % 100;

                NepaliDate.setNepaliDate(year, month, value);
                refresh();
            }
        }


        bool loaded;
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
                        comboBox_day.Visible = true;
                        comboBox_month.Visible = true;
                        comboBox_year.Visible = true;
                        break;
                    case type.month:
                        comboBox_day.Visible = false;
                        comboBox_month.Visible = true;
                        comboBox_year.Visible = true;
                        break;
                    case type.week:
                        comboBox_day.Visible = false;
                        comboBox_month.Visible = true;
                        comboBox_year.Visible = true;
                        break;
                    case type.year:
                        comboBox_day.Visible = false;
                        comboBox_month.Visible = false;
                        comboBox_year.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }


        public Boolean isempty
        {
            get
            {
                return comboBox_day.SelectedIndex < 0;
            }
        }
        public delegate void yearMonthChangeHandler();
        public event yearMonthChangeHandler yearMonthChange;

        public delegate void dateChangeHandler(int year, int month, int day);
        public event dateChangeHandler dateChange;

        public NepaliDate NepaliDate;

        public DateTime DateTime
        {
            get
            {
                return new DateTime(NepaliDate.englishYear, NepaliDate.englishMonth, NepaliDate.englishDate);
            }
            set
            {
                NepaliDate.setEnglishDate(value.Year, value.Month, value.Day);
                refresh();
            }
        }

        public NepaliCalender()
        {
            InitializeComponent();
            NepaliDate = new NepaliDate();

            for (int i = 2000; i < 2100; i++)
            {
                comboBox_year.Items.Add(i);
            }

            foreach (var item in NepaliDate.nepaliMonthsWords)
            {
                comboBox_month.Items.Add(item);
            }

            NepaliDate.setCurrentDate();
            refresh();
            loaded = true;
        }

        void refresh()
        {

            comboBox_year.SelectedItem = NepaliDate.nepaliYear;
            comboBox_month.SelectedIndex = NepaliDate.nepaliMonth - 1;
            comboBox_day.SelectedItem = NepaliDate.nepaliDate;
        }

        public int[] MonthRange
        {
            get
            {
                return new int[]
                {
                    comboBox_year.SelectedIndex,comboBox_month.SelectedIndex
                };
            }
            set
            {
                comboBox_year.SelectedIndex = value[0];
                comboBox_month.SelectedIndex = value[1];
            }
        }

        public int[] DayArray
        {
            get
            {
                return new int[]
                {
                    comboBox_year.SelectedIndex,comboBox_month.SelectedIndex,comboBox_day.SelectedIndex

                };


            }
            set
            {
                comboBox_year.SelectedIndex = value[0];
                comboBox_month.SelectedIndex = value[1];
                comboBox_day.SelectedIndex = value[2];
            }

        }

        public int DaysInMonth
        {
            get
            {

                return NepaliDate.nepaliMonths[comboBox_year.SelectedIndex][comboBox_month.SelectedIndex];
            }
        }


        public int[] DayRange
        {
            get
            {
                return new int[]
                {
                     ((int)comboBox_year.SelectedItem * 10000) + (((int)comboBox_month.SelectedIndex + 1) * 100) + 1,
                     ((int)comboBox_year.SelectedItem * 10000) + (((int)comboBox_month.SelectedIndex + 1) * 100) + DaysInMonth
                };
            }
        }




        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                comboBox_day.Items.Clear();
                comboBox_day.Text = "";
                if (comboBox_month.SelectedIndex > -1 && comboBox_year.SelectedIndex > -1)
                {

                    for (int i = 1; i <= NepaliDate.nepaliMonths[comboBox_year.SelectedIndex][comboBox_month.SelectedIndex]; i++)
                    {
                        comboBox_day.Items.Add(i);
                    }
                    //comboBox_day.SelectedIndex = 0;
                    yearMonthChange?.Invoke();
                }
            }
            catch (Exception)
            {

            }
        }

        private void comboBox_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_day.SelectedIndex > -1)
                {


                    NepaliDate.setNepaliDate((int)comboBox_year.SelectedItem, comboBox_month.SelectedIndex + 1, comboBox_day.SelectedIndex + 1);

                    dateChange?.Invoke((int)comboBox_year.SelectedItem, comboBox_month.SelectedIndex + 1, comboBox_day.SelectedIndex + 1);
                }


            }
            catch (Exception)
            {

            }
        }

        public int[] getYearRange()
        {
            var i = new List<int>();
            i.Add(((int)comboBox_year.SelectedItem * 10000) + 00 + 00);
            i.Add(((int)comboBox_year.SelectedItem * 10000) + 1200 + 33);
            return i.ToArray();
        }

        public int[] getMonthRange()
        {
            var i = new List<int>();
            i.Add(((int)comboBox_year.SelectedItem * 10000) + (((int)comboBox_month.SelectedIndex + 1) * 100) + 00);
            i.Add(((int)comboBox_year.SelectedItem * 10000) + (((int)comboBox_month.SelectedIndex + 1) * 100) + 33);
            return i.ToArray();
        }

        public int[] getWeekRange(int ii)
        {
            var i = new List<int>();
            var t = ii * 7;
            var t1 = t + 7;
            i.Add(((int)comboBox_year.SelectedItem * 10000) + (((int)comboBox_month.SelectedIndex + 1) * 100) + t);
            i.Add(((int)comboBox_year.SelectedItem * 10000) + (((int)comboBox_month.SelectedIndex + 1) * 100) + t1);
            return i.ToArray();
        }
    }
}

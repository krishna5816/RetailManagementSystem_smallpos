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
namespace RetailManagementSystem.REPORTS
{

    public partial class ExpenseReport : UserControl
    {
        HamroSuperMarketEntities db = new HamroSuperMarketEntities();
        string[] categoryColheaders = { "SN", "Expense Category", "Amount" };
        string[] singleColheaders = { "SN", "name", "Expense Category", "Amount", "issued By" };

        public ExpenseReport()
        {
            InitializeComponent();
        }

        private void comboBox_sales_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_sales.SelectedIndex)
            {
                case 0:
                    nepaliCalender_sales_end.Visible = false;
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_sales_start.SelType = NepaliCalender.type.day;
                    break;
                case 1:
                    nepaliCalender_sales_end.Visible = false;
                    nepaliCalender_sales_start.SelType = NepaliCalender.type.week;
                    comboBox_sales_week.Visible = true;
                    break;
                case 2:
                    nepaliCalender_sales_end.Visible = false;
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_sales_start.SelType = NepaliCalender.type.month;
                    break;
                case 3:
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_sales_start.SelType = NepaliCalender.type.year;
                    nepaliCalender_sales_end.Visible = false;

                    break;
                case 4:
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_sales_start.SelType = NepaliCalender.type.day;
                    nepaliCalender_sales_end.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private IQueryable<expence> GetExpences(int cat_id)
        {
            IQueryable<expence> bills;
            var q = db.expences.Where(o=>o.id==cat_id);
            bills = q;
            if (comboBox_sales.SelectedIndex == 0)
            {
                bills = q.Where(o => o.year == nepaliCalender_sales_start.DATESTAMP);
            }
            else if (comboBox_sales.SelectedIndex == 1)
            {
                var week = nepaliCalender_sales_start.getWeek(comboBox_sales_week.SelectedIndex);
                var starweek = week[0];
                var endweek = week[0];
                bills = q.Where(o => o.day >= starweek && o.day <= endweek);
            }
            else if (comboBox_sales.SelectedIndex == 2)
            {
                var month = nepaliCalender_sales_start.getMonth();
                var startmonth = month[0];
                var endmonth = month[1];
                q.Where(o => o.day >= startmonth && o.day <= endmonth);
            }
            else if (comboBox_sales.SelectedIndex == 3)
            {
                var year = nepaliCalender_sales_start.getYear();
                var startyear = year[0];
                var endyear = year[1];
                q.Where(o => o.day >= startyear && o.day <= endyear);
            }
            else if (comboBox_sales.SelectedIndex == 4)
            {
                bills = q.Where(o => o.day == nepaliCalender_sales_start.DATESTAMP && o.day<=nepaliCalender_sales_end.DATESTAMP);
            }

            return bills;
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Clear();
                decimal total = 0;
                List<expencecategory> exptypes = new List<expencecategory>();
                if (checkBox_types.Checked)
                {
                    if (listBox_categories.SelectedItems.Count == 0)
                    {
                        return;
                    }
                    exptypes = listBox_categories.SelectedItems.Cast<expencecategory>().ToList();
                }
                else
                {
                    exptypes = db.expencecategories.ToList();
                }

                if (radioButton_sales_group.Checked)
                {
                    listView1.Clear();
                    listView1.Columns.AddRange(Helpers.arrayToHeaders(categoryColheaders));
                    foreach (var exptype in exptypes)
                    {
                        var exps = GetExpences(exptype.id);
                        if (exps.Count() > 0)
                        {

                            var cattotal = exps.Sum(o => o.amount);
                            total += cattotal.Value;
                            listView1.Items.Add(
                                new ListViewItem(
                                    new string[]{
                                        listView1.Items.Count.ToString(),
                                        exptype.name,
                                        cattotal.ToString()
                                    }
                            ));
                        }
                    }
                }
                else
                {

                    listView1.Columns.AddRange(Helpers.arrayToHeaders(singleColheaders));
                    foreach (var exptype in exptypes)
                    {
                        listView1.Clear();
                        var exps = GetExpences(exptype.id);
                        foreach (var item in exps.ToList())
                        {
                            total += item.amount.Value;
                            listView1.Items.Add(
                                new ListViewItem(new string[] {
                                    listView1.Items.Count.ToString(),
                                    item.name,
                                    exptype.name,
                                    item.amount.ToString(),
                                    

                                }));
                        }
                    }
                }
                label_totalamount.Text = total.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

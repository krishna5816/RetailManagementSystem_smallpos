using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using EPPlusTest;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailControls;
using OfficeOpenXml;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.REPORTS
{
    public partial class SalesReport : UserControl
    {

        HamroSuperMarketEntities db;
        string[] categoryHeader =
        {
            "SN","Category Name","Total Quantity ","Total Amount","Dis","Cash","Credit","Margin"
        };
        string[] itemHeader =
        {
            "SN","Item Name","Total Quantity ","Average Rate","Total Amount","Dis","Cash","Credit"
        };

        string[] billHeader =
        {
            "SN","Date","Billno","Total","Dis","Cash","Credit","Margin"
        };
        internal class categoryViwer
        {


            public string Cat_Name { get; set; }
            public decimal total { get; set; }
            public decimal amount { get; set; }
            public decimal cash { get; set; }
            public decimal credit { get; set; }
            public decimal discount { get; set; }
            public decimal margin { get; set; }
        }
        internal class ItemViwer
        {
            public string Item_Name { get; set; }
            public decimal total { get; set; }
            public decimal avgrate { get; set; }
            public decimal amount { get; set; }
            public decimal cash { get; set; }
            public decimal credit { get; set; }
            public decimal discount { get; set; }
            public decimal returns { get; set; }
            public decimal margin { get; set; }

        }

        public SalesReport()
        {
            InitializeComponent();
            db = new HamroSuperMarketEntities();
            listBox_categories.Items.AddRange(db.categories.ToArray());
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            var bills = GetBills();
            decimal total = 0;
            decimal totalmargin = 0;
            decimal totaldis = 0;
            decimal totalcredit = 0;
            decimal totalcash = 0;
            decimal returns = 0;
            if (radioButton_sales_billWise.Checked)
            {
                listView1.Columns.AddRange(Helpers.arrayToHeaders(billHeader));
                foreach (var bill in bills.ToList())
                {
                    var margin = bill.billitems.Sum(o => o.margin);
                    listView1.Items.Add(
                        new ListViewItem(new string[]{
                            (listView1.Items.Count+1).ToString(),
                           RetailControls.Helpers.DateStampToString(bill.day.Value),
                            bill.id.ToString(),
                            bill.grosstotal.ToString(),
                            bill.discount.ToString(),
                            bill.paid.ToString(),
                            bill.due.ToString(),
                           // bill.returns.ToString(),
                           margin.ToString("0.##")
                        }));
                    total += bill.grosstotal.Value;
                    totalmargin += margin;
                    totalcash += bill.paid.Value-bill.returns.Value;
                    totalcredit += bill.due.Value;
                    totaldis += bill.discount.Value;
                }
            }
            else if (radioButton_sales_group.Checked)
            {
                listView1.Columns.AddRange(Helpers.arrayToHeaders(categoryHeader));
                foreach (var bill in getByCategory(bills).ToList())
                {
                    var b = bill.Value;
                    listView1.Items.Add(
                        new ListViewItem(new string[]{
                            (listView1.Items.Count+1).ToString(),

                            b.Cat_Name,
                            b.total.ToString(),
                            b.amount.ToString(),
                             b.discount.ToString(),
                            b.cash.ToString(),
                            b.credit.ToString(),
                            b.margin.ToString()
                        }));
                    total += b.amount;
                    totalmargin += b.margin;
                    totalcash += b.cash;
                    totalcredit += b.credit;
                    totaldis += b.discount;
                }

            }
            else if (radioButton__sales_single.Checked)
            {
                listView1.Columns.AddRange(Helpers.arrayToHeaders(itemHeader));
                foreach (var bill in getByItem(bills).ToList())
                {
                    var b = bill.Value;
                    var averagerate = b.amount / b.total;
                    listView1.Items.Add(
                        new ListViewItem(new string[]{
                            (listView1.Items.Count+1).ToString(),

                            b.Item_Name,
                            b.total.ToString(),
                            averagerate.ToString(),
                            b.amount.ToString(),
                            b.discount.ToString(),
                            b.cash.ToString(),
                            b.credit.ToString(),
                            b.margin.ToString()
                        }));
                    total += b.amount;
                    totalmargin += b.margin;
                    totalcash += b.cash;
                    totalcredit += b.credit;
                    totaldis += b.discount;
                }
            }
            else if (radioButton_daily.Checked)
            {
                getBillByDate();
            }
            label_totalamount.Text = total.ToString();
            label_totalmargin.Text = totalmargin.ToString();
            label_totalcash.Text = totalcash.ToString();
            label_totalcredit.Text = totalcredit.ToString();
            label_dis.Text = totaldis.ToString();
        }

        private void getBillByDate()
        {
            var dailybills = GetBills().GroupBy(o => o.day).Select(o => new
            {
                date = o.Key,
                totalsale = o.Where(p => p.day == o.Key).Sum(p => p.total)
            }).ToList();

            listView1.Columns.AddRange(Helpers.arrayToHeaders(new string[] { "SN", "Date", "Total" }));
            foreach (var bill in dailybills)
            {

                listView1.Items.Add(
                    new ListViewItem(new string[]{
                            (listView1.Items.Count+1).ToString(),
                           bill.date.Value.ToNepaliDate(),
                           bill.totalsale.Value.ToString("0.##")

                    }));

            }
        }

        private IQueryable<bill> GetBills()
        {
            IQueryable<bill> bills;
            var q = db.bills;
            bills = q;
            if (comboBox_sales.SelectedIndex == 0)
            {
                bills = q.Where(o => o.day == nepaliCalender_sales_start.DATESTAMP);
            }
            else if (comboBox_sales.SelectedIndex == 1)
            {
                var week = nepaliCalender_sales_start.getWeek(comboBox_sales_week.SelectedIndex);
                var weekstart = week[0];
                var weekend = week[1];
                bills = q.Where(o => o.day >= weekstart && o.day <= weekend);
            }
            else if (comboBox_sales.SelectedIndex == 2)
            {
                var month = nepaliCalender_sales_start.getMonth();
                var monthstart = month[0];
                var monthend = month[1];
                bills = q.Where(o => o.day >= monthstart && o.day <= monthend);
            }
            else if (comboBox_sales.SelectedIndex == 3)
            {
                var year = nepaliCalender_sales_start.getYear();
                var yearstart = year[0];
                var yearend = year[1];
                bills = q.Where(o => o.day >= yearstart && o.day <= yearend);
            }
            else if (comboBox_sales.SelectedIndex == 4)
            {
                bills = q.Where(o =>

                (o.day >= nepaliCalender_sales_start.DATESTAMP && o.day <= nepaliCalender_sales_end.DATESTAMP));
            }

            return bills;
        }

        private Dictionary<int, categoryViwer> getByCategory(IQueryable<bill> bills)
        {
            Dictionary<int, categoryViwer> deal = new Dictionary<int, categoryViwer>();
            foreach (var item in bills.ToList())
            {
                foreach (var bitems in item.billitems)
                {
                    if (checkBox_types.Checked)
                    {
                        var t = false;
                        foreach (category cats in listBox_categories.SelectedItems)
                        {
                            if (cats.id == bitems.item.category_id)
                            {
                                t = true;
                            }

                        }

                        if (!t)
                        {
                            continue;
                        }
                    }
                    if (deal.Count(o => o.Key == bitems.item.category_id.Value) > 0)
                    {
                        var d = deal.First(o => o.Key == bitems.item.category_id.Value);

                        d.Value.total += bitems.quantity.Value;
                        d.Value.discount += bitems.bill.discount.Value;
                        d.Value.cash += bitems.bill.paid.Value;
                        d.Value.credit += bitems.bill.due.Value;
                        d.Value.margin += bitems.margin;
                        d.Value.amount += (bitems.quantity.Value * bitems.rate.Value);
                    }
                    else
                    {
                        deal.Add(bitems.item.category_id.Value, new categoryViwer()
                        {

                            Cat_Name = bitems.item.category.name,
                            amount = (bitems.quantity.Value * bitems.rate.Value),
                            discount = bitems.bill.discount.Value,
                            cash = bitems.bill.paid.Value,
                            credit = bitems.bill.due.Value,
                            total = bitems.quantity.Value,
                            margin = bitems.margin
                        });
                    }
                }

            }
            return deal;
        }

        private Dictionary<int, ItemViwer> getByItem(IQueryable<bill> bills)
        {
            Dictionary<int, ItemViwer> deal = new Dictionary<int, ItemViwer>();
            foreach (var item in bills.ToList())
            {
                foreach (var bitems in item.billitems)
                {
                    if (checkBox_types.Checked)
                    {
                        var t = false;
                        foreach (category cats in listBox_categories.SelectedItems)
                        {
                            if (cats.id == bitems.item.category_id)
                            {
                                t = true;
                            }

                        }

                        if (!t)
                        {
                            continue;
                        }
                    }
                    if (deal.Count(o => o.Key == bitems.item_id.Value) > 0)
                    {
                        var d = deal.First(o => o.Key == bitems.item_id.Value);
                        d.Value.total += bitems.quantity.Value;
                        d.Value.margin += bitems.margin;
                        d.Value.discount += bitems.bill.discount.Value;
                        d.Value.cash += bitems.bill.paid.Value;
                        d.Value.credit += bitems.bill.due.Value;
                        d.Value.amount += (bitems.quantity.Value * bitems.rate.Value);
                    }
                    else
                    {
                        deal.Add(bitems.item_id.Value, new ItemViwer()
                        {

                            Item_Name = bitems.item.name,
                            amount = (bitems.quantity.Value * bitems.rate.Value),
                            total = bitems.quantity.Value,
                            discount=bitems.bill.discount.Value,
                            cash=bitems.bill.paid.Value,
                            credit=bitems.bill.due.Value,
                            margin = bitems.margin
                        });
                    }
                }

            }
            return deal;
        }

        private void radioButton_sales_billWise_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_export_Click(object sender, EventArgs e)
        {
            if (checkBox_mr0.Checked == true)
            {

            }
            var s = new SaveFileDialog();
            s.Filter = "*.xls|*.xls";
            if (s.ShowDialog() == DialogResult.OK)
            {

                listView1.ToExcel("salesreports", s.FileName);
            }
        }

        private void checkBox_mr0_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

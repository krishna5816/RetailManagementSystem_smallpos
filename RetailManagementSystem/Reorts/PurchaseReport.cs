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
    public partial class PurchaseReport : UserControl
    {
        HamroSuperMarketEntities db;

        string[] categoryHeader =
        {
            "SN","Category Name","Total Quantity ","Total Amount"
        };
        string[] itemHeader =
        {
            "SN","Item Name","Total Quantity ","Average Rate","Total Amount"
        };

        string[] billHeader =
        {
            "SN","Billno","Total","due","Vendor"
        };

        string[] vendorHeader =
        {
            "SN","VendorName","Amount","Due"
        };
        internal class categoryViwer
        {
            public string date { get; set; }
            public string Cat_Name { get; set; }
            public decimal total { get; set; }
            public decimal amount { get; set; }
        }
        internal class vendorViwer
        {
           
            public string name { get; set; }
            public decimal total { get; set; }
            public decimal due { get; set; }
        }
        internal class ItemViwer
        {
          
            public string Item_Name { get; set; }
            public decimal total { get; set; }
            public decimal avgrate { get; set; }
            public decimal amount { get; set; }
        }
        public PurchaseReport()
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

        private IQueryable<supply> GetSupplies()
        {
            IQueryable<supply> bills;
            var q = db.supplies;
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


        private Dictionary<int, categoryViwer> getByCategory(IQueryable<supply> bills)
        {
            Dictionary<int, categoryViwer> deal = new Dictionary<int, categoryViwer>();
            foreach (var item in bills.ToList())
            {
                foreach (var bitems in item.supplyitems)
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
                        d.Value.amount += (bitems.quantity.Value * bitems.rate.Value);
                    }
                    else
                    {
                        deal.Add(bitems.item.category_id.Value, new categoryViwer()
                        {
                           
                            Cat_Name = bitems.item.category.name,
                            amount = (bitems.quantity.Value * bitems.rate.Value),
                            total = bitems.quantity.Value
                        });
                    }
                }

            }
            return deal;
        }

        private Dictionary<int, vendorViwer> getByVendor(IQueryable<supply> bills)
        {
            Dictionary<int, vendorViwer> deal = new Dictionary<int, vendorViwer>();
            foreach (var item in bills.ToList())
            {

                if (item.vendor_id == null)
                {
                    item.vendor_id = 0;
                }
                if (deal.Count(o => o.Key == item.vendor_id) > 0)
                {
                    var v = deal.First(o => o.Key == item.vendor_id);
                    v.Value.total += item.total.Value;
                    v.Value.due+= item.due.Value;
                }
                else
                {
                    if (item.vendor_id == 0)
                    {
                        deal.Add(item.vendor_id.Value, new vendorViwer()
                        {
                            name = "Other Vendors",
                            total = item.total.Value,
                            due = item.due.Value
                        });
                    }
                    else
                    {

                        deal.Add(item.vendor_id.Value, new vendorViwer()
                        {
                           
                            name =item.vendor.name,
                            total=item.total.Value,
                            due=item.due.Value
                        });
                    }
                }

            }
            return deal;
        }

        private Dictionary<int, ItemViwer> getByItem(IQueryable<supply> bills)
        {
            Dictionary<int, ItemViwer> deal = new Dictionary<int, ItemViwer>();
            foreach (var item in bills.ToList())
            {
                foreach (var bitems in item.supplyitems)
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
                        var d = deal.First(o => o.Key == bitems.item.id);
                        d.Value.total += bitems.quantity.Value;
                        d.Value.amount += (bitems.quantity.Value * bitems.rate.Value);
                    }
                    else
                    {
                        deal.Add(bitems.item_id.Value, new ItemViwer()
                        {
                           
                            Item_Name = bitems.item.name,
                            amount = (bitems.quantity.Value * bitems.rate.Value),
                            total = bitems.quantity.Value
                        });
                    }
                }

            }
            return deal;
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            var supplies = GetSupplies();
            label_totalamount.Text = supplies.Sum(o => o.total).ToString();
            if (radioButton_sales_group.Checked)
            {
                listView1.Columns.AddRange(Helpers.arrayToHeaders(categoryHeader));
                foreach (var item in getByCategory(supplies).ToList())
                {
                    listView1.Items.Add(new ListViewItem(new string[] {
                        ((listView1.Items.Count)+1).ToString() ,
                        item.Value.Cat_Name,
                        item.Value.total.ToString(),
                        item.Value.amount.ToString(),
                    }));
                }
                
            }else if (radioButton__sales_single.Checked)
            {
                listView1.Clear();
                listView1.Columns.AddRange(Helpers.arrayToHeaders(itemHeader));
                foreach (var item in getByItem(supplies).ToList())
                {
                    var averagerate = item.Value.amount / item.Value.total;
                    listView1.Items.Add(new ListViewItem(new string[] {
                        ((listView1.Items.Count)+1).ToString() ,                      
                        item.Value.Item_Name,
                        item.Value.total.ToString(),
                        averagerate.ToString(),
                        item.Value.amount.ToString(),
                    }));
                }
            }
            else if (radioButton_sales_billWise.Checked)
            {
                listView1.Clear();
                listView1.Columns.AddRange(Helpers.arrayToHeaders(billHeader));
                foreach (var item in supplies.ToList())
                {
                    var name = "not available";
                    if (item.vendor != null)
                    {
                        name = item.vendor.name;
                    }
                    listView1.Items.Add(new ListViewItem(new string[] {
                        ((listView1.Items.Count)+1).ToString() ,
                       item.bill_no.ToString(),
                       item.total.ToString(),
                       item.due.ToString()   ,
                       name
                    }));
                }
            }
            else if (radioButton_vendorwise.Checked)
            {
                listView1.Clear();
                listView1.Columns.AddRange(Helpers.arrayToHeaders(vendorHeader));
                foreach (var item in getByVendor(supplies).ToList())
                {
                    
                    listView1.Items.Add(new ListViewItem(new string[] {
                        ((listView1.Items.Count)+1).ToString() ,
                       item.Value.name,
                       item.Value.total.ToString(),
                       item.Value.due.ToString(),

                    }));
                }

            }
            else if (radioButton_daily.Checked)
            {
                getBillByDate();
            }
        }
        private void getBillByDate()
        {
            var dailybills = GetSupplies().GroupBy(o => o.day).Select(o => new
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
        private void button_export_Click(object sender, EventArgs e)
        {
            var s = new SaveFileDialog();
            s.Filter = "*.xls|*.xls";
            if (s.ShowDialog() == DialogResult.OK)
            {

                listView1.ToExcel("salesreports", s.FileName);
            }
        }
    }
}

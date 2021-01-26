using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RetailManagementSystem.SalesReturns
{
    public class Viewer : ListViewItem
    {
        Models.HamroSuperMarketEntities db = new Models.HamroSuperMarketEntities();
        private decimal disunit=0;
        private decimal? max = 0;
        private int _id { get; set; }
        private int _date { get; set; }
        private string _name { get; set; }
        private Nullable<decimal> _qty { get; set; }
        private Nullable<decimal> _rate { get; set; }
        private Nullable<decimal> _discount { get; set; }
        private Nullable<decimal> _total { get; set; }


        public int date { get { return _date; } set { _date = value; SubItems[1].Text = value.ToString(); } }
        public string name { get { return _name; } set { _name = value; SubItems[2].Text = value; } }
        public Nullable<decimal> qty
        {
            get { 
                return _qty;

            }
            set {
                
                _qty = value; SubItems[3].Text = value.ToString(); 
            }
        }
        public Nullable<decimal> rate
        {
            get { return _rate; }
            set { _rate = value; SubItems[4].Text = value.ToString(); ; }
        }
        public Nullable<decimal> discount
        {
            get { return _discount; }
            set { _discount = value; SubItems[5].Text = value.ToString(); ; }
        }
        public Nullable<decimal> total
        {
            get { return _total; }
            set { _total = value; SubItems[6].Text = value.ToString(); ; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; SubItems[7].Text = value.ToString(); ; }
        }
        public  Viewer(Models.billitem billitem, int day, int sn)
        {
            for (int i = 0; i < 8; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            date =day;
            name = billitem.item.name;
            qty = billitem.quantity.Value;
            rate = billitem.rate;
            discount = billitem.item_discount;
            total = (qty * rate) - discount;
            id=billitem.item_id.Value;
            disunit = discount.Value / qty.Value;
            this.SubItems[0].Text = sn.ToString();
            max = this.qty;
        }

        public void add(int __qty)
        {
            if (qty + __qty > max)
            {
                qty = max;
            }
            else
            {
                qty += __qty;
               
            }
                discount = disunit * qty;
                total = (qty * rate) - discount;
        }

        public void minus(int __qty)
        {
            if (qty - __qty <= 0)
            {
                this.ListView.Items.Remove(this);
            }
            else
            {
                qty -= __qty;

            }
            discount = disunit * qty;
            total = (qty * rate) - discount;

        }
        public void save(int creditnote_id)
        {
            var Item = db.items.Find(id);
            Item.stock += qty;
            db.Entry(Item).State = System.Data.Entity.EntityState.Modified;
            var creditnoteitmes = new Models.creditnoteitem()
            {
               
                unitrate = rate.Value,
                qty = qty.Value,
                nettotal = ((rate.Value * qty.Value)),
                item_id = id,
                creditnote_id = creditnote_id,
                unitdiscount = discount.Value,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            db.creditnoteitems.Add(creditnoteitmes);
            db.SaveChanges();
        }
    }
}

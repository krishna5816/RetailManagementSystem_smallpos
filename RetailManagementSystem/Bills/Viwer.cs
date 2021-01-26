using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RetailManagementSystem.Bills_form
{
  public  class Viwer:ListViewItem
    {
        Models.HamroSuperMarketEntities db = new Models.HamroSuperMarketEntities();
        public delegate void modifyHandler();
        public event modifyHandler modify;

        public int id { get; set; }
        public string name { get; set; }
        public decimal qty { get; set; }
        public decimal rate { get; set; }
        public decimal tax { get; set; }
        public decimal discount { get; set; }
        public decimal item_dis { get; set; }
        public decimal total { get; set; }
        public decimal grosstotal { get; set; }

        public int sn { get; set; }
        public decimal savedis;

        Models.item item;
        public Viwer(Models.item _item, decimal _qty, int _sn, decimal rateamount, decimal discou)
        {
            for (int i = 0; i < 9; i++)
            {
                this.SubItems.Add(new ListViewSubItem());
            }
            item = _item;
            qty = _qty;
            sn = _sn;
            rate = rateamount;
            item_dis = discou;
            refresh();
        }
        public void addItem(decimal _qty)
        {
            qty += _qty;
            refresh();
            modify?.Invoke();
        }

        public void removeItem(decimal _qty)
        {
            qty -= _qty;
            if (qty >= 0)
            {
                modify?.Invoke();
                this.ListView.Items.Remove(this);
            }
            else
            {
                refresh();
                modify?.Invoke();

            }
        }

        public void refresh()
        {
            id = item.id;
            decimal itemdis = (item_dis * qty);
            name = item.name;
            grosstotal = ((qty * rate) - itemdis);
            SubItems[0].Text = sn.ToString();
            SubItems[1].Text = name;
            SubItems[2].Text = rate.ToString();
            SubItems[3].Text = itemdis.ToString();
            SubItems[4].Text = qty.ToString();
            SubItems[5].Text = grosstotal.ToString();
            SubItems[6].Text = id.ToString();
            this.savedis = itemdis;
        }
        public void save(int bill_id)
        {
            var Item = db.items.Find(id);
            Item.stock -= qty;
            var unitmargin = rate - Item.buyrate;
            db.Entry(Item).State = System.Data.Entity.EntityState.Modified;
            var billitm = new Models.billitem()
            {
                rate = rate,
                quantity = qty,
                amount = ((rate*qty)-savedis),
                item_id = id,
                bill_id = bill_id,
                item_discount=savedis,
                margin =(decimal) unitmargin * qty,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            db.billitems.Add(billitm);
            db.SaveChanges();
        }
    }
}

   
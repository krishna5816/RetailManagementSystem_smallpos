using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailManagementSystem.Models;
namespace RetailManagementSystem.ITEMS
{
    public class ItemViwer :ListViewItem
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private Nullable<int> _category_id { get; set; }
        private Nullable<decimal> _stock { get; set; }
        private Nullable<decimal> _rate { get; set; }
        private Nullable<decimal> _byrate { get; set; }
        private Nullable<decimal> _wholesaleprice { get; set; }
        private Nullable<decimal> _totalcostprice { get; set; }
        public Nullable<decimal> byrate {
            get
            {
                return _byrate;
            }
            set
            {
                _byrate = value;
                SubItems[6].Text = value!=null?value.Value.ToString("00.##"):"00";
            }
        }
        
       
        public string name { get { return _name; } set { _name = value; SubItems[1].Text = value; } }
        public Nullable<int> category_id {
            get
            {
                return _category_id;
            }
            set
            {
                _category_id = value;
                using (var db=new HamroSuperMarketEntities())
                {
                    SubItems[2].Text = db.categories.Find(value).name;
                }
            }
        }
        public Nullable<decimal> rate { get { return _rate; } set { _rate = value; SubItems[3].Text = value.ToString(); } }
        public Nullable<decimal> wholwsaleoprice { get { return _wholesaleprice; } set { _wholesaleprice = value;SubItems[4].Text = value.ToString(); } }
        public Nullable<decimal> stock { get { return _stock; } set { _stock= value; SubItems[5].Text = value.ToString(); } }
       
        public int id { get { return _id; } set { _id = value; SubItems[7].Text = value.ToString(); } }
        public ItemViwer(item itm,int sn)
        {
            for (int i = 0; i < 8; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = itm.id;
            name = itm.name;
            category_id = itm.category_id;
            stock = itm.stock;
            rate = itm.rate;
            wholwsaleoprice = itm.wholesaleprice;
            this.SubItems[0].Text = sn.ToString();
            byrate = itm.buyrate==null?0:itm.buyrate;
            sn = sn + 1;
        }
        
        public void update(item itm)
        {
            
            id = itm.id;
            name = itm.name;
            category_id = itm.category_id;
            stock = itm.stock;
            rate = itm.rate;
            byrate = itm.buyrate;
            wholwsaleoprice = itm.wholesaleprice;

        }
    }
}
